using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Performance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clicked(object sender, EventArgs e)
        {
            string name = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            string errorMsg = "";
            bool error = false;
            if (name.Equals(""))
            {
                MessageBox.Show("User Name Required\n");
            }
            else if(!name.Equals("18-37370-1"))
            {
                MessageBox.Show("Invalid Name\n");
                error = true;
            }
            else 
            {
                
            }
        }
    }
}
