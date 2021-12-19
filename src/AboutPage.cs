using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourTable
{
    public partial class YourTable : Form
    {
        //Desc: The info page of the program. contains simple data about the program, and external links.
        public YourTable()
        {
            InitializeComponent();
        }

        private void AboutPage_Load(object sender, EventArgs e)
        {

        }

        private void AboutPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Options op = new Options();
            op.CloseProgram();
        }

        private void btn_goBack_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            Hide();
        }

        private void img_gitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TheDokT0r/YourTable");
        }
    }
}
