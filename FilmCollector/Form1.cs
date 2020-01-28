using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Recls;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;

namespace FilmCollector
{
    public partial class MainForm : Form
    {
        List<string> drivesList;
        List<Tuple<string, string>> movies; //data source za listu pronadjenih filmova - dgvMovies
        List<Tuple<string, string>> genrePaths;//lista torki oblika: <Zanr, Lokacija na disku>
        List<Tuple<string, List<string>>> genres; //data source za listu titlova sa zanrovima
        
        string constring = "data source=";

        private const int WM_DEVICECHANGE = 0x219;
        private const int DBT_DEVICEARRIVAL = 0x8000;
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_DEVICECHANGE)
            {
                switch (m.WParam.ToInt32())
                {
                    case DBT_DEVICEARRIVAL:
                        prepareDrives();
                        break;
                    case DBT_DEVICEREMOVECOMPLETE:
                        prepareDrives();
                        break;
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();

            LoadGenres();

            string[] formats = { ".mp4", ".mkv", ".avi", ".flv", ".wmv", ".mov", ".m2t"}; //formati filmova
            //string[] formats = { ".txt", ".zip", ".rar" };

            for(int i=0; i< formats.Length; i++)
            {
                tlpFormats.Controls[i].Text = formats[i];
            }
            //clbFormats.Items.AddRange(formats);
            txtSourceFolder.ForeColor = Color.FromName("ControlDark");
            txtSourceFolder.Text = "Select source folder...";

            fbdDestinationFolder.SelectedPath = @"C:\Film";
            txtDestinationFolder.Text = fbdDestinationFolder.SelectedPath;

            string basepath = Path.GetDirectoryName(Application.ExecutablePath);
            constring += basepath + "\\moviesfull.db"; //connection string za SQLite bazu

            dgvGenres.Columns[0].Visible = false;
            dgvGenres.Columns[1].Visible = false;

            try
            {
                prepareDrives();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        /// <summary>
        /// Selekcija korena stabla pretrage - source folder se rekurzivno obilazi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowseSourceFolder_Click(object sender, EventArgs e)
        {
            DialogResult res = fbdSourceFolder.ShowDialog();
            if (res == DialogResult.OK)
            {
                txtSourceFolder.Text = fbdSourceFolder.SelectedPath;
                dgvDrives[0, dgvDrives.CurrentRow.Index].Value = fbdSourceFolder.SelectedPath;
                txtSourceFolder.ForeColor = Color.FromName("Control");
            }
        }

        /// <summary>
        /// Priprema za poziv bgwSearch i poziv bgwSearch.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            drivesList = new List<string>();
            foreach(DataGridViewRow r in dgvDrives.Rows)
            {
                DataGridViewTextBoxCell driveCell = (DataGridViewTextBoxCell)r.Cells[0];
                DataGridViewCheckBoxCell chkCell = (DataGridViewCheckBoxCell)r.Cells[1];
                if ((bool)chkCell.EditedFormattedValue)
                {
                    drivesList.Add(driveCell.Value.ToString());
                }

            }
            if (!bgwSearch.IsBusy && drivesList.Count>0)
            {
                prgSearch.Visible = true;
                lblSearching.Visible = true;
                btnBrowseSourceFolder.Enabled = false;
                btnSearch.Enabled = false;

                bgwSearch.RunWorkerAsync();
            }

        }

        /// <summary>
        /// Kreira string koji se koristi kao parametar za search - *.mp4|*.mkv|*.avi....
        /// </summary>
        /// <returns></returns>
        private string getFormats()
        {
            string formats = "*";

            if (txtCustomFormat.Text != string.Empty)
                formats += txtCustomFormat.Text + "|*";

            foreach (Control c in tlpFormats.Controls)
            {
                if((c as CheckBox).Checked)
                formats += (c.Text + "|*");
            }
            char[] rem = { '|', '*' };

            return formats.TrimEnd(rem);
        }

        /// <summary>
        /// Rekurzivno pretrazuje source folder za fajlove sa zadatim ekstenzijama.
        /// Preskace foldere sa zabranom pristupa.
        /// Popunjava listu filmova rezultatima: filename.extension, filepath.
        /// </summary>
        private void getMovies()
        {
            movies = new List<Tuple<string, string>>();

            string prefix = @"\\?\";
            foreach (string s in drivesList)
            {
                string root = prefix + s;

                foreach (IEntry entry in FileSearcher.Search(root, getFormats(),
                    SearchOptions.IgnoreInaccessibleNodes))
                {
                    string item1 = entry.FileName + entry.FileExtension;
                    string item2 = entry.DirectoryPath;
                    movies.Add(new Tuple<string, string>(item1, item2));
                }
            }
        }


        private void bgwSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            getMovies();
        }


        private void bgwSearch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        /// <summary>
        /// Postavlja datasource liste filmova i refreshuje komponentu za prikaz.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgwSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvMovies.DataSource = null;
            dgvMovies.DataSource = movies;
            dgvMovies.Columns[0].HeaderText = "Title";
            dgvMovies.Columns[1].HeaderText = "Path";

            lblMoviesFoundCount.Text = movies.Count.ToString();

            prgSearch.Visible = false;
            lblSearching.Visible = false;
            btnSearch.Enabled = true;
            btnBrowseSourceFolder.Enabled = true;
            dgvMovies.Columns[1].Visible = false;
        }

