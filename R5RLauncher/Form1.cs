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
using System.Net.Http;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace R5RLauncher
{
    public partial class Form1 : Form
    {
        WebClient client = new WebClient();
        WebClient detoursdownloader = new WebClient();
        WebClient scriptsdownloader = new WebClient();
        Process p = new Process();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(683, 415);
            panel1.BringToFront();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel1.Location = new System.Drawing.Point(0, 30);
            panel2.Location = new System.Drawing.Point(0, 30);
            panel3.Location = new System.Drawing.Point(0, 30);
            panel4.Location = new System.Drawing.Point(0, 30);

            WebClient serverlist = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;

            DataTable dtdata = new DataTable();
            dtdata.Columns.Add("Server Name");
            dtdata.Columns.Add("Map");
            dtdata.Columns.Add("Gamemode");
            dtdata.Columns.Add("encKey");
            dtdata.Columns.Add("Ip");
            dtdata.Columns.Add("Port");

            string reply = serverlist.UploadString("https://r5a-comp-sv.herokuapp.com/servers", "");

            var result = JsonConvert.DeserializeObject<Root>(reply);

            foreach (var item in result.servers)
            {
                DataRow row = dtdata.NewRow();
                row[0] = item.name;
                row[1] = item.map;
                row[2] = item.gamemode;
                row[3] = item.encKey;
                row[4] = item.ip;
                row[5] = item.port;
                dtdata.Rows.Add(row);

            }

            guna2DataGridView1.DataSource = dtdata;

            guna2DataGridView1.Columns["Server Name"].FillWeight = 100;
            guna2DataGridView1.Columns["Map"].FillWeight = 100;
            guna2DataGridView1.Columns["Gamemode"].FillWeight = 50;
            guna2DataGridView1.Columns["encKey"].FillWeight = 0.1f;
            guna2DataGridView1.Columns["Ip"].FillWeight = 0.1f;
            guna2DataGridView1.Columns["Port"].FillWeight = 50;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            guna2DataGridView1.Columns.Add(btn);
            btn.HeaderText = "Connect";
            btn.Text = "Connect";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;


            StartupCheck();
        }

        private void StartupCheck()
        {
            //Check For Some Shit
            string checkversion = client.DownloadString("http://r5r.createxhosting.com/r5reloadedversion.txt");
            string getnotes = client.DownloadString("http://r5r.createxhosting.com/r5reloadedpatchnotes.txt");

            richTextBox1.Text = getnotes.Replace("thisisacoolnewlineok", Environment.NewLine);

            guna2TextBox1.Text = Settings.Default.GamePath;
            guna2HtmlLabel6.Text = Settings.Default.GameVersion;

            if (Directory.Exists(Settings.Default.GamePath + "/platform/scripts/"))
            {
                guna2HtmlLabel4.Text = "Found";
            }
            else
            {
                guna2HtmlLabel4.Text = "Not Found";
            }

            if (!Directory.Exists(Settings.Default.GamePath + "/platform/scripts"))
            {
                playbtn.Visible = false;
                updatebtn.Visible = true;
                choosebtn.Visible = false;
                updatepanel.Visible = true;
                getapexbtn.Visible = false;
                guna2ComboBox1.Visible = false;
            }

            if (Settings.Default.GameVersion == checkversion)
            {
                playbtn.Visible = true;
                updatebtn.Visible = false;
                choosebtn.Visible = false;
                updatepanel.Visible = false;
                getapexbtn.Visible = false;
                guna2ComboBox1.Visible = true;
            }
            else
            {
                playbtn.Visible = false;
                updatebtn.Visible = true;
                choosebtn.Visible = false;
                updatepanel.Visible = true;
                getapexbtn.Visible = false;
                guna2ComboBox1.Visible = false;
            }

            //Check to see if gamepath is set

            if (Settings.Default.GamePath == "NoPathSet")
            {
                playbtn.Visible = false;
                updatebtn.Visible = false;
                choosebtn.Visible = true;
                updatepanel.Visible = false;
                getapexbtn.Visible = true;
                guna2ComboBox1.Visible = false;
            }
        }

        static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        private void startDetoursDownload()
        {
            updateprogress.Visible = true;
            updatebtn.Enabled = false;

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
                    playbtn.Visible = true;
                    updatebtn.Visible = false;
                    choosebtn.Visible = false;
                    guna2ComboBox1.Visible = true;

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

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            guna2Transition1.Hide(panel3);
            guna2Transition1.Hide(panel1);
            guna2Transition1.Hide(panel4);
            guna2Transition1.Show(panel2);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string message = "Do you already have a Torrent client?\n\nPlease Note: You need a Torrent client in order to download Apex Season 3. \nDont have one? \nClick No I Will Take You To One.";
            string title = "Warning!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Process.Start("magnet:?xt=urn:btih:KCQJQT6DV2V4XWCOKCRM4EJELRLHQKI5&dn=R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM&tr=udp%3A%2F%2Fwambo.club%3A1337%2Fannounce");
            }
            else if (result == DialogResult.No)
            {
                Process.Start("https://www.fosshub.com/qBittorrent.html");
            }
            else
            {

            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://r5reloaded.gitbook.io/r5reloaded/");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void discordbtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/NSK7BWrB9H");
        }

        private void choosebtn_Click(object sender, EventArgs e)
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
                    getapexbtn.Visible = false;

                    if (File.Exists(folderPath + "/Run R5 Reloaded.exe") || Directory.Exists(folderPath + "/platform/scripts"))
                    {
                        //Ask if already has Latest R5 Reloaded installed
                        string message = "We may have found an existing install of R5 Reloaded.\nDo you want to use this install?\n\n(If you do make sure it is the latest version)";
                        string title = "?";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            playbtn.Visible = true;
                            updatebtn.Visible = false;
                            choosebtn.Visible = false;
                            guna2ComboBox1.Visible = true;

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
                    else
                    {
                        StartupCheck();
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
                        getapexbtn.Visible = false;

                        if (File.Exists(folderPath + "/Run R5 Reloaded.exe") || Directory.Exists(folderPath + "/platform/scripts"))
                        {
                            //Ask if already has Latest R5 Reloaded installed
                            string message2 = "We may have found an existing install of R5 Reloaded.\nDo you want to use this install?\n\n(If you do make sure it is the latest version)";
                            string title2 = "?";
                            MessageBoxButtons buttons2 = MessageBoxButtons.YesNo;
                            DialogResult result2 = MessageBox.Show(message2, title2, buttons2);
                            if (result2 == DialogResult.Yes)
                            {
                                playbtn.Visible = true;
                                updatebtn.Visible = false;
                                choosebtn.Visible = false;
                                guna2ComboBox1.Visible = true;

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
                        else
                        {
                            StartupCheck();
                        }
                    }
                    else
                    {
                        choosebtn.PerformClick();
                    }
                }
                
            }
        }

        private void playbtn_Click(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex == 0)
            {
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

        private void updatebtn_Click(object sender, EventArgs e)
        {
            startDetoursDownload();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            guna2Transition1.Hide(panel4);
            guna2Transition1.Hide(panel3);
            guna2Transition1.Hide(panel2);
            guna2Transition1.Show(panel1);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            guna2Transition1.Hide(panel4);
            guna2Transition1.Hide(panel1);
            guna2Transition1.Hide(panel2);
            guna2Transition1.Show(panel3);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2Transition1.Hide(panel4);
            guna2Transition1.Hide(panel3);
            guna2Transition1.Hide(panel2);
            guna2Transition1.Show(panel1);
        }

        private void playbtn_MouseHover(object sender, EventArgs e)
        {
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void discordbtn_MouseEnter(object sender, EventArgs e)
        {
        }

        private void discordbtn_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void guna2Button3_Click_2(object sender, EventArgs e)
        {
            guna2Transition1.Hide(panel1);
            guna2Transition1.Hide(panel3);
            guna2Transition1.Hide(panel2);
            guna2Transition1.Show(panel4);
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            guna2Transition1.Hide(panel4);
            guna2Transition1.Hide(panel3);
            guna2Transition1.Hide(panel2);
            guna2Transition1.Show(panel1);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.Columns["Server Name"].FillWeight = 100;
            guna2DataGridView1.Columns["Map"].FillWeight = 100;
            guna2DataGridView1.Columns["Gamemode"].FillWeight = 50;
            guna2DataGridView1.Columns["Port"].FillWeight = 50;

            WebClient serverlist = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;

            DataTable dtdata = new DataTable();
            dtdata.Columns.Add("Server Name");
            dtdata.Columns.Add("Map");
            dtdata.Columns.Add("Gamemode");
            dtdata.Columns.Add("Port");

            string reply = serverlist.UploadString("https://r5a-comp-sv.herokuapp.com/servers", "");

            var result = JsonConvert.DeserializeObject<Root>(reply);

            foreach (var item in result.servers)
            {
                DataRow row = dtdata.NewRow();
                row[0] = item.name;
                row[1] = item.map;
                row[2] = item.gamemode;
                row[3] = item.port;
                dtdata.Rows.Add(row);

            }
            guna2DataGridView1.DataSource = dtdata;
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        [StructLayout(LayoutKind.Sequential)]
        public struct COPYDATASTRUCT
        {
            /// <summary>
            /// User defined data to be passed to the receiving application.
            /// </summary>
            public IntPtr dwData;

            /// <summary>
            /// The size, in bytes, of the data pointed to by the lpData member.
            /// </summary>
            public int cbData;

            /// <summary>
            /// The data to be passed to the receiving application. This member can be IntPtr.Zero.
            /// </summary>
            public IntPtr lpData;
        }

        public static uint WM_COPYDATA = 0x004A;

        private void connecttoserver(string ip,string port, string key)
        {
            /*IntPtr hWndTargetWindow = FindWindow("ConsoleWindowClass", null);
            SetForegroundWindow(hWndTargetWindow);

            SendKeys.Send("changekey " + key + "{ENTER}");
            SendKeys.Send("connect " + ip + ":" + port + "{ENTER}");

            ShowWindowAsync(hWndTargetWindow, SW_SHOWMINIMIZED);*/

            string m_pTestCommand = "launcherconnect" + " " + ip + " " + port + " " + key;

            IntPtr m_hEngine = FindWindow("Respawn001", null);

            COPYDATASTRUCT m_cData;
            m_cData.cbData = m_pTestCommand.Length + 1;
            m_cData.dwData = IntPtr.Zero;
            m_cData.lpData = Marshal.StringToHGlobalAnsi(m_pTestCommand);

            // Allocate memory for the data and copy
            IntPtr ptrCopyData = Marshal.AllocCoTaskMem(Marshal.SizeOf(m_cData));
            Marshal.StructureToPtr(m_cData, ptrCopyData, false);

            SendMessage(m_hEngine, WM_COPYDATA, IntPtr.Zero, ptrCopyData);
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            string m_pTestCommand = "launcherconnect";

            IntPtr m_hEngine = FindWindow("Respawn001", null);

            COPYDATASTRUCT m_cData;
            m_cData.cbData = m_pTestCommand.Length + 1;
            m_cData.dwData = IntPtr.Zero;
            m_cData.lpData = Marshal.StringToHGlobalAnsi(m_pTestCommand);

            // Allocate memory for the data and copy
            IntPtr ptrCopyData = Marshal.AllocCoTaskMem(Marshal.SizeOf(m_cData));
            Marshal.StructureToPtr(m_cData, ptrCopyData, false);

            SendMessage(m_hEngine, WM_COPYDATA, IntPtr.Zero, ptrCopyData);
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = guna2DataGridView1.Rows[rowIndex];
            MessageBox.Show(row.Cells[0].Value.ToString());
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = guna2DataGridView1.Rows[rowIndex];
                string ip = row.Cells[4].Value.ToString();
                string port = row.Cells[5].Value.ToString();
                string key = row.Cells[3].Value.ToString();

                connecttoserver(ip, port, key);
            }
        }
    }
    public class Server
    {
        public string name { get; set; }
        public string map { get; set; }
        public string ip { get; set; }
        public string port { get; set; }
        public string gamemode { get; set; }
        public string encKey { get; set; }
        public string hidden { get; set; }
    }

    public class Root
    {
        public bool success { get; set; }
        public string err { get; set; }
        public List<Server> servers { get; set; }
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
