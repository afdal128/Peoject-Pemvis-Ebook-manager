using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace E_Book_Manager.GUI
{
    public partial class add_book : Form
    {
        private home_menu Menu;
        private MySqlCommand cmd;
        private DataSet ds;
        private MySqlDataAdapter da;
        Class.koneksi konn = new Class.koneksi();

        void clear()
        {
            txtJudul.Text = "";
            txtPenulis.Text = "";
            txtGenre.Text = "";
            txtYear.Text = "";
            txtSinopsis.Text = "";
        }
        public add_book()
        {
            InitializeComponent();
            clear();
            Menu = new home_menu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtJudul.Text.Trim() == "" || txtPenulis.Text.Trim() == "" ||
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
                    cmd = new MySqlCommand("insert into ebooks (Title, Genre, Author, Year, Sinopsis)  " +
                        "values('" + txtJudul.Text + "','" + txtGenre.Text + "','" + txtPenulis.Text + "','" + txtYear.Text + "','" + txtSinopsis.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("data berhasil disimpan");
                    clear();
                    Menu.refresh_book();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }
    }
    
}
