using Newtonsoft.Json;
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
    public partial class ServerListPanel : UserControl
    {
        WebClient serverlistweb = new WebClient();
        Guna.UI2.WinForms.Helpers.PanelScrollHelper scrollbar;
        public ServerListPanel()
        {
            InitializeComponent();
        }

        private void ServerListPanel_Load(object sender, EventArgs e)
        {
            FillServerList();
            ServerList.AutoScroll = true;
            ServerList.VerticalScroll.Visible = false;
            ServerList.HorizontalScroll.Visible = false;
            scrollbar = new Guna.UI2.WinForms.Helpers.PanelScrollHelper(ServerList, guna2VScrollBar1, true);
            scrollbar.UpdateScrollBar();

            InfoPanel.Location = new Point(0, 0);
            InfoPanel.Hide();

            this.Size = new System.Drawing.Size(775, 454);
        }

        private void SendServerInfo(string name, string map, string gamemode,string ip, string port, string enckey)
        {
            //Setup Server Name
            SIServerName.Text = name;

            //Setup Map Image And Name
            if (map == "mp_rr_canyonlands_64k_x_64k")
            {
                SIMapname.Text = "King's Canyon Season 0";
                SIMappic.Image = R5RLauncher.Properties.Resources.KCS1;
            }
            else if (map == "mp_rr_canyonlands_mu1")
            {
                SIMapname.Text = "King's Canyon Season 2";
                SIMappic.Image = R5RLauncher.Properties.Resources.KCS2;
            }
            else if (map == "mp_rr_canyonlands_mu1_night")
            {
                SIMapname.Text = "King's Canyon Season 2 After Dark";
                SIMappic.Image = R5RLauncher.Properties.Resources.KCAD;
            }
            else if (map == "mp_rr_desertlands_64k_x_64k_nx")
            {
                SIMapname.Text = "World's Edge Season 3 After Dark";
                SIMappic.Image = R5RLauncher.Properties.Resources.WES3;
            }
            else if (map == "mp_rr_desertlands_64k_x_64k")
            {
                SIMapname.Text = "World's Edge Season 3";
                SIMappic.Image = R5RLauncher.Properties.Resources.WES3;
            }
            else if (map == "mp_rr_canyonlands_staging")
            {
                SIMapname.Text = "King's Canyon Firing Range";
                SIMappic.Image = R5RLauncher.Properties.Resources.FR;
            }
            else
            {
                SIMapname.Text = map;
                SIMappic.Image = R5RLauncher.Properties.Resources.WES3;
            }

            //Setup Gamemode Text
            if (gamemode == "custom_tdm")
            {
                SIGamemode.Text = "Team Deathmatch";
            }
            else
            {
                SIGamemode.Text = gamemode;
            }

            if (name.Contains("FFA") || name.Contains("Free For All") || name.Contains("DeathMatch"))
            {
                SIGamemode.Text = "Free For All";
            }
            else if (name.Contains("Gun Game") || name.Contains("GunGame"))
            {
                SIGamemode.Text = "Gun Game";
            }
            else if (name.Contains("TDM") || name.Contains("Team Death Match"))
            {
                SIGamemode.Text = "Team Deathmatch";
            }

            //Setup Port Text
            SIPort.Text = port;

            //Setup EncKey Text
            SIEncKey.Text = enckey;

            //Setup Hidden IP Text For Connect Button
            SIIP.Text = ip;
        }

        private void FillServerList()
        {
            //Remove Old Items
            ServerList.Controls.Clear();

            //Disable Refresh Button
            Refreshbtn.Enabled = false;

            //Get Server List Data Via API
            serverlistweb.Encoding = System.Text.Encoding.UTF8;
            string serverlistresault = serverlistweb.UploadString("https://r5a-comp-sv.herokuapp.com/servers", "");
            var result = JsonConvert.DeserializeObject<Root>(serverlistresault);

            //Setup If First Item Is Being Added
            bool firstbtn = true;
            bool firstbg = true;

            //Setup Item Locations
            Point btnlocation = new Point(609, 0);
            Point bglocation = new Point(14, 0);
            int serverspacing = 50;

            NoServers.Visible = true;
            foreach (var item in result.servers)
            {
                NoServers.Visible = false;

                //Add Server Background
                Guna.UI2.WinForms.Guna2Panel bg = new Guna.UI2.WinForms.Guna2Panel();
                bg.Parent = ServerList;
                bg.Size = new Size(732, 44);
                //bg.BackColor = Color.FromArgb(26, 27, 63);
                bg.FillColor = Color.FromArgb(26, 27, 63);
                bg.BorderRadius = 2;

                if (firstbg)
                {
                    bg.Location = bglocation;
                    firstbg = false;
                }
                else
                {
                    bglocation.Y = bglocation.Y + serverspacing;
                    bg.Location = bglocation;
                }
                //End Of Add Server Background

                //Add Connect Button
                Guna.UI2.WinForms.Guna2Button connect = new Guna.UI2.WinForms.Guna2Button();
                connect.Text = "Connect";
                connect.Image = R5RLauncher.Properties.Resources.connect;
                connect.Font = new Font("Poppins", (float)9.75);
                connect.Parent = bg;
                connect.FillColor = Color.FromArgb(26, 27, 63);
                connect.Size = new System.Drawing.Size(95, 44);
                connect.Location = new System.Drawing.Point(593, 0);
                connect.Animated = true;
                connect.Click += (s, e) => { Helpers.ServerConnect(item.ip, item.port, item.encKey); };
                //End Of Add Connect Button

                //Add Server Info Button
                Guna.UI2.WinForms.Guna2Button info = new Guna.UI2.WinForms.Guna2Button();
                info.Text = "";
                info.Image = R5RLauncher.Properties.Resources.info;
                info.Parent = bg;
                info.FillColor = Color.FromArgb(26, 27, 63);
                info.Size = new System.Drawing.Size(44, 44);
                info.Location = new System.Drawing.Point(688, 0);
                info.Animated = true;
                info.Click += (s, e) => {

                    SendServerInfo(item.name, item.map, item.gamemode,item.ip, item.port, item.encKey);
                    guna2Transition1.Hide(Mainserverlistpanel);
                    guna2Transition1.Show(InfoPanel);

                };
                //End Of Add Server Info Button

                //Add Server Name Text
                Guna.UI2.WinForms.Guna2HtmlLabel servername = new Guna.UI2.WinForms.Guna2HtmlLabel();
                servername.Parent = bg;
                servername.Font = new Font("Poppins Medium", (float)9.75);
                servername.AutoSize = false;
                servername.Width = 583;
                servername.Height = 25;
                servername.ForeColor = Color.White;
                servername.Location = new Point(3, 3);
                servername.Text = item.name;
                //End Of Add ServerName Text

                //Add Map Text
                Guna.UI2.WinForms.Guna2HtmlLabel mapname = new Guna.UI2.WinForms.Guna2HtmlLabel();
                mapname.Parent = bg;
                mapname.Font = new Font("Poppins ExtraLight", (float)9.75);
                mapname.AutoSize = false;
                mapname.Width = 274;
                mapname.Height = 19;
                mapname.ForeColor = Color.White;
                mapname.Location = new Point(3, 22);

                if (item.map == "mp_rr_canyonlands_64k_x_64k")
                {
                    mapname.Text = "King's Canyon Season 0";
                }
                else if (item.map == "mp_rr_desertlands_64k_x_64k")
                {
                    mapname.Text = "World's Edge Season 3";
                }
                else if (item.map == "mp_rr_canyonlands_mu1")
                {
                    mapname.Text = "King's Canyon Season 2";
                }
                else if (item.map == "mp_rr_canyonlands_mu1_night")
                {
                    mapname.Text = "King's Canyon Season 2 After Dark";
                }
                else if (item.map == "mp_rr_desertlands_64k_x_64k_nx")
                {
                    mapname.Text = "World's Edge Season 3 After Dark";
                }
                else if (item.map == "mp_rr_canyonlands_staging")
                {
                    mapname.Text = "King's Canyon Firing Range";
                }
                else
                {
                    mapname.Text = item.map;
                }
                //End Of Add Map Text

                //Add Gamemode Text
                Guna.UI2.WinForms.Guna2HtmlLabel gamemode = new Guna.UI2.WinForms.Guna2HtmlLabel();
                gamemode.Parent = bg;
                gamemode.Font = new Font("Poppins ExtraLight", (float)9.75);
                gamemode.AutoSize = false;
                gamemode.Width = 271;
                gamemode.Height = 19;
                gamemode.ForeColor = Color.White;
                gamemode.Location = new Point(315, 22);
                gamemode.TextAlignment = ContentAlignment.MiddleRight;

                if (item.gamemode == "custom_tdm")
                {
                    gamemode.Text = "Team Deathmatch";
                }
                else
                {
                    gamemode.Text = item.gamemode;
                }
                if (item.name.Contains("FFA") || item.name.Contains("Free For All") || item.name.Contains("DeathMatch"))
                {
                    gamemode.Text = "Free For All";
                }
                else if (item.name.Contains("Gun Game") || item.name.Contains("GunGame"))
                {
                    gamemode.Text = "Gun Game";
                }
                else if (item.name.Contains("TDM") || item.name.Contains("Team Death Match"))
                {
                    gamemode.Text = "Team Deathmatch";
                }
                //End Of Add Gamemode Text

            }


            Refreshbtn.Enabled = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FillServerList();
        }

        private void Infobackbtn_Click(object sender, EventArgs e)
        {
            guna2Transition1.Hide(InfoPanel);
            guna2Transition1.Show(Mainserverlistpanel);
        }

        private void SIConnect_Click(object sender, EventArgs e)
        {
            Helpers.ServerConnect(SIIP.Text, SIPort.Text, SIEncKey.Text);
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
}
