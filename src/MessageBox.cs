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
    public partial class MessageBox : Form
    {
        public MessageBox(string title, string message)
        {
            InitializeComponent();

            lbl_error.Text = message;
            this.Text = title;
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Options op = new Options();
            op.CloseProgram();
        }
    }
}
