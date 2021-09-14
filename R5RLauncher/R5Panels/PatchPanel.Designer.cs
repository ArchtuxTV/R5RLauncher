
namespace R5RLauncher.R5Panels
{
    partial class PatchPanel
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PatchNotes = new System.Windows.Forms.RichTextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.guna2Panel2.BorderRadius = 2;
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.guna2Panel2.Location = new System.Drawing.Point(15, 17);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(734, 45);
            this.guna2Panel2.TabIndex = 6;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Poppins", 15F);
            this.guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(6, 4);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(253, 38);
            this.guna2HtmlLabel6.TabIndex = 3;
            this.guna2HtmlLabel6.Text = "R5 Reloaded Patch Notes";
            this.guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PatchNotes
            // 
            this.PatchNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.PatchNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatchNotes.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatchNotes.ForeColor = System.Drawing.Color.White;
            this.PatchNotes.Location = new System.Drawing.Point(3, 3);
            this.PatchNotes.Name = "PatchNotes";
            this.PatchNotes.ReadOnly = true;
            this.PatchNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.PatchNotes.Size = new System.Drawing.Size(728, 331);
            this.PatchNotes.TabIndex = 7;
            this.PatchNotes.Text = "";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.guna2Panel1.BorderRadius = 2;
            this.guna2Panel1.Controls.Add(this.PatchNotes);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.guna2Panel1.Location = new System.Drawing.Point(15, 68);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(734, 370);
            this.guna2Panel1.TabIndex = 7;
            // 
            // PatchPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "PatchPanel";
            this.Size = new System.Drawing.Size(775, 454);
            this.Load += new System.EventHandler(this.PatchPanel_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private System.Windows.Forms.RichTextBox PatchNotes;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
