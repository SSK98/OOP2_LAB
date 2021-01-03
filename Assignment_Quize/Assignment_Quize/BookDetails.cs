using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Quize
{
    public partial class BookDetails : Form
    {
        public BookDetails()
        {
            InitializeComponent();
        }
        public BookDetails(string id, string name, string author,string edition)
        {
            InitializeComponent();
            textBoxId.Text = id;
            textBoxName.Text = name;
            textBoxAuthor.Text = author;
            textBoxEdition.Text = edition;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
