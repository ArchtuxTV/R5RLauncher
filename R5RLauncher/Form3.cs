using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R5RLauncher
{
    public partial class Form3 : Form
    {
        WebClient client = new WebClient();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string getnotes = client.DownloadString("http://r5r.createxhosting.com/r5reloadedpatchnotes.txt");
            richTextBox1.Text = getnotes.Replace("thisisacoolnewlineok", Environment.NewLine);
        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }
    }
}
