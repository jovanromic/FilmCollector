using Microsoft.WindowsAPICodePack.Shell;
using OpenSubtitlesDotNET;
using Recls;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WatiN;

namespace FilmCollector
{
    public partial class SubtitleFinderForm : Form
    {
        private List<SearchSubtitleResult> foundSubtitles = new List<SearchSubtitleResult>();
        private List<string> existingSubtitlesPaths = new List<string>();
        private List<string> existingSubtitlesFilenames = new List<string>();

        public SubtitleFinderForm()
        {
            InitializeComponent();
        }

        private void btnBrowseMovie_Click(object sender, EventArgs e)
        {
            if(ofdMovieLocation.ShowDialog() == DialogResult.OK)
            {
                txtMovieLocation.Text = ofdMovieLocation.FileName;

                findExistingSubtitles();

                lblFpsValue.Text = getMovieFPS(ofdMovieLocation.FileName);

            }
        }

        private void updateListBox()
        {
            lbxExisting.DataSource = null;
            
            foreach(string path in existingSubtitlesPaths)
            {
                existingSubtitlesFilenames.Add(Path.GetFileName(path));
            }

            lbxExisting.DataSource = existingSubtitlesFilenames;
        }

        private void findExistingSubtitles()
        {
            existingSubtitlesPaths.Clear();
            existingSubtitlesFilenames.Clear();
            string prefix = @"\\?\";
            string location = Path.GetDirectoryName(txtMovieLocation.Text);
            string root = prefix + location;

            foreach (IEntry entry in FileSearcher.Search(root, "*.srt",
                SearchOptions.IgnoreInaccessibleNodes))
            {
                string item1 = entry.FileName + entry.FileExtension;
                string item2 = entry.DirectoryPath;
                existingSubtitlesPaths.Add(item2 + item1);
            }

            updateListBox();
        }

        private string getMovieFPS(string filename)
        {
            ShellFile shellFile = ShellFile.FromFilePath(filename);
            return (shellFile.Properties.System.Video.FrameRate.Value / 1000).ToString();
        }

        private void resultsToListView()
        {
            lvwTitles.Items.Clear();
            
            foreach(SearchSubtitleResult subtitle in foundSubtitles)
            {
                //string[] items =
                //{
                //    subtitle.SubFileName,
                //    subtitle.LanguageName,
                //    subtitle.MovieFPS
                //};
                ListViewItem lvi = new ListViewItem(subtitle.SubFileName);
                lvi.SubItems.Add(subtitle.LanguageName);
                lvi.SubItems.Add(subtitle.MovieFPS);

                lvwTitles.Items.Add(lvi);
            }
        }

