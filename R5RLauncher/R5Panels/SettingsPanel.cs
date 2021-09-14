using R5RLauncher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R5RLauncher.R5Panels
{
    public partial class SettingsPanel : UserControl
    {
        WebClient client = new WebClient();

        public SettingsPanel()
        {
            InitializeComponent();
        }

        private void SettingsPanel_Load(object sender, EventArgs e)
        {
            GamePathTextBox.Text = Settings.Default.GamePath;
        }

        private void gamepathbtn_Click(object sender, EventArgs e)
        {
            //This shit is TERIBLE.
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.Title = "Please select your Apex Season 3 r5apex.exe.";
            folderBrowser.FileName = "r5apex.exe";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(folderPath + "\\r5apex.exe");
                if (myFileVersionInfo.ProductVersion.Contains("_N1094_CL456479_"))
                {
                    Settings.Default.GamePath = folderPath;
                    Settings.Default.Save();

                    if (File.Exists(folderPath + "/Run R5 Reloaded.exe") || Directory.Exists(folderPath + "/platform/scripts"))
                    {
                        //Ask if already has Latest R5 Reloaded installed
                        string message = "We may have found an existing install of R5 Reloaded.\nDo you want to use this install?\n\n(If you do make sure it is the latest version)";
                        string title = "?";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {

                            string completedversion = client.DownloadString("http://r5r.createxhosting.com/r5reloadedversion.txt");
                            Settings.Default.GameVersion = completedversion;
                            Settings.Default.Save();

                            //StartupCheck();
                        }
                        else
                        {
                            //StartupCheck();
                        }
                    }
                    else
                    {
                        //StartupCheck();
                    }
                }
                else
                {
                    //Ask if they are sure its the correct exe
                    string message = "It seem this apex exe dose not match the one required.\n(Apex Season 3 Is Required!)\nAre you sure this is the correct one?";
                    string title = "Warning!";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        Settings.Default.GamePath = folderPath;
                        Settings.Default.Save();

                        if (File.Exists(folderPath + "/Run R5 Reloaded.exe") || Directory.Exists(folderPath + "/platform/scripts"))
                        {
                            //Ask if already has Latest R5 Reloaded installed
                            string message2 = "We may have found an existing install of R5 Reloaded.\nDo you want to use this install?\n\n(If you do make sure it is the latest version)";
                            string title2 = "?";
                            MessageBoxButtons buttons2 = MessageBoxButtons.YesNo;
                            DialogResult result2 = MessageBox.Show(message2, title2, buttons2);
                            if (result2 == DialogResult.Yes)
                            {

                                string completedversion = client.DownloadString("http://r5r.createxhosting.com/r5reloadedversion.txt");
                                Settings.Default.GameVersion = completedversion;
                                Settings.Default.Save();

                                //StartupCheck();
                            }
                            else
                            {
                                //StartupCheck();
                            }
                        }
                        else
                        {
                            //StartupCheck();
                        }
                    }
                    else
                    {
                        gamepathbtn.PerformClick();
                    }
                }

            }
        }

        private void Releasebtn_Click(object sender, EventArgs e)
        {
            Releasebtn.Checked = true;
            Devbtn.Checked = false;
            Settings.Default.DevBuild = false;
            Settings.Default.Save();
        }

        private void Devbtn_Click(object sender, EventArgs e)
        {
            Releasebtn.Checked = false;
            Devbtn.Checked = true;
            Settings.Default.DevBuild = true;
            Settings.Default.Save();
        }
    }
}
