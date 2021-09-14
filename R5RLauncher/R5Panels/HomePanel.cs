using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using R5RLauncher.Properties;
using System.Diagnostics;
using System.Threading;
using System.Security.Cryptography;

namespace R5RLauncher
{
    public partial class HomePanel : UserControl
    {
        WebClient serverlistweb = new WebClient();

        string vis = "public";

        public HomePanel()
        {
            InitializeComponent();
        }
        private void HomePanel_Load(object sender, EventArgs e)
        {
            serverlistweb.Encoding = System.Text.Encoding.UTF8;
            string serverlistresault = serverlistweb.UploadString("https://r5a-comp-sv.herokuapp.com/servers", "");
            var result = JsonConvert.DeserializeObject<Root>(serverlistresault);
            ServerCount.Text = "Server Count: " + result.servers.Count();

            CreateServerPanel.Location = new Point(0, 0);
            CreateServerPanel.Visible = false;

            ServerPassword.Text = RandomString(22) + "==";
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void HomePanel_VisibleChanged(object sender, EventArgs e)
        {
            CreateServerPanel.Visible = false;
            MainHomePanel.Visible = true;
        }

        private void createserverbackbtn_Click(object sender, EventArgs e)
        {
            Launcher launcher = (Launcher)Application.OpenForms["Launcher"];
            launcher.SetBreadCrumText("Home");
            guna2Transition1.Hide(CreateServerPanel);
            guna2Transition1.Show(MainHomePanel);
        }

        private void CreateServerbtn_Click(object sender, EventArgs e)
        {
            Launcher launcher = (Launcher)Application.OpenForms["Launcher"];
            launcher.SetBreadCrumText("Home > Create Server");
            guna2Transition1.Hide(MainHomePanel);
            guna2Transition1.Show(CreateServerPanel);
        }

        private void Publicbtn_Click(object sender, EventArgs e)
        {
            Privatebtn.Checked = false;
            Publicbtn.Checked = true;
            vis = "public";
        }

        private void Privatebtn_Click(object sender, EventArgs e)
        {
            Privatebtn.Checked = true;
            Publicbtn.Checked = false;
            vis = "private";
        }

        private void ServerCountTimer_Tick(object sender, EventArgs e)
        {
            serverlistweb.Encoding = System.Text.Encoding.UTF8;
            string serverlistresault = serverlistweb.UploadString("https://r5a-comp-sv.herokuapp.com/servers", "");
            var result = JsonConvert.DeserializeObject<Root>(serverlistresault);
            ServerCount.Text = "Server Count: " + result.servers.Count();
        }

        private async void LaunchGamebtn_Click(object sender, EventArgs e)
        {
            if (File.ReadAllText(Settings.Default.GamePath + "/platform/cfg/startup_retail.cfg").Contains("-dev"))
            {
                //File Good
            }
            else
            {
                using (StreamWriter sw = File.AppendText(Settings.Default.GamePath + "/platform/cfg/startup_retail.cfg"))
                {
                    sw.WriteLine("\n-dev");
                }
            }

            if (Settings.Default.DevBuild)
            {
                LaunchGamebtn.Enabled = false;
                CServerbtn.Enabled = false;

                Process apex = new Process();
                apex.StartInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                apex.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "\\injectr5.exe";
                apex.StartInfo.Arguments = "-rl";
                apex.Start();

                await Task.Delay(10000);

                WatchApex.Start();
            }
            else
            {
                LaunchGamebtn.Enabled = false;
                CServerbtn.Enabled = false;

                Process apex = new Process();
                apex.StartInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                apex.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "\\injectr5.exe";
                apex.StartInfo.Arguments = "-rl";
                apex.Start();

                await Task.Delay(10000);

                WatchApex.Start();
            }
        }

        private async void CServerbtn_Click(object sender, EventArgs e)
        {
            if (File.ReadAllText(Settings.Default.GamePath + "/platform/cfg/startup_retail.cfg").Contains("-dev"))
            {
                //File Good
            }
            else
            {
                using (StreamWriter sw = File.AppendText(Settings.Default.GamePath + "/platform/cfg/startup_retail.cfg"))
                {
                    sw.WriteLine("\n-dev");
                }
            }

            string finishedmap;

            if (MapBox.SelectedItem.ToString() == "King's Canyon Season 1")
            {
                finishedmap = "mp_rr_canyonlands_64k_x_64k";
            }
            else if (MapBox.SelectedItem.ToString() == "King's Canyon Season 2")
            {
                finishedmap = "mp_rr_canyonlands_mu1";
            }
            else if (MapBox.SelectedItem.ToString() == "King's Canyon After Dark")
            {
                finishedmap = "mp_rr_canyonlands_mu1_night";
            }
            else if (MapBox.SelectedItem.ToString() == "World's Edge")
            {
                finishedmap = "mp_rr_desertlands_64k_x_64k";
            }
            else if (MapBox.SelectedItem.ToString() == "World's Edge After Dark")
            {
                finishedmap = "mp_rr_desertlands_64k_x_64k_nx";
            }
            else if (MapBox.SelectedItem.ToString() == "Firing Range")
            {
                finishedmap = "mp_rr_canyonlands_staging";
            }
            else
            {
                finishedmap = MapBox.SelectedItem.ToString();
            }

            string autoexecpath = Settings.Default.GamePath + "/platform/cfg/autoexec_r5launcher.cfg";
            string servernamepath = Settings.Default.GamePath + "/platform/cfg/LauncherStuff/servername.txt";
            string keypath = Settings.Default.GamePath + "/platform/cfg/LauncherStuff/key.txt";
            string vispath = Settings.Default.GamePath + "/platform/cfg/LauncherStuff/vis.txt";
            string launcherstufffolder = Settings.Default.GamePath + "/platform/cfg/LauncherStuff";

            string serverstuff =
                "exec autoexec" + "\n" +
                "playlistfile playlists_r5_patch.txt" + "\n" +
                "playlist " + GamemodeBox.SelectedItem.ToString() + "\n" +
                "mp_gamemode " + GamemodeBox.SelectedItem.ToString() + "\n" +
                "map " + finishedmap;

            bool exists = System.IO.Directory.Exists(launcherstufffolder);

            if (!exists)
                System.IO.Directory.CreateDirectory(launcherstufffolder);

            File.WriteAllText(autoexecpath, serverstuff);
            File.WriteAllText(servernamepath, ServerName.Text);

            LaunchGamebtn.Enabled = false;
            CServerbtn.Enabled = false;

            Process apex = new Process();
            apex.StartInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            apex.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "\\injectr5.exe";
            apex.StartInfo.Arguments = "-rl";
            apex.Start();

            await Task.Delay(15000);

            WatchApex.Start();

            Helpers.StartServer(vis, ServerPassword.Text, ServerName.Text);
        }


        private void WatchApex_Tick(object sender, EventArgs e)
        {
            Process[] apexchecking = Process.GetProcessesByName("r5apex");

            if (apexchecking.Length > 0)
            {
                LaunchGamebtn.Enabled = false;
                CServerbtn.Enabled = false;
            }
            else
            {
                LaunchGamebtn.Enabled = true;
                CServerbtn.Enabled = true;
                WatchApex.Stop();
            }
        }

        private void MapBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (MapBox.SelectedIndex == 0)
            {
                Mappic.Image = Resources.KCS1;
            }
            else if (MapBox.SelectedIndex == 1)
            {
                Mappic.Image = Resources.KCS2;
            }
            else if (MapBox.SelectedIndex == 2)
            {
                Mappic.Image = Resources.KCAD;
            }
            else if (MapBox.SelectedIndex == 3)
            {
                Mappic.Image = Resources.WES3;
            }
            else if (MapBox.SelectedIndex == 4)
            {
                Mappic.Image = Resources.WES3;
            }
            else if (MapBox.SelectedIndex == 5)
            {
                Mappic.Image = Resources.FR;
            }
            else
            {
                Mappic.Image = Resources.KCS1;
            }
        }

        private void RegenKey_Click(object sender, EventArgs e)
        {
            ServerPassword.Text = RandomString(22) + "==";
        }
    }
}
