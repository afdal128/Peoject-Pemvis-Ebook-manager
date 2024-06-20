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
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            home_menu2.Visible = true;

        }

        private void butonfav_Click(object sender, EventArgs e)
        {
            home_menu2.Visible = false ;
            favorit_Menu1.Visible = true;
        }

        private void home_menu2_Load(object sender, EventArgs e)
        {

        }
    }
}
