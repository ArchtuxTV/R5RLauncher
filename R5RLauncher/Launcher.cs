using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R5RLauncher
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        Control active = null;
        Guna.UI2.WinForms.Guna2Button current = null;
        Size panelsize = new Size(766, 453);
        Point panellocation = new Point(185, 43);
        private void Launcher_Load(object sender, EventArgs e)
        {
            //Setup user controls

            homePanel1.Size = panelsize;
            homePanel1.Location = panellocation;

            serverListPanel1.Size = panelsize;
            serverListPanel1.Location = panellocation;

            patchPanel1.Size = panelsize;
            patchPanel1.Location = panellocation;

            downloadApexPanel1.Size = panelsize;
            downloadApexPanel1.Location = panellocation;

            settingsPanel1.Size = panelsize;
            settingsPanel1.Location = panellocation;

            homePanel1.SendToBack();
            serverListPanel1.SendToBack();
            patchPanel1.SendToBack();
            downloadApexPanel1.SendToBack();
            settingsPanel1.SendToBack();

            homePanel1.Visible = true;
            serverListPanel1.Visible = false;
            patchPanel1.Visible = false;
            downloadApexPanel1.Visible = false;
            settingsPanel1.Visible = false;

            Homebtn.Checked = true;
            active = homePanel1;
            current = Homebtn;
        }

        private void SetActiveButton(Guna.UI2.WinForms.Guna2Button setchecked, Guna.UI2.WinForms.Guna2Button setnotchecked)
        {
            setnotchecked.Checked = false;
            setchecked.Checked = true;
            current = setchecked;
        }

        private void SetBreadCrum(string text)
        {
            BreadCrum.Text = "Launcher > " + text;
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            if(active != homePanel1)
            {
                guna2Transition1.Hide(active);
                guna2Transition1.Show(homePanel1);
                active = homePanel1;
                SetActiveButton(Homebtn, current);
                SetBreadCrum("Home");
            }
        }

        private void Serverlistbtn_Click(object sender, EventArgs e)
        {
            if (active != serverListPanel1)
            {
                guna2Transition1.Hide(active);
                guna2Transition1.Show(serverListPanel1);
                active = serverListPanel1;
                SetActiveButton(Serverlistbtn, current);
                SetBreadCrum("Server List");
            }
        }

        private void Patchnotesbtn_Click(object sender, EventArgs e)
        {
            if (active != patchPanel1)
            {
                guna2Transition1.Hide(active);
                guna2Transition1.Show(patchPanel1);
                active = patchPanel1;
                SetActiveButton(Patchnotesbtn, current);
                SetBreadCrum("R5 Patch Notes");
            }
        }

        private void Downloadapexbtn_Click(object sender, EventArgs e)
        {
            if (active != downloadApexPanel1)
            {
                guna2Transition1.Hide(active);
                guna2Transition1.Show(downloadApexPanel1);
                active = downloadApexPanel1;
                SetActiveButton(Downloadapexbtn, current);
                SetBreadCrum("Download Apex");
            }
        }

        private void Settingsbtn_Click(object sender, EventArgs e)
        {
            if (active != settingsPanel1)
            {
                guna2Transition1.Hide(active);
                guna2Transition1.Show(settingsPanel1);
                active = settingsPanel1;
                SetActiveButton(Settingsbtn, current);
                SetBreadCrum("Settings");
            }
        }

        public void SetBreadCrumText(string text)
        {
            this.BreadCrum.Text = "Launcher > " + text;
        }
    }
}
