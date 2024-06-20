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
    public partial class Favorit_Menu : UserControl
    {
        public Favorit_Menu()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            add_book addbook = new add_book();
            addbook.Show();
        }
    }
}
