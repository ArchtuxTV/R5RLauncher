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

namespace R5RLauncher.R5Panels
{
    public partial class PatchPanel : UserControl
    {
        WebClient client = new WebClient();
        public PatchPanel()
        {
            InitializeComponent();
        }

        private void PatchPanel_Load(object sender, EventArgs e)
        {
            string getnotes = client.DownloadString("http://r5r.createxhosting.com/r5reloadedpatchnotes.txt");
            PatchNotes.Text = getnotes.Replace("thisisacoolnewlineok", Environment.NewLine);
        }
    }
}
