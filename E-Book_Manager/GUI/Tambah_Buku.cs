using E_Book_Manager.Class;
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
    public partial class Tambah_Buku : UserControl
    {
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

        void refresh()
        {
            MySqlConnection conn = konn.Getconn();
            {
                try 
                {  
                    conn.Open();
                    cmd = new MySqlCommand("select * from ebooks", conn);
                    ds = new DataSet(); 
                    da = new MySqlDataAdapter(cmd);
                    da.Fill(ds,"ebooks");
                } 
                catch(Exception e) 
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        public Tambah_Buku()
        {
            InitializeComponent();
            clear();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtJudul.Text.Trim()=="" || txtPenulis.Text.Trim() == "" || 
                txtGenre.Text.Trim() == "" || txtYear.Text.Trim() == "" ||
                txtSinopsis.Text.Trim() == "")
            {
                MessageBox.Show("data belum lengkap","peringatan", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                MySqlConnection conn = konn.Getconn();
                try
                {
                    cmd = new MySqlCommand("insert into ebooks values('"+txtJudul.Text+"','"
                        +txtGenre.Text+"','"+txtPenulis+"','"+txtYear+"','"
                        +txtSinopsis+"')",conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("data berhasil disimpan");
                    clear();
                }
                catch(Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void btnsv_Click(object sender, EventArgs e)
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
                    cmd = new MySqlCommand("insert into ebooks values('" + txtJudul.Text + "','"
                        + txtGenre.Text + "','" + txtPenulis + "','" + txtYear + "','"
                        + txtSinopsis + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("data berhasil disimpan");
                    clear();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }
    }
}