        /// <summary>
        /// Priprema za poziv bgwSort i poziv bgwSort
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSort_Click(object sender, EventArgs e)
        {
            genres = new List<Tuple<string, List<string>>>();
            if (movies != null &&!bgwSort.IsBusy)
            {
                prgSort.Visible = true;
                lblSorting.Visible = true;
                btnSort.Enabled = false;
                bgwSort.RunWorkerAsync();
            }
            
        }

        /// <summary>
        /// SQL kod za upit ka bazi: uzima u obzir i godinu ako postoji u imenu fajla.
        /// U protivnom izostavlja godinu i trazi samo po titlu.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns>SQL kod za upit ka bazi</returns>
        private string getQuery(string filename)
        {
            string query = @"SELECT genres, primarytitle FROM MoviesSearch WHERE ";

            string year = extractYear(filename);
            if (year != string.Empty)
                query += @"startyear=" + year + " AND ";

            query += @"MoviesSearch MATCH '";
            query += extractTitle(filename) +@"' ORDER BY bm25(MoviesSearch) LIMIT 1";

            return query;
        }

        /// <summary>
        /// Vraca godinu iz ulaznog stringa. Vraca string.Empty ukoliko godina ne postoji.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static string extractYear(string filename)
        {
            Regex regex = new Regex(@"[0-9]{4}");

            var v = regex.Match(filename);

            string year = v.Groups[0].ToString();

            if (year != string.Empty)
                return year;
            else
                return string.Empty;

        }

        /// <summary>
        /// Izvlaci titl iz imena fajla
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        /// 
        //za svaku rec iz liste proveri da li je godina - izvlaci sve reci pre godine i godinu
        //zavisi od konvencije imenovanja - preduslov je da titl prethodi godini
        //eliminise reci koje imaju apostrof - puca upit ka bazi ukoliko se ukljuce

        public static string extractTitle(string filename)
        {
            //Title.Of.The.Movie.Year.Source.Codec-Group.Extension
            string title = "";
            char[] delimiters = { '.', '_','-' ,' ', '(', ')', '[', ']'};

            filename = Path.GetFileNameWithoutExtension(filename);
            
            //lista reci u imenu fajla
            var v = filename.Split(delimiters);

            int limit = v.Length;          


            for (int i = 0; i < limit; i++)
            {
                if(v[i]!= string.Empty)
                {
                    if (!v[i].Contains("\'"))
                        title += v[i] + @" ";
                    if (extractYear(v[i]) != string.Empty)
                        break;
                }              
            }

            return title.TrimEnd(' ');
        }

