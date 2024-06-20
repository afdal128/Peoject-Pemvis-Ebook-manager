using E_Book_Manager.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Book_Manager.GUI
{
    public partial class detail : Form
    {

        #region GlobalVar
        public static string IdParam { get; set; }
        #endregion
        #region GlobalVar
        public static string IdParam2 { get; set; }
        #endregion

        Class.koneksi konn = new Class.koneksi();
        private MySqlCommand cmdo;

        public detail()
        {
            InitializeComponent();
            ShowDetail(IdParam);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void ShowDetail(string id) 
        {
            try
            {
                DataTable dt = new DataTable(); 
                string mysql = "select * from ebooks where id = @id";
                MySqlConnection conn = konn.Getconn();
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(mysql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
                if (dt.Rows.Count > 0)
                {
                    string title = dt.Rows[0]["Title"].ToString();
                    string author = dt.Rows[0]["Author"].ToString();
                    string year = dt.Rows[0]["Year"].ToString();
                    string genre = dt.Rows[0]["Genre"].ToString();
                    string sinopsis = dt.Rows[0]["Sinopsis"].ToString();

                    txtJudul.Text = title;
                    txtAuthor.Text = author;
                    txtGenre.Text = genre;
                    txtYear.Text = year;
                    txtSinopsis.Text = sinopsis;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void update(string id) 
        {

            if (txtJudul.Text.Trim() == "" || txtAuthor.Text.Trim() == "" ||
            txtGenre.Text.Trim() == "" || txtYear.Text.Trim() == "" ||
            txtSinopsis.Text.Trim() == "")
            {
                MessageBox.Show("data belum lengkap", "peringatan", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {

                MySqlConnection conn = konn.Getconn();
                try
                {
                    string query = "UPDATE ebooks SET Title = @Title, Author = @Author, Genre = @Genre, Year = @Year, Sinopsis = Sinopsis WHERE Id = @Id";
                    cmdo = new MySqlCommand(query, conn);
                    //("update  ebooks set Title = '" + txtJudul.Text + "', Genre = '" + txtGenre.Text + "', " +
                    //"Author '" + txtAuthor.Text + "', Year = '" + txtYear.Text + "', Sinopsis = '" + txtSinopsis.Text + "' where id = @id ", conn);
                    conn.Open();
                   {
                        cmdo.Parameters.AddWithValue("@Title", txtJudul.Text);
                        cmdo.Parameters.AddWithValue("@Author", txtAuthor.Text);
                        cmdo.Parameters.AddWithValue("@Genre", txtGenre.Text);
                        cmdo.Parameters.AddWithValue("@Year", txtYear.Text);
                        cmdo.Parameters.AddWithValue("@Sinopsis", txtSinopsis.Text);
                        cmdo.Parameters.AddWithValue("@id", id);
                        cmdo.ExecuteNonQuery();
                        MessageBox.Show("data berhasil disimpan");
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {

            update(IdParam2);
        }
    }
}
