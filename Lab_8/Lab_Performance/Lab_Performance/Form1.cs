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
            string name = "";
            string password = "";
            string errorMsg = "";
            bool error = false;
            if (textBoxUserName.Text.Equals(""))
            {
                errorMsg = "Name Required";
                error = true;
            }
            else
            {
                name = textBoxUserName.Text;
            }
            if (textBoxPassword.Text.Equals(""))
            {
                errorMsg += "\nPassword Required";
                error = true;
            }
            else
            {
                password = textBoxPassword.Text;
            }
           
            if (!error)
            {
                if (name.Equals("18-37370-1") && password.Equals("Sadman")) //Name = 18-37370-1 password  =Sadman
                {
                    new Dashboard().Show();
                } 
                else
                {
                    MessageBox.Show("Invalid Name or Password");
                }
            }
            else
            {
                MessageBox.Show(errorMsg);
            }
        }
        
    }
}