        /// <summary>
        /// Full text pretraga baze za svaki od filmova iz liste movies.
        /// Populise genres listu podacima: titl iz baze, lista zanrova
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgwSort_DoWork(object sender, DoWorkEventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(constring))
            {
                connection.Open();
                connection.EnableExtensions(true);
                connection.LoadExtension("SQLite.Interop.dll", "sqlite3_fts5_init");
                int progress = 0;
                foreach(Tuple<string, string> tuple in movies)
                {
                    string title = extractTitle(tuple.Item1);
                    if (title != string.Empty)
                    {
                        string query = getQuery(tuple.Item1);
                        using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, connection))
                        {
                            SQLiteDataReader reader = sqliteCommand.ExecuteReader();
                            List<string> genresList = new List<string>();
                            string[] results;
                            if (reader.Read())
                            {
                                results = reader.GetString(0).Split(',');
                                title = reader.GetString(1);
                                foreach (string g in results)
                                    genresList.Add(g);
                            }
                            else genresList.Add(string.Empty);
                            genres.Add(new Tuple<string, List<string>>(title, genresList));
                        }
                    }
                    progress += 100 / movies.Count;
                    bgwSort.ReportProgress(progress);
                }
                connection.Close();
            }
        }

        private void bgwSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prgSort.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// Refreshuje komponentu za prikaz titlova i zanrova - dgvGenres.
        /// U obzir dolaze samo zanrovi koje je korisnik definisao.
        /// Kad baza vrati zanrove, iz liste zanrova izbacuju se svi koje korisnik nije definisao.
        /// Zatim:
        /// Ukoliko baza vrati jedan zanr - red se boji zeleno i samo taj zanr je u combo boxu.
        /// Ukoliko baza vrati vise zanrova - red se boji zuto i u listi su ponudjeni zanrovi - Korisnik ima konacnu rec.
        /// Ukoliko nema ponudjenih zanrova - red se boji crveno i korisnik ima izbor da odabere zanr iz svojih definisanih zanrova.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgwSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvGenres.DataSource = null;
            dgvGenres.Rows.Clear();

            dgvGenres.Columns[0].Visible = true;
            dgvGenres.Columns[1].Visible = true;

            List<string> allgenres = new List<string>();

            foreach (Tuple<string, string> t in genrePaths)
            {
                allgenres.Add(t.Item1);
            }

            for (int i = 0; i < genres.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell());
                row.Cells.Add(new DataGridViewComboBoxCell());
                dgvGenres.Rows.Add(row);

                for(int j =0;j< genres[i].Item2.Count;j++)
                {
                    bool remove = true;
                    foreach(string g in allgenres)
                    {
                        if (g == genres[i].Item2[j])
                            remove = false;
                    }
                    if (remove)
                        genres[i].Item2.Remove(genres[i].Item2[j]);
                }

                (dgvGenres.Rows[i].Cells[0] as DataGridViewTextBoxCell).Value = genres[i].Item1;
                (dgvGenres.Rows[i].Cells[1] as DataGridViewComboBoxCell).DataSource = genres[i].Item2;
                

                if (genres[i].Item2.Count>1)
                    dgvGenres.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255,255,128);
                else if(genres[i].Item2.Count == 0 || genres[i].Item2[0]==string.Empty)
                {
                    dgvGenres.Rows[i].DefaultCellStyle.BackColor = Color.Coral;
                    
                    (dgvGenres.Rows[i].Cells[1] as DataGridViewComboBoxCell).DataSource = allgenres;
                    
                }
                else dgvGenres.Rows[i].DefaultCellStyle.BackColor = Color.MediumSpringGreen;

                (dgvGenres.Rows[i].Cells[1] as DataGridViewComboBoxCell).Value =
                     (dgvGenres.Rows[i].Cells[1] as DataGridViewComboBoxCell).Items[0];

                dgvGenres.Rows[i].Height = 33;
            }

            dgvGenres.ClearSelection();
            lblSorting.Visible = false;
            prgSort.Visible = false;
            btnSort.Enabled = true;
        }

        /// <summary>
        /// Pomocna funkcija za brzo generisanje filepaths.dat fajla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            string path = fbdDestinationFolder.SelectedPath;
            if (fbdDestinationFolder.ShowDialog() == DialogResult.OK)
                path = fbdDestinationFolder.SelectedPath;

            genrePaths = new List<Tuple<string, string>>();

            //path = Path.GetDirectoryName(path);
            
            genrePaths.Add(new Tuple<string, string>("Action", 
                path + "\\Action"));
            genrePaths.Add(new Tuple<string, string>("Adult",
                path + "\\Adult"));
            genrePaths.Add(new Tuple<string, string>("Adventure",
                path + "\\Adventure"));
            genrePaths.Add(new Tuple<string, string>("Animation",
                path + "\\Animation"));

            genrePaths.Add(new Tuple<string, string>("Biography",
                path + "\\Biography"));
            
            genrePaths.Add(new Tuple<string, string>("Comedy",
                path + "\\Comedy"));
            genrePaths.Add(new Tuple<string, string>("Crime",
                path + "\\Crime"));

            genrePaths.Add(new Tuple<string, string>("Documentary",
                path + "\\Documentary"));
            genrePaths.Add(new Tuple<string, string>("Drama",
                path + "\\Drama"));

            genrePaths.Add(new Tuple<string, string>("Family",
                path + "\\Family"));
            genrePaths.Add(new Tuple<string, string>("Fantasy",
                path + "\\Fantasy"));
            genrePaths.Add(new Tuple<string, string>("Film Noir",
                path + "\\FilmNoir"));

            genrePaths.Add(new Tuple<string, string>("Game-Show",
                path + "\\Gameshow"));

            genrePaths.Add(new Tuple<string, string>("History",
                path + "\\History"));
            genrePaths.Add(new Tuple<string, string>("Horror",
                path + "\\Horror"));

            genrePaths.Add(new Tuple<string, string>("Musical",
                path + "\\Musical"));
            genrePaths.Add(new Tuple<string, string>("Music",
                path + "\\Music"));
            genrePaths.Add(new Tuple<string, string>("Mistery",
                path + "\\Mistery"));

            genrePaths.Add(new Tuple<string, string>("News",
                path + "\\News"));

            genrePaths.Add(new Tuple<string, string>("Reality-TV",
                path + "\\RealityTV"));
            genrePaths.Add(new Tuple<string, string>("Romance",
                path + "\\Romance"));

            genrePaths.Add(new Tuple<string, string>("Sci-Fi",
                path + "\\SciFi"));
            genrePaths.Add(new Tuple<string, string>("Short",
                path + "\\Sport"));

            genrePaths.Add(new Tuple<string, string>("Talk-Show",
                path + "\\TalkShow"));
            genrePaths.Add(new Tuple<string, string>("Thriller",
                path + "\\Thriller"));

            genrePaths.Add(new Tuple<string, string>("War",
                path + "\\War"));
            genrePaths.Add(new Tuple<string, string>("Western",
                path + "\\Western"));


            foreach(Tuple<string,string> t in genrePaths)
                Directory.CreateDirectory(t.Item2);
            

            FileStream stream = new FileStream(@"genrepaths.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, genrePaths);
            stream.Close();

            txtDestinationFolder.Text = fbdDestinationFolder.SelectedPath;
        }

        /// <summary>
        /// Otvara formu za editovanje liste korisnickih zanrova i odredisnih putanja za svaki od njih
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditGenres_Click(object sender, EventArgs e)
        {
            Form dialog = new Form2();
            if (dialog.ShowDialog() == DialogResult.OK)
                LoadGenres();
        }

        /// <summary>
        /// Priprema za poziv bgwCopy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (genres.Count>0 && !bgwCopy.IsBusy)
            {
                prgCopy.Visible = true;
                lblCopying.Visible = true;
                bgwCopy.RunWorkerAsync();
            }
        }

        /// <summary>
        /// Priprema za bgwCopy, nalazi source i destination putanju za fajl i kopira
        /// U zavisnosti od chkDelete premesta ili kopira
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgwCopy_DoWork(object sender, DoWorkEventArgs e)
        {
            char[] rem = { '\\', '?' }; //uklanja //?/ prefiks iz adrese
            string subtitles = "*.srt|*.sub";
            for(int i = 0; i<genres.Count; i++)
            {
                string sourceFile = Path.Combine(movies[i].Item2, movies[i].Item1);
                string destinationPath = string.Empty;

                string value = dgvGenres["ColumnGenres", i].Value.ToString();

                //trazi odredisnu lokaciju za zadati zanr
                foreach(Tuple<string,string> t in genrePaths)
                {
                    if(value == t.Item1)
                    {
                        destinationPath = t.Item2;
                        break;
                    }
                }

                if(destinationPath!= string.Empty)
                {
                    destinationPath += "\\" + genres[i].Item1;
                    Directory.CreateDirectory(destinationPath);
                    string destinationFile = Path.Combine(destinationPath, movies[i].Item1);
                    sourceFile = sourceFile.TrimStart(rem);
                    //File.Copy(sourceFile, destinationFile, true);
                    //lblCopying.Text = "Copying file " 
                    //    + (i + 1).ToString() + @"/" + genres.Count.ToString();
                    FCopy(sourceFile, destinationFile,chkDeleteSource.Checked);

                    foreach (IEntry entry in FileSearcher.Search(movies[i].Item2, subtitles,
                    SearchOptions.IgnoreInaccessibleNodes,0)) //NEREKURZIVNO!!!!!
                    {
                        string src = movies[i].Item2 + "\\" + entry.File;
                        src = src.TrimStart(rem);
                        string dest = destinationPath +"\\" + entry.File;
                        FCopy(src, dest, chkDeleteTitle.Checked);
                    }
                }
            }
        }

        private void bgwCopy_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prgCopy.Value = e.ProgressPercentage;
        }


        private void bgwCopy_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            prgCopy.Visible = false;
            lblCopying.Visible = false;
            MessageBox.Show("Copied successfully.", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Kopira koriscenjem buffera od 1M - brze nego File.Copy()
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="delete"></param>
        private void FCopy(string source, string destination, bool delete)
        {
            int array_length = (int)Math.Pow(2, 19);
            byte[] dataArray = new byte[array_length];

            using (FileStream fsread = new FileStream
            (source, FileMode.Open, FileAccess.Read, FileShare.None, array_length))
            {
                using (BinaryReader bwread = new BinaryReader(fsread))
                {
                    using (FileStream fswrite = new FileStream
                    (destination, FileMode.Create, FileAccess.Write, FileShare.None, array_length))
                    {
                        using (BinaryWriter bwwrite = new BinaryWriter(fswrite))
                        {
                            for (; ; )
                            {
                                int read = bwread.Read(dataArray, 0, array_length);
                                if (0 == read)
                                    break;
                                bwwrite.Write(dataArray, 0, read);
                            }
                        }
                    }
                }
            }
            if (delete)
                File.Delete(source);
        }


        /// <summary>
        /// Ucitava korisnicku listu zanrova i lokacija u genrePaths
        /// </summary>
        private void LoadGenres()
        {
            genrePaths = new List<Tuple<string, string>>();

            if (File.Exists(@"genrepaths.dat"))
            {
                using (FileStream inStr = new FileStream(@"genrepaths.dat", FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    genrePaths = bf.Deserialize(inStr) as List<Tuple<string, string>>;
                }
            }
        }

        /// <summary>
        /// Otvara formu za unos novog filma u bazu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            Form addMovieForm = new Form3();
            addMovieForm.ShowDialog();
        }

        private void txtSourceFolder_Enter(object sender, EventArgs e)
        {
            if(txtSourceFolder.ForeColor == Color.FromName("ControlDark"))
            {
                txtSourceFolder.Text = string.Empty;
                txtSourceFolder.ForeColor = Color.FromName("Control");
            }
        }

        private void dgvGenres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == 0 &&
                e.RowIndex >= 0)
            {
                string query = @"https://www.imdb.com/find?ref_=nv_sr_fn&q=";
                string title = dgvGenres[e.ColumnIndex, e.RowIndex].Value.ToString();
                query += title + @"&s=all";

                System.Diagnostics.Process.Start(query);
            }
        }

        /// <summary>
        /// Skenira racunar za sve postojece logicke drajvove i izlistava ih
        /// </summary>
        private void prepareDrives()
        {
            dgvDrives.DataSource = null;
            //DataGridViewRowCollection rows = dgvDrives.Rows;
            //foreach (DataGridViewRow r in rows)
            //    dgvDrives.Rows.Remove(r);
            for (int i = dgvDrives.RowCount - 1; i >= 0; i--)
            {
                dgvDrives.Rows.RemoveAt(i);
            }
            if (dgvDrives.ColumnCount == 0)
            {
                dgvDrives.Columns.Add(new DataGridViewTextBoxColumn());
                dgvDrives.Columns.Add(new DataGridViewCheckBoxColumn());
            }         

            dgvDrives.Columns[0].HeaderText = "Available drives";
            dgvDrives.Columns[0].ReadOnly = true;

            dgvDrives.Columns[1].HeaderText = "Include in search";
            //drivesList = new List<string>();
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo d in drives)
            {
                if (d.IsReady)
                {
                    //drivesList.Add(d.RootDirectory.FullName);
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewCheckBoxCell chkCell = new DataGridViewCheckBoxCell();
                    DataGridViewTextBoxCell txtCell = new DataGridViewTextBoxCell();

                    txtCell.Value = d.RootDirectory.FullName;

                    row.Cells.Add(txtCell);
                    row.Cells.Add(chkCell);

                    dgvDrives.Rows.Add(row);
                }
            }
            
        }

        private void dgvDrives_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if(e.RowIndex>=0)
                txtSourceFolder.Text = senderGrid[0, e.RowIndex].Value.ToString();

        }

        private void btnTitles_Click(object sender, EventArgs e)
        {
            SubtitleFinderForm form = new SubtitleFinderForm();
            form.Show();
        }
    }
}
