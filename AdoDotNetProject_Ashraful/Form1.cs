using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoDotNetProject_Ashraful
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            AuthorInformation ai = new AuthorInformation();
            this.Hide();
            ai.ShowDialog();
        }

        private void btnBookInformation_Click(object sender, EventArgs e)
        {
            BookInformation bi = new BookInformation();
            this.Hide();
            bi.ShowDialog();
        }
    }
}
