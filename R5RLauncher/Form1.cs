using R5RLauncher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R5RLauncher
{
    public partial class Form1 : Form
    {
        WebClient client = new WebClient();
        WebClient detoursdownloader = new WebClient();
        WebClient scriptsdownloader = new WebClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartupCheck();
        }

        private void StartupCheck()
        {
            //Check For Some Shit
            string checkversion = client.DownloadString("http://r5r.createxhosting.com/r5reloadedversion.txt");

            if (!Directory.Exists(Settings.Default.GamePath + "/platform/scripts"))
            {
                playbutton.Text = "Update Detours";
                updatepanel.Visible = true;
                getapex.Visible = false;
            }

            if (Settings.Default.GameVersion == checkversion)
            {
                playbutton.Text = "Play";
                updatepanel.Visible = false;
                getapex.Visible = false;
            }
            else
            {
                playbutton.Text = "Update Detours";
                updatepanel.Visible = true;
                getapex.Visible = false;
            }

            //Check to see if gamepath is set

            if (Settings.Default.GamePath == "NoPathSet")
            {
                playbutton.Text = "Set Game Path";
                updatepanel.Visible = false;
                getapex.Visible = true;
            }
        }

        static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        private void startDetoursDownload()
        {
            updateprogress.Visible = true;

            Thread thread = new Thread(() => {

                detoursdownloader.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Detours_DownloadProgressChanged);
                detoursdownloader.DownloadFileCompleted += new AsyncCompletedEventHandler(Detours_DownloadFileCompleted);
                detoursdownloader.DownloadFileAsync(new Uri("http://r5r.createxhosting.com/detours.zip"), @Settings.Default.GamePath + "/detours.zip");
            
            });
            thread.Start();
        }
        void Detours_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            startScriptsDownload();
        }

        void Detours_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {

                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;

                guna2HtmlLabel1.Text = "Downloading Detours: " + ConvertBytesToMegabytes(e.BytesReceived).ToString("F1") + "mb of " + ConvertBytesToMegabytes(e.TotalBytesToReceive).ToString("F1") + "mb";
                updateprogress.Value = int.Parse(Math.Truncate(percentage).ToString());

            });
        }

        private void startScriptsDownload()
        {
            Thread thread = new Thread(() => {

                scriptsdownloader.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Scripts_DownloadProgressChanged);
                scriptsdownloader.DownloadFileCompleted += new AsyncCompletedEventHandler(Scripts_DownloadFileCompleted);
                scriptsdownloader.DownloadFileAsync(new Uri("http://r5r.createxhosting.com/scripts.zip"), @Settings.Default.GamePath + "/scripts.zip");
            
            });
            thread.Start();
        }

        void Scripts_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {

                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;

                guna2HtmlLabel1.Text = "Downloading Scripts: " + ConvertBytesToMegabytes(e.BytesReceived).ToString("F1") + "mb of " + ConvertBytesToMegabytes(e.TotalBytesToReceive).ToString("F1") + "mb";
                updateprogress.Value = int.Parse(Math.Truncate(percentage).ToString());

            });
        }
        void Scripts_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Thread thread = new Thread(() => {
                this.BeginInvoke((MethodInvoker)delegate {
                    updateprogress.Visible = false;
                });

                //Extract Detours
                this.BeginInvoke((MethodInvoker)delegate {
                    guna2HtmlLabel1.Text = "Extracting Detours...";

                });

                var detours = ZipFile.Open(Settings.Default.GamePath + "/detours.zip", ZipArchiveMode.Read);
                ZipArchiveExtensions.ExtractToDirectory(detours, Settings.Default.GamePath + "/", true);

                Thread.Sleep(30000); //Required so the file fully extracts and the user dosnt press play before it is done.

                //Extract Scripts
                if (Directory.Exists(Settings.Default.GamePath + "/platform/scripts"))
                {

                    DialogResult dialogResult = MessageBox.Show("We found you currelty have a existing scripts folder.\n\nDo you want to download the latests scripts?\n\nThis would be the recommended action\n\nDoing so will remove your entire scripts folder!", "NEED USER INPUT", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        this.BeginInvoke((MethodInvoker)delegate {
                            guna2HtmlLabel1.Text = "Removing Old Scripts Folder...";
                        });

                        Thread.Sleep(2000);

                        Directory.Delete(Settings.Default.GamePath + "/platform/scripts", true);

                        this.BeginInvoke((MethodInvoker)delegate {
                            guna2HtmlLabel1.Text = "Extracting Scripts...";
                        });

                        var scripts = ZipFile.Open(Settings.Default.GamePath + "/scripts.zip", ZipArchiveMode.Read);
                        ZipArchiveExtensions.ExtractToDirectory(scripts, Settings.Default.GamePath + "/platform/scripts", true);

                        Thread.Sleep(15000);
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                        this.BeginInvoke((MethodInvoker)delegate {
                            guna2HtmlLabel1.Text = "Continuing Without Updating Scripts...";
                        });

                        Thread.Sleep(2000);
                    }

                }
                else
                {

                    this.BeginInvoke((MethodInvoker)delegate {
                        guna2HtmlLabel1.Text = "Extracting Scripts...";

                    });

                    var scripts = ZipFile.Open(Settings.Default.GamePath + "/scripts.zip", ZipArchiveMode.Read);
                    ZipArchiveExtensions.ExtractToDirectory(scripts, Settings.Default.GamePath + "/platform/scripts", true);

                    Thread.Sleep(30000); //Required so the file fully extracts and the user dosnt press play before it is done.
                }

                Thread.Sleep(2000);

                this.BeginInvoke((MethodInvoker)delegate {

                    guna2HtmlLabel1.Text = "Update Completed!";
                    playbutton.Text = "Play";

                    string completedversion = client.DownloadString("http://r5r.createxhosting.com/r5reloadedversion.txt");
                    Settings.Default.GameVersion = completedversion;
                    Settings.Default.Save();

                });

                Thread.Sleep(2000);

                this.BeginInvoke((MethodInvoker)delegate {

                    updatepanel.Visible = false;

                });
            });
            thread.Start();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Stupid Checks
            if (Settings.Default.GamePath == "NoPathSet")
            {
                OpenFileDialog folderBrowser = new OpenFileDialog();
                // Set validate names and check file exists to false otherwise windows will
                // not let you select "Folder Selection."
                folderBrowser.ValidateNames = false;
                folderBrowser.CheckFileExists = false;
                folderBrowser.CheckPathExists = true;
                folderBrowser.Title = "Please select your Apex Season 3 r5apex.exe.";
                folderBrowser.FileName = "r5apex.exe";
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                    Settings.Default.GamePath = folderPath;
                    Settings.Default.Save();
                    getapex.Visible = false;

                    //Ask if already has Latest R5 Reloaded installed
                    string message = "Do you already have the latest R5 Reloaded Installed?";
                    string title = "?";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        playbutton.Text = "Play";

                        string completedversion = client.DownloadString("http://r5r.createxhosting.com/r5reloadedversion.txt");
                        Settings.Default.GameVersion = completedversion;
                        Settings.Default.Save();

                        StartupCheck();
                    }
                    else
                    {
                        StartupCheck();
                    }
                }
            }
            else
            {
                string checkversion = client.DownloadString("http://r5r.createxhosting.com/r5reloadedversion.txt");
                if (Settings.Default.GameVersion == checkversion)
                {
                    
                    if (guna2ComboBox1.SelectedIndex == 0)
                    {
                        // If Release
                        Process p = new Process();
                        p.StartInfo.WorkingDirectory = Settings.Default.GamePath;
                        p.StartInfo.FileName = Settings.Default.GamePath + "\\Run R5 Reloaded.exe";
                        p.StartInfo.Arguments = "-release";
                        p.Start();
                    }
                    else
                    {
                        // If Dev
                        Process p = new Process();
                        p.StartInfo.WorkingDirectory = Settings.Default.GamePath;
                        p.StartInfo.FileName = Settings.Default.GamePath + "\\Run R5 Reloaded.exe";
                        p.StartInfo.Arguments = "-debug";
                        p.Start();
                    }
                        
                }
                else
                {
                    startDetoursDownload();
                }
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Form2 settings = new Form2();
            settings.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string message = "Do you already have a Torrent client?\n\nPlease Note: You need a Torrent client for the button to work. \nDont have one? \nClick No I Will Take You To One.";
            string title = "Warning!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Process.Start("magnet:?xt=urn:btih:KCQJQT6DV2V4XWCOKCRM4EJELRLHQKI5&dn=R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM&tr=udp%3A%2F%2Fwambo.club%3A1337%2Fannounce");
            }
            else
            {
                Process.Start("https://www.bittorrent.com/downloads/complete/classic/");
            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://r5reloaded.gitbook.io/r5reloaded/");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form3 patchnotes = new Form3();
            patchnotes.Show();
        }

        private void discordbtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/NSK7BWrB9H");
        }
    }

    public static class ZipArchiveExtensions
    {
        public static void ExtractToDirectory(this ZipArchive archive, string destinationDirectoryName, bool overwrite)
        {
            if (!overwrite)
            {
                archive.ExtractToDirectory(destinationDirectoryName);
                return;
            }
            foreach (ZipArchiveEntry file in archive.Entries)
            {
                string completeFileName = Path.Combine(destinationDirectoryName, file.FullName);
                string directory = Path.GetDirectoryName(completeFileName);

                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                if (file.Name != "")
                    file.ExtractToFile(completeFileName, true);
            }
        }
    }
}
