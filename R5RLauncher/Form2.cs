using R5RLauncher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R5RLauncher
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            guna2TextBox1.Text = Settings.Default.GamePath;
            guna2HtmlLabel6.Text = Settings.Default.GameVersion;

            if (Directory.Exists(Settings.Default.GamePath + "/platform/scripts/"))
            {
                guna2HtmlLabel4.Text = "OK!";
            }
            else
            {
                guna2HtmlLabel4.Text = "NOT OK!";
            }
        }
    }
}
