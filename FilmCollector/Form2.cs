using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmCollector
{
    public partial class Form2 : Form
    {
        List<Tuple<string, string>> genresData; //lista zanrova i lokacija
        bool upToDate = true; //flag koji govori da li su podaci azurni, promene je potrebno sacuvati u fajl
        public Form2()
        {
            InitializeComponent();
            InitializeDGV();
        }

        /// <summary>
        /// Handler za klik na dugme u okviru dgv, za druge kolone nema efekta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGenrePaths_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (fbdGenrePath.ShowDialog() == DialogResult.OK)
                {
                    genresData[e.RowIndex] = new Tuple<string, string>
                        (genresData[e.RowIndex].Item1, fbdGenrePath.SelectedPath);

                    refreshDGV();
                    upToDate = false;
                }
            }
        }

        /// <summary>
        /// Ucitava listu zanrova i lokacija iz fajla i osvezava komponentu za prikaz
        /// </summary>
        private void InitializeDGV()
        {
            genresData = new List<Tuple<string, string>>();

            if (File.Exists(@"genrepaths.dat"))
            {
                using (FileStream inStr = new FileStream(@"genrepaths.dat", FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    genresData = bf.Deserialize(inStr) as List<Tuple<string, string>>;
                }
            }

            refreshDGV();

        }

        /// <summary>
        /// Osvezava komponentu za prikaz podacima iz genresData liste zanrova i lokacija
        /// </summary>
        private void refreshDGV()
        {
            dgvGenrePaths.DataSource = null;
            dgvGenrePaths.DataSource = genresData;

            dgvGenrePaths.Columns["Item1"].DisplayIndex = 0;
            dgvGenrePaths.Columns["Item1"].HeaderText = "Genre";
            dgvGenrePaths.Columns["Item2"].DisplayIndex = 1;
            dgvGenrePaths.Columns["Item2"].HeaderText = "Path";
            dgvGenrePaths.Columns["ColumnBrowse"].DisplayIndex = 2;

            dgvGenrePaths.Height = (genresData.Count + 2) * dgvGenrePaths.Rows[0].Height;
        }

        /// <summary>
        /// Dodaje novi zanr u listu ukoliko on vec nije u listi i osvezava listu ako je dodat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            bool allow = true;
            string text = txtRow.Text;
            if (text != string.Empty)
            {
                foreach (Tuple<string, string> tuple in genresData)
                {
                    if (text == tuple.Item1)
                    {
                        allow = false;
                        MessageBox.Show("Genre already exists.", "Error.",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                }

                if (allow && fbdGenrePath.ShowDialog() == DialogResult.OK)
                {
                    genresData.Add(new Tuple<string, string>(text, fbdGenrePath.SelectedPath));
                    refreshDGV();
                    upToDate = false;
                }
            }
            else MessageBox.Show("Please enter the genre you wish to add.", "Genre field empty.",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Brise selektovani zanr iz liste i osvezava prikaz.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGenrePaths.SelectedCells.Count == 1)
            {
                genresData.RemoveAt(dgvGenrePaths.SelectedCells[0].RowIndex);
                refreshDGV();
                upToDate = false;
            }
            else MessageBox.Show("Please select the genre you wish to delete.", "Genre not selected.",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Zatvara formu i pita korisnika da li zeli da sacuva promene ukoliko postoje.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(!upToDate)
            {
                if (MessageBox.Show("Save changes?", "You have unsaved changes.",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    btnSave.PerformClick();

            }
            Close();
        }

        /// <summary>
        /// Cuva promene koje je korisnik nacinio. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (FileStream stream = new FileStream(@"genrepaths.dat", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, genresData);
                stream.Close();
            }
            DialogResult = DialogResult.OK;
            upToDate = true;
        }
    }
}
