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
    public partial class home_menu : UserControl
    {


        private MySqlCommand cmd;
        private DataSet ds;
        private MySqlDataAdapter da;
        Class.koneksi konn = new Class.koneksi();

        public void refresh_book()
        {
            MySqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("select * from ebooks", conn);
                    ds = new DataSet();
                    da = new MySqlDataAdapter(cmd);
                    da.Fill(ds, "ebooks");
                    dataGridRecent.DataSource = ds;
                    dataGridRecent.DataMember = "ebooks";
                    dataGridRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;  
                    dataGridRecent.AllowUserToAddRows = false;
                    dataGridRecent.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public home_menu()
        {
            InitializeComponent();
            refresh_book();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            add_book addbook = new add_book();
            addbook.Show();
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh_book();
        }

        private void dataGridRecent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch 
            {
            
            }
        }

        private void dataGridRecent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridRecent.Columns[e.ColumnIndex].Name=="Delete")
            {
                if (MessageBox.Show("Yakin ingin Hapus Buku ini?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string id = dataGridRecent.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    DeleteData(id);
                }
            }

            if (dataGridRecent.Columns[e.ColumnIndex].Name == "edit")
            {
                string id = dataGridRecent.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                detail.IdParam = id;
                detail.IdParam2 = id;
                detail menuDetail = new detail();
                menuDetail.Show();
                this.Hide();
            }
        }

        private void DeleteData(string id)
        {
           try
            {
            MySqlConnection conn = konn.Getconn();
            string mysql = "Delete from ebooks where id = @id";
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(mysql, conn))
                    {
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("hapus data berhasil");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
