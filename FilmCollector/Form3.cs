using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmCollector
{
    public partial class Form3 : Form
    {
        string constring = "data source=";

        public Form3()
        {
            InitializeComponent();
            string basepath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            constring += basepath + "\\moviesfull.db"; //connection string za bazu podataka
        }

        /// <summary>
        /// Otvara konekciju ka bazi i vrsi unos filma u bazu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPrimaryTitle.Text != string.Empty && txtOriginalTitle.Text != string.Empty
                && txtGenres.Text != string.Empty)
            {
                using (SQLiteConnection connection = new SQLiteConnection(constring))
                {
                    connection.Open();
                    connection.EnableExtensions(true);
                    connection.LoadExtension("SQLite.Interop.dll", "sqlite3_fts5_init");

                    string query = getQuery();

                    using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, connection))
                    {
                        if(sqliteCommand.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Movie succesfully added to database.", "Information.",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Error adding movie.", "Error.",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    connection.Close();
                }
            }
            else MessageBox.Show("Please fill all fields.", "Some fields are empty.",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Kreira upit za unos u bazu na osnovu polja iz forme.
        /// </summary>
        /// <returns></returns>
        private string getQuery()
        {
            string query = "INSERT INTO MoviesSearch (primarytitle, originaltitle, startyear, genres) VALUES (";
            query += "\"" +  txtPrimaryTitle.Text + "\", ";
            query += "\"" + txtOriginalTitle.Text + "\", ";
            query += nudStartyear.Value.ToString() + ", ";
            query += "\"" + txtGenres.Text + "\")";

            return query;
        }

        /// <summary>
        /// Zatvara formu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