        private void findSubtitles(string file)
        {
            try
            {
                OSDotNetSession session = OSDotNetSession.LogIn("", "", "fr", "iPhoneVideoHelper");
                FileInfo fileInfo = new FileInfo(file);
                List<string> codes = new List<string>();
                if (rdbBalkan.Checked)
                {
                    codes.Add("scc");
                    codes.Add("hrv");
                    codes.Add("bos");
                }
                else
                {
                    codes.Add("eng");
                }
                foreach(string code in codes)
                {
                    List<SearchSubtitleResult> List = session.SearchByFile(fileInfo,
                    OSLanguageHelper.GetOSLanguageById(code));

                    foreach(SearchSubtitleResult res in List)
                    {
                        foundSubtitles.Add(res);
                    }
                }

                string imdbId = foundSubtitles[0].IDMovieImdb;
                foundSubtitles.Clear();

                if (rdbBalkan.Checked)
                {
                    codes.Add("scc");
                    codes.Add("hrv");
                    codes.Add("bos");
                }
                else
                {
                    codes.Add("eng");
                }
                foreach (string code in codes)
                {
                    List<SearchSubtitleResult> List = session.SearchByImdbId(imdbId,
                    OSLanguageHelper.GetOSLanguageById(code));

                    foreach (SearchSubtitleResult res in List)
                    {
                        foundSubtitles.Add(res);
                    }
                }
                session.LogOut();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnPlayMovie_Click(object sender, EventArgs e)
        {
            if (lbxExisting.SelectedIndices.Count != 0)
            {
                int index = lbxExisting.SelectedIndex;
                string oldName = existingSubtitlesPaths[index];

                string newName = @"\\?\" + Path.GetDirectoryName(txtMovieLocation.Text);
                newName += "\\" + Path.GetFileNameWithoutExtension(txtMovieLocation.Text);
                newName += ".srt";

                if (oldName != newName)
                {
                    if(File.Exists(newName))
                        File.Delete(newName);
                    File.Move(oldName, newName);
                }

                System.Diagnostics.Process.Start(txtMovieLocation.Text);

                findExistingSubtitles();
            }
        }

        private void startResync(string location)
        {
            System.Diagnostics.ProcessStartInfo info =
                    new System.Diagnostics.ProcessStartInfo(location);

            int index = lbxExisting.SelectedIndices[0];
            string arg = existingSubtitlesPaths[index];
            char[] trim = { '\\', '?' };
            arg = arg.TrimStart(trim);
            string prefix = "\"";
            arg = prefix + arg + prefix;
            info.Arguments = arg;
            System.Diagnostics.Process.Start(info);
        }

        private void btnResync_Click(object sender, EventArgs e)
        {
            string query;
            if(chkDefaultSynchronizerLocation.Checked)
            {
                string location = Path.GetDirectoryName(Application.ExecutablePath);
                location += "\\" + "EasySubSync\\EasySubtitlesSynchronizer.exe";
                query = location;
                try
                {
                    startResync(query);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Easy Subtitle Synchronizer not found at default location." +
                        " Choose the path manually.", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    chkDefaultSynchronizerLocation.Checked = false;
                }
            }
            else
            {
                if (ofdMovieLocation.ShowDialog() == DialogResult.OK)
                {
                    query = ofdMovieLocation.FileName;

                    startResync(query);
                }
            }
            
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string query = "https://translatesubtitles.com/";
            System.Diagnostics.Process.Start(query);
            
        }

        private void btnTitlovi_Click(object sender, EventArgs e)
        {
            string title = MainForm.extractTitle(txtMovieLocation.Text);
            title = title.Replace(" " + MainForm.extractYear(txtMovieLocation.Text), "");
            string query = "https://rs.titlovi.com/prevodi/?prevod=" +
                title +
                "&sort=6";
            System.Diagnostics.Process.Start(query);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foundSubtitles = null;
            foundSubtitles = new List<SearchSubtitleResult>();

            findSubtitles(txtMovieLocation.Text);

            resultsToListView();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            int index = lvwTitles.SelectedIndices[0];

            string location = Path.GetDirectoryName(txtMovieLocation.Text);

            SearchSubtitleResult item = foundSubtitles[index];
            string subtitle = location + "\\" + item.SubFileName;

            OSDotNetSession session = OSDotNetSession.LogIn("", "", "fr", "iPhoneVideoHelper");

            using (MemoryStream st = session.DownloadSubtitle(item))
            {
                using (FileStream fs = new FileStream(subtitle, FileMode.OpenOrCreate))
                {
                    st.WriteTo(fs);

                    st.Flush();
                    st.Close();
                    session.LogOut();
                }
            }      

            findExistingSubtitles();
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            string filename = existingSubtitlesPaths[lbxExisting.SelectedIndices[0]];
            string content = Encoding.Default.GetString(File.ReadAllBytes(filename));

            content = content.Replace('è', 'c');
            content = content.Replace('æ', 'c');
            content = content.Replace('È', 'C');
            content = content.Replace('Æ', 'C');

            File.WriteAllBytes(filename, Encoding.Default.GetBytes(content));

            MessageBox.Show("Title successfully trimmed.", "Success!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SubtitleFinderForm_Activated(object sender, EventArgs e)
        {
            if(txtMovieLocation.Text!=string.Empty)
            findExistingSubtitles();
        }
    }
}
