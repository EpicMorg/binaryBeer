namespace BinaryBeer
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStats = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.FrmAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(395, 12);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(128, 40);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Новая игра";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStats
            // 
            this.BtnStats.Location = new System.Drawing.Point(395, 58);
            this.BtnStats.Name = "BtnStats";
            this.BtnStats.Size = new System.Drawing.Size(128, 40);
            this.BtnStats.TabIndex = 0;
            this.BtnStats.Text = "Статистика";
            this.BtnStats.UseVisualStyleBackColor = true;
            this.BtnStats.Click += new System.EventHandler(this.BtnStats_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(12, 285);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(128, 40);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Выход";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmAbout
            // 
            this.FrmAbout.Location = new System.Drawing.Point(395, 285);
            this.FrmAbout.Name = "FrmAbout";
            this.FrmAbout.Size = new System.Drawing.Size(128, 40);
            this.FrmAbout.TabIndex = 0;
            this.FrmAbout.Text = "О программе";
            this.FrmAbout.UseVisualStyleBackColor = true;
            this.FrmAbout.Click += new System.EventHandler(this.FrmAbout_Click);
            // 
            // FrmMain
            // 
            this.AcceptButton = this.BtnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BinaryBeer.Properties.Resources._31568583_2c303a8655d967dbf0368534091cfe9c_800;
            this.ClientSize = new System.Drawing.Size(535, 337);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.FrmAbout);
            this.Controls.Add(this.BtnStats);
            this.Controls.Add(this.BtnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BinaryBeer :: Главная";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStats;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button FrmAbout;
    }
}