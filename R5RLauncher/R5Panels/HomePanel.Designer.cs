
namespace R5RLauncher
{
    partial class HomePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePanel));
            this.LaunchGamebtn = new Guna.UI2.WinForms.Guna2Button();
            this.MapBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GamemodeBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ServerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.ServerPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.Publicbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Privatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CreateServerbtn = new Guna.UI2.WinForms.Guna2Button();
            this.MainHomePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ServerCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CreateServerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.createserverbackbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CServerbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.ServerCountTimer = new System.Windows.Forms.Timer(this.components);
            this.WatchApex = new System.Windows.Forms.Timer(this.components);
            this.RegenKey = new Guna.UI2.WinForms.Guna2Button();
            this.Mappic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.R5Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TopPanel.SuspendLayout();
            this.MainHomePanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.CreateServerPanel.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mappic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R5Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // LaunchGamebtn
            // 
            this.LaunchGamebtn.Animated = true;
            this.LaunchGamebtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.LaunchGamebtn.BorderRadius = 2;
            this.LaunchGamebtn.CheckedState.Parent = this.LaunchGamebtn;
            this.LaunchGamebtn.CustomImages.Parent = this.LaunchGamebtn;
            this.guna2Transition1.SetDecoration(this.LaunchGamebtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LaunchGamebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.LaunchGamebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LaunchGamebtn.ForeColor = System.Drawing.Color.White;
            this.LaunchGamebtn.HoverState.Parent = this.LaunchGamebtn;
            this.LaunchGamebtn.Location = new System.Drawing.Point(385, 394);
            this.LaunchGamebtn.Name = "LaunchGamebtn";
            this.LaunchGamebtn.ShadowDecoration.Parent = this.LaunchGamebtn;
            this.LaunchGamebtn.Size = new System.Drawing.Size(361, 45);
            this.LaunchGamebtn.TabIndex = 1;
            this.LaunchGamebtn.Text = "Launch Game";
            this.LaunchGamebtn.Click += new System.EventHandler(this.LaunchGamebtn_Click);
            // 
            // MapBox
            // 
            this.MapBox.Animated = true;
            this.MapBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.MapBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.guna2Transition1.SetDecoration(this.MapBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MapBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MapBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MapBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.MapBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.MapBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.MapBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.MapBox.FocusedState.ForeColor = System.Drawing.Color.White;
            this.MapBox.FocusedState.Parent = this.MapBox;
            this.MapBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MapBox.ForeColor = System.Drawing.Color.White;
            this.MapBox.FormattingEnabled = true;
            this.MapBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.MapBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.MapBox.HoverState.ForeColor = System.Drawing.Color.White;
            this.MapBox.HoverState.Parent = this.MapBox;
            this.MapBox.ItemHeight = 30;
            this.MapBox.Items.AddRange(new object[] {
            "King\'s Canyon Season 1",
            "King\'s Canyon Season 2",
            "King\'s Canyon After Dark",
            "World\'s Edge",
            "World\'s Edge After Dark",
            "Firing Range"});
            this.MapBox.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.MapBox.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.MapBox.ItemsAppearance.Parent = this.MapBox;
            this.MapBox.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.MapBox.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.MapBox.Location = new System.Drawing.Point(429, 48);
            this.MapBox.Name = "MapBox";
            this.MapBox.ShadowDecoration.Parent = this.MapBox;
            this.MapBox.Size = new System.Drawing.Size(292, 36);
            this.MapBox.StartIndex = 0;
            this.MapBox.TabIndex = 2;
            this.MapBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MapBox.SelectedIndexChanged += new System.EventHandler(this.MapBox_SelectedIndexChanged);
            // 
            // GamemodeBox
            // 
            this.GamemodeBox.Animated = true;
            this.GamemodeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.GamemodeBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.guna2Transition1.SetDecoration(this.GamemodeBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.GamemodeBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GamemodeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GamemodeBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.GamemodeBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.GamemodeBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.GamemodeBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.GamemodeBox.FocusedState.ForeColor = System.Drawing.Color.White;
            this.GamemodeBox.FocusedState.Parent = this.GamemodeBox;
            this.GamemodeBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GamemodeBox.ForeColor = System.Drawing.Color.White;
            this.GamemodeBox.FormattingEnabled = true;
            this.GamemodeBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.GamemodeBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.GamemodeBox.HoverState.ForeColor = System.Drawing.Color.White;
            this.GamemodeBox.HoverState.Parent = this.GamemodeBox;
            this.GamemodeBox.ItemHeight = 30;
            this.GamemodeBox.Items.AddRange(new object[] {
            "custom_tdm",
            "custom_tdm_tps",
            "survival_staging_baseline",
            "survival_training",
            "survival_firingrange",
            "survival",
            "survival_dev",
            "defaults",
            "dev_default",
            "duos"});
            this.GamemodeBox.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.GamemodeBox.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.GamemodeBox.ItemsAppearance.Parent = this.GamemodeBox;
            this.GamemodeBox.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.GamemodeBox.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.GamemodeBox.Location = new System.Drawing.Point(429, 90);
            this.GamemodeBox.Name = "GamemodeBox";
            this.GamemodeBox.ShadowDecoration.Parent = this.GamemodeBox;
            this.GamemodeBox.Size = new System.Drawing.Size(292, 36);
            this.GamemodeBox.StartIndex = 0;
            this.GamemodeBox.TabIndex = 4;
            this.GamemodeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.TopPanel.BorderRadius = 2;
            this.TopPanel.Controls.Add(this.RegenKey);
            this.TopPanel.Controls.Add(this.guna2HtmlLabel2);
            this.TopPanel.Controls.Add(this.guna2HtmlLabel1);
            this.TopPanel.Controls.Add(this.ServerName);
            this.TopPanel.Controls.Add(this.ServerPassword);
            this.TopPanel.Controls.Add(this.Publicbtn);
            this.TopPanel.Controls.Add(this.Privatebtn);
            this.TopPanel.Controls.Add(this.guna2HtmlLabel10);
            this.TopPanel.Controls.Add(this.guna2HtmlLabel8);
            this.TopPanel.Controls.Add(this.Mappic);
            this.TopPanel.Controls.Add(this.MapBox);
            this.TopPanel.Controls.Add(this.GamemodeBox);
            this.guna2Transition1.SetDecoration(this.TopPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TopPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.TopPanel.Location = new System.Drawing.Point(18, 120);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.ShadowDecoration.Parent = this.TopPanel;
            this.TopPanel.Size = new System.Drawing.Size(728, 213);
            this.TopPanel.TabIndex = 6;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Poppins", 10F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(339, 176);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(55, 25);
            this.guna2HtmlLabel2.TabIndex = 24;
            this.guna2HtmlLabel2.Text = "Enc Key:";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Poppins", 10F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(339, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(89, 25);
            this.guna2HtmlLabel1.TabIndex = 23;
            this.guna2HtmlLabel1.Text = "Server Name:";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServerName
            // 
            this.ServerName.Animated = true;
            this.ServerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.ServerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.ServerName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ServerName.DefaultText = "";
            this.ServerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerName.DisabledState.Parent = this.ServerName;
            this.ServerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.ServerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServerName.FocusedState.Parent = this.ServerName;
            this.ServerName.ForeColor = System.Drawing.Color.White;
            this.ServerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServerName.HoverState.Parent = this.ServerName;
            this.ServerName.Location = new System.Drawing.Point(429, 6);
            this.ServerName.Name = "ServerName";
            this.ServerName.PasswordChar = '\0';
            this.ServerName.PlaceholderText = "Server Name";
            this.ServerName.SelectedText = "";
            this.ServerName.ShadowDecoration.Parent = this.ServerName;
            this.ServerName.Size = new System.Drawing.Size(292, 36);
            this.ServerName.TabIndex = 22;
            this.ServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ServerPassword
            // 
            this.ServerPassword.Animated = true;
            this.ServerPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.ServerPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.ServerPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ServerPassword.DefaultText = "";
            this.ServerPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.ServerPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.ServerPassword.DisabledState.ForeColor = System.Drawing.Color.White;
            this.ServerPassword.DisabledState.Parent = this.ServerPassword;
            this.ServerPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.ServerPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.ServerPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServerPassword.FocusedState.Parent = this.ServerPassword;
            this.ServerPassword.ForeColor = System.Drawing.Color.White;
            this.ServerPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServerPassword.HoverState.Parent = this.ServerPassword;
            this.ServerPassword.Location = new System.Drawing.Point(429, 171);
            this.ServerPassword.Name = "ServerPassword";
            this.ServerPassword.PasswordChar = '\0';
            this.ServerPassword.PlaceholderText = "Server Password";
            this.ServerPassword.SelectedText = "";
            this.ServerPassword.ShadowDecoration.Parent = this.ServerPassword;
            this.ServerPassword.Size = new System.Drawing.Size(250, 36);
            this.ServerPassword.TabIndex = 21;
            this.ServerPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Publicbtn
            // 
            this.Publicbtn.Animated = true;
            this.Publicbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.Publicbtn.BorderRadius = 2;
            this.Publicbtn.Checked = true;
            this.Publicbtn.CheckedState.Parent = this.Publicbtn;
            this.Publicbtn.CustomImages.Parent = this.Publicbtn;
            this.guna2Transition1.SetDecoration(this.Publicbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Publicbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.Publicbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Publicbtn.ForeColor = System.Drawing.Color.White;
            this.Publicbtn.HoverState.Parent = this.Publicbtn;
            this.Publicbtn.Location = new System.Drawing.Point(339, 132);
            this.Publicbtn.Name = "Publicbtn";
            this.Publicbtn.ShadowDecoration.Parent = this.Publicbtn;
            this.Publicbtn.Size = new System.Drawing.Size(188, 33);
            this.Publicbtn.TabIndex = 19;
            this.Publicbtn.Text = "Public";
            this.Publicbtn.Click += new System.EventHandler(this.Publicbtn_Click);
            // 
            // Privatebtn
            // 
            this.Privatebtn.Animated = true;
            this.Privatebtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.Privatebtn.BorderRadius = 2;
            this.Privatebtn.CheckedState.Parent = this.Privatebtn;
            this.Privatebtn.CustomImages.Parent = this.Privatebtn;
            this.guna2Transition1.SetDecoration(this.Privatebtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Privatebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.Privatebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Privatebtn.ForeColor = System.Drawing.Color.White;
            this.Privatebtn.HoverState.Parent = this.Privatebtn;
            this.Privatebtn.Location = new System.Drawing.Point(533, 132);
            this.Privatebtn.Name = "Privatebtn";
            this.Privatebtn.ShadowDecoration.Parent = this.Privatebtn;
            this.Privatebtn.Size = new System.Drawing.Size(188, 33);
            this.Privatebtn.TabIndex = 13;
            this.Privatebtn.Text = "Private";
            this.Privatebtn.Click += new System.EventHandler(this.Privatebtn_Click);
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Poppins", 10F);
            this.guna2HtmlLabel10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(339, 54);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(79, 25);
            this.guna2HtmlLabel10.TabIndex = 18;
            this.guna2HtmlLabel10.Text = "Server Map:";
            this.guna2HtmlLabel10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Poppins", 10F);
            this.guna2HtmlLabel8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(339, 96);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(84, 25);
            this.guna2HtmlLabel8.TabIndex = 16;
            this.guna2HtmlLabel8.Text = "Gamemode:";
            this.guna2HtmlLabel8.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CreateServerbtn
            // 
            this.CreateServerbtn.Animated = true;
            this.CreateServerbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.CreateServerbtn.BorderRadius = 2;
            this.CreateServerbtn.CheckedState.Parent = this.CreateServerbtn;
            this.CreateServerbtn.CustomImages.Parent = this.CreateServerbtn;
            this.guna2Transition1.SetDecoration(this.CreateServerbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CreateServerbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.CreateServerbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CreateServerbtn.ForeColor = System.Drawing.Color.White;
            this.CreateServerbtn.HoverState.Parent = this.CreateServerbtn;
            this.CreateServerbtn.Location = new System.Drawing.Point(18, 394);
            this.CreateServerbtn.Name = "CreateServerbtn";
            this.CreateServerbtn.ShadowDecoration.Parent = this.CreateServerbtn;
            this.CreateServerbtn.Size = new System.Drawing.Size(361, 45);
            this.CreateServerbtn.TabIndex = 7;
            this.CreateServerbtn.Text = "Create Server";
            this.CreateServerbtn.Click += new System.EventHandler(this.CreateServerbtn_Click);
            // 
            // MainHomePanel
            // 
            this.MainHomePanel.Controls.Add(this.guna2Panel1);
            this.MainHomePanel.Controls.Add(this.guna2HtmlLabel3);
            this.MainHomePanel.Controls.Add(this.R5Logo);
            this.MainHomePanel.Controls.Add(this.guna2HtmlLabel4);
            this.MainHomePanel.Controls.Add(this.LaunchGamebtn);
            this.MainHomePanel.Controls.Add(this.CreateServerbtn);
            this.guna2Transition1.SetDecoration(this.MainHomePanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MainHomePanel.Location = new System.Drawing.Point(0, 0);
            this.MainHomePanel.Name = "MainHomePanel";
            this.MainHomePanel.ShadowDecoration.Parent = this.MainHomePanel;
            this.MainHomePanel.Size = new System.Drawing.Size(775, 454);
            this.MainHomePanel.TabIndex = 8;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.guna2Panel1.BorderRadius = 2;
            this.guna2Panel1.Controls.Add(this.ServerCount);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.guna2Panel1.Location = new System.Drawing.Point(607, 17);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(139, 31);
            this.guna2Panel1.TabIndex = 14;
            // 
            // ServerCount
            // 
            this.ServerCount.AutoSize = false;
            this.ServerCount.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.ServerCount, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ServerCount.Font = new System.Drawing.Font("Poppins", 10F);
            this.ServerCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ServerCount.Location = new System.Drawing.Point(3, 4);
            this.ServerCount.Name = "ServerCount";
            this.ServerCount.Size = new System.Drawing.Size(133, 25);
            this.ServerCount.TabIndex = 3;
            this.ServerCount.Text = "Server Count:";
            this.ServerCount.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Poppins", 35F);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(88, 78);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(300, 84);
            this.guna2HtmlLabel3.TabIndex = 10;
            this.guna2HtmlLabel3.Text = "R5 Reloaded";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Poppins", 35F);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(18, 17);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(294, 84);
            this.guna2HtmlLabel4.TabIndex = 8;
            this.guna2HtmlLabel4.Text = "Welcome To";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CreateServerPanel
            // 
            this.CreateServerPanel.Controls.Add(this.createserverbackbtn);
            this.CreateServerPanel.Controls.Add(this.guna2Panel3);
            this.CreateServerPanel.Controls.Add(this.CServerbtn);
            this.CreateServerPanel.Controls.Add(this.TopPanel);
            this.guna2Transition1.SetDecoration(this.CreateServerPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CreateServerPanel.Location = new System.Drawing.Point(0, 460);
            this.CreateServerPanel.Name = "CreateServerPanel";
            this.CreateServerPanel.ShadowDecoration.Parent = this.CreateServerPanel;
            this.CreateServerPanel.Size = new System.Drawing.Size(775, 454);
            this.CreateServerPanel.TabIndex = 11;
            // 
            // createserverbackbtn
            // 
            this.createserverbackbtn.Animated = true;
            this.createserverbackbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.createserverbackbtn.BorderRadius = 2;
            this.createserverbackbtn.CheckedState.Parent = this.createserverbackbtn;
            this.createserverbackbtn.CustomImages.Parent = this.createserverbackbtn;
            this.guna2Transition1.SetDecoration(this.createserverbackbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.createserverbackbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.createserverbackbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createserverbackbtn.ForeColor = System.Drawing.Color.White;
            this.createserverbackbtn.HoverState.Parent = this.createserverbackbtn;
            this.createserverbackbtn.Location = new System.Drawing.Point(607, 17);
            this.createserverbackbtn.Name = "createserverbackbtn";
            this.createserverbackbtn.ShadowDecoration.Parent = this.createserverbackbtn;
            this.createserverbackbtn.Size = new System.Drawing.Size(139, 45);
            this.createserverbackbtn.TabIndex = 12;
            this.createserverbackbtn.Text = "Back";
            this.createserverbackbtn.Click += new System.EventHandler(this.createserverbackbtn_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.guna2Panel3.BorderRadius = 2;
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Transition1.SetDecoration(this.guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.guna2Panel3.Location = new System.Drawing.Point(18, 17);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(583, 45);
            this.guna2Panel3.TabIndex = 13;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Poppins", 15F);
            this.guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(6, 4);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(136, 38);
            this.guna2HtmlLabel6.TabIndex = 3;
            this.guna2HtmlLabel6.Text = "Create Server";
            this.guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CServerbtn
            // 
            this.CServerbtn.Animated = true;
            this.CServerbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.CServerbtn.BorderRadius = 2;
            this.CServerbtn.CheckedState.Parent = this.CServerbtn;
            this.CServerbtn.CustomImages.Parent = this.CServerbtn;
            this.guna2Transition1.SetDecoration(this.CServerbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CServerbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.CServerbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CServerbtn.ForeColor = System.Drawing.Color.White;
            this.CServerbtn.HoverState.Parent = this.CServerbtn;
            this.CServerbtn.Location = new System.Drawing.Point(18, 394);
            this.CServerbtn.Name = "CServerbtn";
            this.CServerbtn.ShadowDecoration.Parent = this.CServerbtn;
            this.CServerbtn.Size = new System.Drawing.Size(728, 45);
            this.CServerbtn.TabIndex = 11;
            this.CServerbtn.Text = " Launch Game And Create Server";
            this.CServerbtn.Click += new System.EventHandler(this.CServerbtn_Click);
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
            // ServerCountTimer
            // 
            this.ServerCountTimer.Enabled = true;
            this.ServerCountTimer.Interval = 30000;
            this.ServerCountTimer.Tick += new System.EventHandler(this.ServerCountTimer_Tick);
            // 
            // WatchApex
            // 
            this.WatchApex.Interval = 500;
            this.WatchApex.Tick += new System.EventHandler(this.WatchApex_Tick);
            // 
            // RegenKey
            // 
            this.RegenKey.Animated = true;
            this.RegenKey.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.RegenKey.BorderRadius = 2;
            this.RegenKey.CheckedState.Parent = this.RegenKey;
            this.RegenKey.CustomImages.Parent = this.RegenKey;
            this.guna2Transition1.SetDecoration(this.RegenKey, Guna.UI2.AnimatorNS.DecorationType.None);
            this.RegenKey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.RegenKey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RegenKey.ForeColor = System.Drawing.Color.White;
            this.RegenKey.HoverState.Parent = this.RegenKey;
            this.RegenKey.Image = global::R5RLauncher.Properties.Resources.icons8_update_96;
            this.RegenKey.Location = new System.Drawing.Point(685, 171);
            this.RegenKey.Name = "RegenKey";
            this.RegenKey.ShadowDecoration.Parent = this.RegenKey;
            this.RegenKey.Size = new System.Drawing.Size(36, 36);
            this.RegenKey.TabIndex = 25;
            this.RegenKey.Click += new System.EventHandler(this.RegenKey_Click);
            // 
            // Mappic
            // 
            this.guna2Transition1.SetDecoration(this.Mappic, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Mappic.Image = global::R5RLauncher.Properties.Resources.KCS1;
            this.Mappic.Location = new System.Drawing.Point(6, 6);
            this.Mappic.Name = "Mappic";
            this.Mappic.ShadowDecoration.Parent = this.Mappic;
            this.Mappic.Size = new System.Drawing.Size(327, 201);
            this.Mappic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mappic.TabIndex = 6;
            this.Mappic.TabStop = false;
            // 
            // R5Logo
            // 
            this.guna2Transition1.SetDecoration(this.R5Logo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.R5Logo.Image = ((System.Drawing.Image)(resources.GetObject("R5Logo.Image")));
            this.R5Logo.Location = new System.Drawing.Point(18, 78);
            this.R5Logo.Name = "R5Logo";
            this.R5Logo.ShadowDecoration.Parent = this.R5Logo;
            this.R5Logo.Size = new System.Drawing.Size(78, 76);
            this.R5Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.R5Logo.TabIndex = 9;
            this.R5Logo.TabStop = false;
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.CreateServerPanel);
            this.Controls.Add(this.MainHomePanel);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Name = "HomePanel";
            this.Size = new System.Drawing.Size(784, 918);
            this.Load += new System.EventHandler(this.HomePanel_Load);
            this.VisibleChanged += new System.EventHandler(this.HomePanel_VisibleChanged);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MainHomePanel.ResumeLayout(false);
            this.MainHomePanel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.CreateServerPanel.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mappic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R5Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button LaunchGamebtn;
        private Guna.UI2.WinForms.Guna2ComboBox MapBox;
        private Guna.UI2.WinForms.Guna2ComboBox GamemodeBox;
        private Guna.UI2.WinForms.Guna2Panel TopPanel;
        private Guna.UI2.WinForms.Guna2Button CreateServerbtn;
        private Guna.UI2.WinForms.Guna2Panel MainHomePanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2PictureBox R5Logo;
        private Guna.UI2.WinForms.Guna2Panel CreateServerPanel;
        private Guna.UI2.WinForms.Guna2Button CServerbtn;
        private Guna.UI2.WinForms.Guna2PictureBox Mappic;
        private Guna.UI2.WinForms.Guna2TextBox ServerPassword;
        private Guna.UI2.WinForms.Guna2Button Publicbtn;
        private Guna.UI2.WinForms.Guna2Button Privatebtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2TextBox ServerName;
        private Guna.UI2.WinForms.Guna2Button createserverbackbtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel ServerCount;
        private System.Windows.Forms.Timer ServerCountTimer;
        private System.Windows.Forms.Timer WatchApex;
        private Guna.UI2.WinForms.Guna2Button RegenKey;
    }
}
