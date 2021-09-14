
namespace R5RLauncher
{
    partial class Launcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.SideBar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Patchnotesbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Settingsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Downloadapexbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Serverlistbtn = new Guna.UI2.WinForms.Guna2Button();
            this.R5Text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.R5Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Homebtn = new Guna.UI2.WinForms.Guna2Button();
            this.TopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.BreadCrum = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.settingsPanel1 = new R5RLauncher.R5Panels.SettingsPanel();
            this.patchPanel1 = new R5RLauncher.R5Panels.PatchPanel();
            this.downloadApexPanel1 = new R5RLauncher.R5Panels.DownloadApexPanel();
            this.serverListPanel1 = new R5RLauncher.ServerListPanel();
            this.homePanel1 = new R5RLauncher.HomePanel();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R5Logo)).BeginInit();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.SideBar.Controls.Add(this.guna2HtmlLabel1);
            this.SideBar.Controls.Add(this.Patchnotesbtn);
            this.SideBar.Controls.Add(this.Settingsbtn);
            this.SideBar.Controls.Add(this.Downloadapexbtn);
            this.SideBar.Controls.Add(this.Serverlistbtn);
            this.SideBar.Controls.Add(this.R5Text);
            this.SideBar.Controls.Add(this.R5Logo);
            this.SideBar.Controls.Add(this.Homebtn);
            this.guna2Transition1.SetDecoration(this.SideBar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.ShadowDecoration.Parent = this.SideBar;
            this.SideBar.Size = new System.Drawing.Size(179, 496);
            this.SideBar.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Poppins", 7F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 475);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(108, 18);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "R5 Version: placeholder";
            // 
            // Patchnotesbtn
            // 
            this.Patchnotesbtn.CheckedState.Parent = this.Patchnotesbtn;
            this.Patchnotesbtn.CustomImages.Parent = this.Patchnotesbtn;
            this.guna2Transition1.SetDecoration(this.Patchnotesbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Patchnotesbtn.FillColor = System.Drawing.Color.Transparent;
            this.Patchnotesbtn.Font = new System.Drawing.Font("Poppins", 10F);
            this.Patchnotesbtn.ForeColor = System.Drawing.Color.White;
            this.Patchnotesbtn.HoverState.Parent = this.Patchnotesbtn;
            this.Patchnotesbtn.Image = global::R5RLauncher.Properties.Resources.Patch;
            this.Patchnotesbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Patchnotesbtn.ImageOffset = new System.Drawing.Point(0, -1);
            this.Patchnotesbtn.Location = new System.Drawing.Point(0, 204);
            this.Patchnotesbtn.Name = "Patchnotesbtn";
            this.Patchnotesbtn.ShadowDecoration.Parent = this.Patchnotesbtn;
            this.Patchnotesbtn.Size = new System.Drawing.Size(179, 39);
            this.Patchnotesbtn.TabIndex = 8;
            this.Patchnotesbtn.Text = "Patch Notes";
            this.Patchnotesbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Patchnotesbtn.TextOffset = new System.Drawing.Point(0, 2);
            this.Patchnotesbtn.Click += new System.EventHandler(this.Patchnotesbtn_Click);
            // 
            // Settingsbtn
            // 
            this.Settingsbtn.CheckedState.Parent = this.Settingsbtn;
            this.Settingsbtn.CustomImages.Parent = this.Settingsbtn;
            this.guna2Transition1.SetDecoration(this.Settingsbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Settingsbtn.FillColor = System.Drawing.Color.Transparent;
            this.Settingsbtn.Font = new System.Drawing.Font("Poppins", 10F);
            this.Settingsbtn.ForeColor = System.Drawing.Color.White;
            this.Settingsbtn.HoverState.Parent = this.Settingsbtn;
            this.Settingsbtn.Image = global::R5RLauncher.Properties.Resources.Settings;
            this.Settingsbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Settingsbtn.ImageOffset = new System.Drawing.Point(0, -1);
            this.Settingsbtn.Location = new System.Drawing.Point(0, 282);
            this.Settingsbtn.Name = "Settingsbtn";
            this.Settingsbtn.ShadowDecoration.Parent = this.Settingsbtn;
            this.Settingsbtn.Size = new System.Drawing.Size(179, 39);
            this.Settingsbtn.TabIndex = 6;
            this.Settingsbtn.Text = "Settings";
            this.Settingsbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Settingsbtn.TextOffset = new System.Drawing.Point(0, 2);
            this.Settingsbtn.Click += new System.EventHandler(this.Settingsbtn_Click);
            // 
            // Downloadapexbtn
            // 
            this.Downloadapexbtn.CheckedState.Parent = this.Downloadapexbtn;
            this.Downloadapexbtn.CustomImages.Parent = this.Downloadapexbtn;
            this.guna2Transition1.SetDecoration(this.Downloadapexbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Downloadapexbtn.FillColor = System.Drawing.Color.Transparent;
            this.Downloadapexbtn.Font = new System.Drawing.Font("Poppins", 10F);
            this.Downloadapexbtn.ForeColor = System.Drawing.Color.White;
            this.Downloadapexbtn.HoverState.Parent = this.Downloadapexbtn;
            this.Downloadapexbtn.Image = global::R5RLauncher.Properties.Resources.Download;
            this.Downloadapexbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Downloadapexbtn.ImageOffset = new System.Drawing.Point(0, -1);
            this.Downloadapexbtn.Location = new System.Drawing.Point(0, 243);
            this.Downloadapexbtn.Name = "Downloadapexbtn";
            this.Downloadapexbtn.ShadowDecoration.Parent = this.Downloadapexbtn;
            this.Downloadapexbtn.Size = new System.Drawing.Size(179, 39);
            this.Downloadapexbtn.TabIndex = 5;
            this.Downloadapexbtn.Text = "Download Apex";
            this.Downloadapexbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Downloadapexbtn.TextOffset = new System.Drawing.Point(0, 2);
            this.Downloadapexbtn.Click += new System.EventHandler(this.Downloadapexbtn_Click);
            // 
            // Serverlistbtn
            // 
            this.Serverlistbtn.CheckedState.Parent = this.Serverlistbtn;
            this.Serverlistbtn.CustomImages.Parent = this.Serverlistbtn;
            this.guna2Transition1.SetDecoration(this.Serverlistbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Serverlistbtn.FillColor = System.Drawing.Color.Transparent;
            this.Serverlistbtn.Font = new System.Drawing.Font("Poppins", 10F);
            this.Serverlistbtn.ForeColor = System.Drawing.Color.White;
            this.Serverlistbtn.HoverState.Parent = this.Serverlistbtn;
            this.Serverlistbtn.Image = global::R5RLauncher.Properties.Resources.serverlist;
            this.Serverlistbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Serverlistbtn.ImageOffset = new System.Drawing.Point(0, -1);
            this.Serverlistbtn.Location = new System.Drawing.Point(0, 165);
            this.Serverlistbtn.Name = "Serverlistbtn";
            this.Serverlistbtn.ShadowDecoration.Parent = this.Serverlistbtn;
            this.Serverlistbtn.Size = new System.Drawing.Size(179, 39);
            this.Serverlistbtn.TabIndex = 4;
            this.Serverlistbtn.Text = "Server List";
            this.Serverlistbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Serverlistbtn.TextOffset = new System.Drawing.Point(0, 2);
            this.Serverlistbtn.Click += new System.EventHandler(this.Serverlistbtn_Click);
            // 
            // R5Text
            // 
            this.R5Text.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.R5Text, Guna.UI2.AnimatorNS.DecorationType.None);
            this.R5Text.Font = new System.Drawing.Font("Poppins Medium", 15F, System.Drawing.FontStyle.Bold);
            this.R5Text.ForeColor = System.Drawing.Color.White;
            this.R5Text.Location = new System.Drawing.Point(39, 4);
            this.R5Text.Name = "R5Text";
            this.R5Text.Size = new System.Drawing.Size(136, 38);
            this.R5Text.TabIndex = 0;
            this.R5Text.Text = "R5Reloaded";
            // 
            // R5Logo
            // 
            this.guna2Transition1.SetDecoration(this.R5Logo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.R5Logo.Image = ((System.Drawing.Image)(resources.GetObject("R5Logo.Image")));
            this.R5Logo.Location = new System.Drawing.Point(0, 0);
            this.R5Logo.Name = "R5Logo";
            this.R5Logo.ShadowDecoration.Parent = this.R5Logo;
            this.R5Logo.Size = new System.Drawing.Size(41, 42);
            this.R5Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.R5Logo.TabIndex = 3;
            this.R5Logo.TabStop = false;
            // 
            // Homebtn
            // 
            this.Homebtn.CheckedState.Parent = this.Homebtn;
            this.Homebtn.CustomImages.Parent = this.Homebtn;
            this.guna2Transition1.SetDecoration(this.Homebtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Homebtn.FillColor = System.Drawing.Color.Transparent;
            this.Homebtn.Font = new System.Drawing.Font("Poppins", 10F);
            this.Homebtn.ForeColor = System.Drawing.Color.White;
            this.Homebtn.HoverState.Parent = this.Homebtn;
            this.Homebtn.Image = global::R5RLauncher.Properties.Resources.Home;
            this.Homebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Homebtn.ImageOffset = new System.Drawing.Point(0, -1);
            this.Homebtn.Location = new System.Drawing.Point(0, 126);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.ShadowDecoration.Parent = this.Homebtn;
            this.Homebtn.Size = new System.Drawing.Size(179, 39);
            this.Homebtn.TabIndex = 0;
            this.Homebtn.Text = "Home";
            this.Homebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Homebtn.TextOffset = new System.Drawing.Point(0, 2);
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.TopBar.Controls.Add(this.BreadCrum);
            this.TopBar.Controls.Add(this.guna2ControlBox2);
            this.TopBar.Controls.Add(this.guna2ControlBox1);
            this.guna2Transition1.SetDecoration(this.TopBar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(179, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.ShadowDecoration.Parent = this.TopBar;
            this.TopBar.Size = new System.Drawing.Size(778, 42);
            this.TopBar.TabIndex = 1;
            // 
            // BreadCrum
            // 
            this.BreadCrum.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.BreadCrum, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BreadCrum.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreadCrum.ForeColor = System.Drawing.Color.White;
            this.BreadCrum.Location = new System.Drawing.Point(6, 9);
            this.BreadCrum.Name = "BreadCrum";
            this.BreadCrum.Size = new System.Drawing.Size(105, 24);
            this.BreadCrum.TabIndex = 2;
            this.BreadCrum.Text = "Launcher > Home";
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2Transition1.SetDecoration(this.guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(688, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 42);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Transition1.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(733, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 42);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.TopBar;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.guna2Transition1.DefaultAnimation = animation2;
            this.guna2Transition1.TimeStep = 0.05F;
            // 
            // settingsPanel1
            // 
            this.settingsPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.guna2Transition1.SetDecoration(this.settingsPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.settingsPanel1.Location = new System.Drawing.Point(644, 48);
            this.settingsPanel1.Name = "settingsPanel1";
            this.settingsPanel1.Size = new System.Drawing.Size(65, 48);
            this.settingsPanel1.TabIndex = 7;
            // 
            // patchPanel1
            // 
            this.patchPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.guna2Transition1.SetDecoration(this.patchPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.patchPanel1.Location = new System.Drawing.Point(582, 48);
            this.patchPanel1.Name = "patchPanel1";
            this.patchPanel1.Size = new System.Drawing.Size(56, 48);
            this.patchPanel1.TabIndex = 6;
            // 
            // downloadApexPanel1
            // 
            this.downloadApexPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.guna2Transition1.SetDecoration(this.downloadApexPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.downloadApexPanel1.Location = new System.Drawing.Point(513, 48);
            this.downloadApexPanel1.Name = "downloadApexPanel1";
            this.downloadApexPanel1.Size = new System.Drawing.Size(63, 48);
            this.downloadApexPanel1.TabIndex = 5;
            // 
            // serverListPanel1
            // 
            this.serverListPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.guna2Transition1.SetDecoration(this.serverListPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.serverListPanel1.Location = new System.Drawing.Point(185, 43);
            this.serverListPanel1.Name = "serverListPanel1";
            this.serverListPanel1.Size = new System.Drawing.Size(775, 454);
            this.serverListPanel1.TabIndex = 3;
            // 
            // homePanel1
            // 
            this.homePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.guna2Transition1.SetDecoration(this.homePanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.homePanel1.Location = new System.Drawing.Point(191, 43);
            this.homePanel1.Name = "homePanel1";
            this.homePanel1.Size = new System.Drawing.Size(766, 453);
            this.homePanel1.TabIndex = 2;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(957, 496);
            this.Controls.Add(this.settingsPanel1);
            this.Controls.Add(this.patchPanel1);
            this.Controls.Add(this.downloadApexPanel1);
            this.Controls.Add(this.serverListPanel1);
            this.Controls.Add(this.homePanel1);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.SideBar);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Launcher";
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R5Logo)).EndInit();
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel SideBar;
        private Guna.UI2.WinForms.Guna2Panel TopBar;
        private Guna.UI2.WinForms.Guna2Button Homebtn;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox R5Logo;
        private Guna.UI2.WinForms.Guna2HtmlLabel R5Text;
        private Guna.UI2.WinForms.Guna2Button Settingsbtn;
        private Guna.UI2.WinForms.Guna2Button Downloadapexbtn;
        private Guna.UI2.WinForms.Guna2Button Serverlistbtn;
        private Guna.UI2.WinForms.Guna2Button Patchnotesbtn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private HomePanel homePanel1;
        private ServerListPanel serverListPanel1;
        private R5Panels.SettingsPanel settingsPanel1;
        private R5Panels.PatchPanel patchPanel1;
        private R5Panels.DownloadApexPanel downloadApexPanel1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2HtmlLabel BreadCrum;
    }
}