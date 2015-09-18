using System.ComponentModel;
using System.Windows.Forms;

namespace BinaryBeer
{
    partial class FrmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmGame));
            this.grp_info = new GroupBox();
            this.pct_av = new PictureBoxEx();
            this.lbl_lvl = new Label();
            this.lbl_lbl_lbl = new Label();
            this.lbl_name = new Label();
            this.grp_0_0 = new GroupBoxEx();
            this.pct_0_0_1 = new PictureBoxEx();
            this.pct_0_0_0 = new PictureBoxEx();
            this.grp_wnr_0 = new GroupBoxEx();
            this.pct_wnr_0 = new PictureBoxEx();
            this.tbc = new TabControl();
            this.tb_def = new TabPage();
            this.grp_0_3 = new GroupBoxEx();
            this.pct_0_3_1 = new PictureBoxEx();
            this.pct_0_3_0 = new PictureBoxEx();
            this.grp_1_1 = new GroupBoxEx();
            this.pct_1_1_1 = new PictureBoxEx();
            this.pct_1_1_0 = new PictureBoxEx();
            this.grp_0_2 = new GroupBoxEx();
            this.pct_0_2_1 = new PictureBoxEx();
            this.pct_0_2_0 = new PictureBoxEx();
            this.grp_2_0 = new GroupBoxEx();
            this.pct_2_0_1 = new PictureBoxEx();
            this.pct_2_0_0 = new PictureBoxEx();
            this.grp_1_0 = new GroupBoxEx();
            this.pct_1_0_1 = new PictureBoxEx();
            this.pct_1_0_0 = new PictureBoxEx();
            this.grp_0_1 = new GroupBoxEx();
            this.pct_0_1_1 = new PictureBoxEx();
            this.pct_0_1_0 = new PictureBoxEx();
            this.tb_sel = new TabPage();
            this.btn_win = new Button();
            this.grp_w0_1 = new GroupBoxEx();
            this.pct_w0_1_1 = new PictureBoxEx();
            this.pct_w0_1_0 = new PictureBoxEx();
            this.grp_w1_0 = new GroupBoxEx();
            this.pct_w1_0_1 = new PictureBoxEx();
            this.pct_w1_0_0 = new PictureBoxEx();
            this.grp_w0_0 = new GroupBoxEx();
            this.pct_w0_0_1 = new PictureBoxEx();
            this.pct_w0_0_0 = new PictureBoxEx();
            this.grp_ww = new GroupBoxEx();
            this.pct_ww = new PictureBoxEx();
            this.grp_info.SuspendLayout();
            ((ISupportInitialize)(this.pct_av)).BeginInit();
            this.grp_0_0.SuspendLayout();
            ((ISupportInitialize)(this.pct_0_0_1)).BeginInit();
            ((ISupportInitialize)(this.pct_0_0_0)).BeginInit();
            this.grp_wnr_0.SuspendLayout();
            ((ISupportInitialize)(this.pct_wnr_0)).BeginInit();
            this.tbc.SuspendLayout();
            this.tb_def.SuspendLayout();
            this.grp_0_3.SuspendLayout();
            ((ISupportInitialize)(this.pct_0_3_1)).BeginInit();
            ((ISupportInitialize)(this.pct_0_3_0)).BeginInit();
            this.grp_1_1.SuspendLayout();
            ((ISupportInitialize)(this.pct_1_1_1)).BeginInit();
            ((ISupportInitialize)(this.pct_1_1_0)).BeginInit();
            this.grp_0_2.SuspendLayout();
            ((ISupportInitialize)(this.pct_0_2_1)).BeginInit();
            ((ISupportInitialize)(this.pct_0_2_0)).BeginInit();
            this.grp_2_0.SuspendLayout();
            ((ISupportInitialize)(this.pct_2_0_1)).BeginInit();
            ((ISupportInitialize)(this.pct_2_0_0)).BeginInit();
            this.grp_1_0.SuspendLayout();
            ((ISupportInitialize)(this.pct_1_0_1)).BeginInit();
            ((ISupportInitialize)(this.pct_1_0_0)).BeginInit();
            this.grp_0_1.SuspendLayout();
            ((ISupportInitialize)(this.pct_0_1_1)).BeginInit();
            ((ISupportInitialize)(this.pct_0_1_0)).BeginInit();
            this.tb_sel.SuspendLayout();
            this.grp_w0_1.SuspendLayout();
            ((ISupportInitialize)(this.pct_w0_1_1)).BeginInit();
            ((ISupportInitialize)(this.pct_w0_1_0)).BeginInit();
            this.grp_w1_0.SuspendLayout();
            ((ISupportInitialize)(this.pct_w1_0_1)).BeginInit();
            ((ISupportInitialize)(this.pct_w1_0_0)).BeginInit();
            this.grp_w0_0.SuspendLayout();
            ((ISupportInitialize)(this.pct_w0_0_1)).BeginInit();
            ((ISupportInitialize)(this.pct_w0_0_0)).BeginInit();
            this.grp_ww.SuspendLayout();
            ((ISupportInitialize)(this.pct_ww)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_info
            // 
            this.grp_info.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.grp_info.Controls.Add(this.pct_av);
            this.grp_info.Controls.Add(this.lbl_lvl);
            this.grp_info.Controls.Add(this.lbl_lbl_lbl);
            this.grp_info.Controls.Add(this.lbl_name);
            this.grp_info.Location = new System.Drawing.Point(756, 12);
            this.grp_info.Name = "grp_info";
            this.grp_info.Size = new System.Drawing.Size(141, 206);
            this.grp_info.TabIndex = 0;
            this.grp_info.TabStop = false;
            this.grp_info.Text = "Данные:";
            // 
            // pct_av
            // 
            this.pct_av.Beer = null;
            this.pct_av.Image = Properties.Resources._123asd;
            this.pct_av.Location = new System.Drawing.Point(9, 19);
            this.pct_av.Name = "pct_av";
            this.pct_av.Size = new System.Drawing.Size(126, 135);
            this.pct_av.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_av.TabIndex = 1;
            this.pct_av.TabStop = false;
            // 
            // lbl_lvl
            // 
            this.lbl_lvl.AutoSize = true;
            this.lbl_lvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_lvl.Location = new System.Drawing.Point(120, 185);
            this.lbl_lvl.Name = "lbl_lvl";
            this.lbl_lvl.Size = new System.Drawing.Size(15, 15);
            this.lbl_lvl.TabIndex = 0;
            this.lbl_lvl.Text = "1";
            // 
            // lbl_lbl_lbl
            // 
            this.lbl_lbl_lbl.AutoSize = true;
            this.lbl_lbl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_lbl_lbl.Location = new System.Drawing.Point(6, 185);
            this.lbl_lbl_lbl.Name = "lbl_lbl_lbl";
            this.lbl_lbl_lbl.Size = new System.Drawing.Size(68, 15);
            this.lbl_lbl_lbl.TabIndex = 0;
            this.lbl_lbl_lbl.Text = "Уровень:";
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_name.Location = new System.Drawing.Point(6, 157);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(129, 19);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Дмитрий Иванов";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_0_0
            // 
            this.grp_0_0.Controls.Add(this.pct_0_0_1);
            this.grp_0_0.Controls.Add(this.pct_0_0_0);
            this.grp_0_0.Location = new System.Drawing.Point(16, 398);
            this.grp_0_0.Name = "grp_0_0";
            this.grp_0_0.Size = new System.Drawing.Size(170, 102);
            this.grp_0_0.TabIndex = 1;
            this.grp_0_0.TabStop = false;
            // 
            // pct_0_0_1
            // 
            this.pct_0_0_1.BackColor = System.Drawing.Color.White;
            this.pct_0_0_1.BackgroundImage = Properties.Resources._123asd;
            this.pct_0_0_1.BackgroundImageLayout = ImageLayout.Center;
            this.pct_0_0_1.Beer = null;
            this.pct_0_0_1.Cursor = Cursors.Hand;
            this.pct_0_0_1.Image = Properties.Resources.bad;
            this.pct_0_0_1.Location = new System.Drawing.Point(87, 17);
            this.pct_0_0_1.Name = "pct_0_0_1";
            this.pct_0_0_1.Size = new System.Drawing.Size(75, 75);
            this.pct_0_0_1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_0_0_1.TabIndex = 1;
            this.pct_0_0_1.TabStop = false;
            this.pct_0_0_1.Click += new System.EventHandler(this.BottomClick);
            // 
            // pct_0_0_0
            // 
            this.pct_0_0_0.BackColor = System.Drawing.Color.White;
            this.pct_0_0_0.BackgroundImage = Properties.Resources._123asd;
            this.pct_0_0_0.BackgroundImageLayout = ImageLayout.Center;
            this.pct_0_0_0.Beer = null;
            this.pct_0_0_0.Cursor = Cursors.Hand;
            this.pct_0_0_0.Image = Properties.Resources.good;
            this.pct_0_0_0.Location = new System.Drawing.Point(6, 17);
            this.pct_0_0_0.Name = "pct_0_0_0";
            this.pct_0_0_0.Size = new System.Drawing.Size(75, 75);
            this.pct_0_0_0.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_0_0_0.TabIndex = 1;
            this.pct_0_0_0.TabStop = false;
            this.pct_0_0_0.Click += new System.EventHandler(this.BottomClick);
            // 
            // grp_wnr_0
            // 
            this.grp_wnr_0.Controls.Add(this.pct_wnr_0);
            this.grp_wnr_0.Location = new System.Drawing.Point(279, 6);
            this.grp_wnr_0.Name = "grp_wnr_0";
            this.grp_wnr_0.Size = new System.Drawing.Size(170, 170);
            this.grp_wnr_0.TabIndex = 1;
            this.grp_wnr_0.TabStop = false;
            // 
            // pct_wnr_0
            // 
            this.pct_wnr_0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pct_wnr_0.Beer = null;
            this.pct_wnr_0.Location = new System.Drawing.Point(22, 22);
            this.pct_wnr_0.Name = "pct_wnr_0";
            this.pct_wnr_0.Size = new System.Drawing.Size(128, 128);
            this.pct_wnr_0.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_wnr_0.TabIndex = 1;
            this.pct_wnr_0.TabStop = false;
            // 
            // tbc
            // 
            this.tbc.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.tbc.Controls.Add(this.tb_def);
            this.tbc.Controls.Add(this.tb_sel);
            this.tbc.Location = new System.Drawing.Point(12, -4);
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(738, 544);
            this.tbc.TabIndex = 2;
            // 
            // tb_def
            // 
            this.tb_def.Controls.Add(this.grp_0_3);
            this.tb_def.Controls.Add(this.grp_1_1);
            this.tb_def.Controls.Add(this.grp_0_2);
            this.tb_def.Controls.Add(this.grp_2_0);
            this.tb_def.Controls.Add(this.grp_1_0);
            this.tb_def.Controls.Add(this.grp_0_1);
            this.tb_def.Controls.Add(this.grp_0_0);
            this.tb_def.Controls.Add(this.grp_wnr_0);
            this.tb_def.Location = new System.Drawing.Point(4, 22);
            this.tb_def.Name = "tb_def";
            this.tb_def.Padding = new Padding(3);
            this.tb_def.Size = new System.Drawing.Size(730, 518);
            this.tb_def.TabIndex = 0;
            this.tb_def.Text = "tabPage1";
            this.tb_def.UseVisualStyleBackColor = true;
            // 
            // grp_0_3
            // 
            this.grp_0_3.Controls.Add(this.pct_0_3_1);
            this.grp_0_3.Controls.Add(this.pct_0_3_0);
            this.grp_0_3.Location = new System.Drawing.Point(544, 398);
            this.grp_0_3.Name = "grp_0_3";
            this.grp_0_3.Size = new System.Drawing.Size(170, 102);
            this.grp_0_3.TabIndex = 1;
            this.grp_0_3.TabStop = false;
            // 
            // pct_0_3_1
            // 
            this.pct_0_3_1.BackColor = System.Drawing.Color.White;
            this.pct_0_3_1.BackgroundImage = Properties.Resources._123asd;
            this.pct_0_3_1.BackgroundImageLayout = ImageLayout.Center;
            this.pct_0_3_1.Beer = null;
            this.pct_0_3_1.Cursor = Cursors.Hand;
            this.pct_0_3_1.Image = Properties.Resources.bad;
            this.pct_0_3_1.Location = new System.Drawing.Point(87, 17);
            this.pct_0_3_1.Name = "pct_0_3_1";
            this.pct_0_3_1.Size = new System.Drawing.Size(75, 75);
            this.pct_0_3_1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_0_3_1.TabIndex = 1;
            this.pct_0_3_1.TabStop = false;
            this.pct_0_3_1.Click += new System.EventHandler(this.BottomClick);
            // 
            // pct_0_3_0
            // 
            this.pct_0_3_0.BackColor = System.Drawing.Color.White;
            this.pct_0_3_0.BackgroundImage = Properties.Resources._123asd;
            this.pct_0_3_0.BackgroundImageLayout = ImageLayout.Center;
            this.pct_0_3_0.Beer = null;
            this.pct_0_3_0.Cursor = Cursors.Hand;
            this.pct_0_3_0.Image = Properties.Resources.good;
            this.pct_0_3_0.Location = new System.Drawing.Point(6, 17);
            this.pct_0_3_0.Name = "pct_0_3_0";
            this.pct_0_3_0.Size = new System.Drawing.Size(75, 75);
            this.pct_0_3_0.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_0_3_0.TabIndex = 1;
            this.pct_0_3_0.TabStop = false;
            this.pct_0_3_0.Click += new System.EventHandler(this.BottomClick);
            // 
            // grp_1_1
            // 
            this.grp_1_1.Controls.Add(this.pct_1_1_1);
            this.grp_1_1.Controls.Add(this.pct_1_1_0);
            this.grp_1_1.Location = new System.Drawing.Point(368, 290);
            this.grp_1_1.Name = "grp_1_1";
            this.grp_1_1.Size = new System.Drawing.Size(170, 102);
            this.grp_1_1.TabIndex = 1;
            this.grp_1_1.TabStop = false;
            // 
            // pct_1_1_1
            // 
            this.pct_1_1_1.BackColor = System.Drawing.Color.White;
            this.pct_1_1_1.BackgroundImage = Properties.Resources._123asd;
            this.pct_1_1_1.BackgroundImageLayout = ImageLayout.Center;
            this.pct_1_1_1.Beer = null;
            this.pct_1_1_1.Cursor = Cursors.Hand;
            this.pct_1_1_1.Image = Properties.Resources.bad;
            this.pct_1_1_1.Location = new System.Drawing.Point(87, 17);
            this.pct_1_1_1.Name = "pct_1_1_1";
            this.pct_1_1_1.Size = new System.Drawing.Size(75, 75);
            this.pct_1_1_1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_1_1_1.TabIndex = 1;
            this.pct_1_1_1.TabStop = false;
            this.pct_1_1_1.Click += new System.EventHandler(this.BottomClick);
            // 
            // pct_1_1_0
            // 
            this.pct_1_1_0.BackColor = System.Drawing.Color.White;
            this.pct_1_1_0.BackgroundImage = Properties.Resources._123asd;
            this.pct_1_1_0.BackgroundImageLayout = ImageLayout.Center;
            this.pct_1_1_0.Beer = null;
            this.pct_1_1_0.Cursor = Cursors.Hand;
            this.pct_1_1_0.Image = Properties.Resources.good;
            this.pct_1_1_0.Location = new System.Drawing.Point(6, 17);
            this.pct_1_1_0.Name = "pct_1_1_0";
            this.pct_1_1_0.Size = new System.Drawing.Size(75, 75);
            this.pct_1_1_0.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_1_1_0.TabIndex = 1;
            this.pct_1_1_0.TabStop = false;
            this.pct_1_1_0.Click += new System.EventHandler(this.BottomClick);
            // 
            // grp_0_2
            // 
            this.grp_0_2.Controls.Add(this.pct_0_2_1);
            this.grp_0_2.Controls.Add(this.pct_0_2_0);
            this.grp_0_2.Location = new System.Drawing.Point(368, 398);
            this.grp_0_2.Name = "grp_0_2";
            this.grp_0_2.Size = new System.Drawing.Size(170, 102);
            this.grp_0_2.TabIndex = 1;
            this.grp_0_2.TabStop = false;
            // 
            // pct_0_2_1
            // 
            this.pct_0_2_1.BackColor = System.Drawing.Color.White;
            this.pct_0_2_1.BackgroundImage = Properties.Resources._123asd;
            this.pct_0_2_1.BackgroundImageLayout = ImageLayout.Center;
            this.pct_0_2_1.Beer = null;
            this.pct_0_2_1.Cursor = Cursors.Hand;
            this.pct_0_2_1.Image = Properties.Resources.bad;
            this.pct_0_2_1.Location = new System.Drawing.Point(87, 17);
            this.pct_0_2_1.Name = "pct_0_2_1";
            this.pct_0_2_1.Size = new System.Drawing.Size(75, 75);
            this.pct_0_2_1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_0_2_1.TabIndex = 1;
            this.pct_0_2_1.TabStop = false;
            this.pct_0_2_1.Click += new System.EventHandler(this.BottomClick);
            // 
            // pct_0_2_0
            // 
            this.pct_0_2_0.BackColor = System.Drawing.Color.White;
            this.pct_0_2_0.BackgroundImage = Properties.Resources._123asd;
            this.pct_0_2_0.BackgroundImageLayout = ImageLayout.Center;
            this.pct_0_2_0.Beer = null;
            this.pct_0_2_0.Cursor = Cursors.Hand;
            this.pct_0_2_0.Image = Properties.Resources.good;
            this.pct_0_2_0.Location = new System.Drawing.Point(6, 17);
            this.pct_0_2_0.Name = "pct_0_2_0";
            this.pct_0_2_0.Size = new System.Drawing.Size(75, 75);
            this.pct_0_2_0.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_0_2_0.TabIndex = 1;
            this.pct_0_2_0.TabStop = false;
            this.pct_0_2_0.Click += new System.EventHandler(this.BottomClick);
            // 
            // grp_2_0
            // 
            this.grp_2_0.Controls.Add(this.pct_2_0_1);
            this.grp_2_0.Controls.Add(this.pct_2_0_0);
            this.grp_2_0.Location = new System.Drawing.Point(279, 182);
            this.grp_2_0.Name = "grp_2_0";
            this.grp_2_0.Size = new System.Drawing.Size(170, 102);
            this.grp_2_0.TabIndex = 1;
            this.grp_2_0.TabStop = false;
            // 
            // pct_2_0_1
            // 
            this.pct_2_0_1.BackColor = System.Drawing.Color.White;
            this.pct_2_0_1.BackgroundImage = Properties.Resources._123asd;
            this.pct_2_0_1.BackgroundImageLayout = ImageLayout.Center;
            this.pct_2_0_1.Beer = null;
            this.pct_2_0_1.Cursor = Cursors.Hand;
            this.pct_2_0_1.Image = Properties.Resources.bad;
            this.pct_2_0_1.Location = new System.Drawing.Point(87, 17);
            this.pct_2_0_1.Name = "pct_2_0_1";
            this.pct_2_0_1.Size = new System.Drawing.Size(75, 75);
            this.pct_2_0_1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_2_0_1.TabIndex = 1;
            this.pct_2_0_1.TabStop = false;
            // 
            // pct_2_0_0
            // 
            this.pct_2_0_0.BackColor = System.Drawing.Color.White;
            this.pct_2_0_0.BackgroundImage = Properties.Resources._123asd;
            this.pct_2_0_0.BackgroundImageLayout = ImageLayout.Center;
            this.pct_2_0_0.Beer = null;
            this.pct_2_0_0.Cursor = Cursors.Hand;
            this.pct_2_0_0.Image = Properties.Resources.good;
            this.pct_2_0_0.Location = new System.Drawing.Point(6, 17);
            this.pct_2_0_0.Name = "pct_2_0_0";
            this.pct_2_0_0.Size = new System.Drawing.Size(75, 75);
            this.pct_2_0_0.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_2_0_0.TabIndex = 1;
            this.pct_2_0_0.TabStop = false;
            // 
            // grp_1_0
            // 
            this.grp_1_0.Controls.Add(this.pct_1_0_1);
            this.grp_1_0.Controls.Add(this.pct_1_0_0);
            this.grp_1_0.Location = new System.Drawing.Point(192, 290);
            this.grp_1_0.Name = "grp_1_0";
            this.grp_1_0.Size = new System.Drawing.Size(170, 102);
            this.grp_1_0.TabIndex = 1;
            this.grp_1_0.TabStop = false;
            // 
            // pct_1_0_1
            // 
            this.pct_1_0_1.BackColor = System.Drawing.Color.White;
            this.pct_1_0_1.BackgroundImage = Properties.Resources._123asd;
            this.pct_1_0_1.BackgroundImageLayout = ImageLayout.Center;
            this.pct_1_0_1.Beer = null;
            this.pct_1_0_1.Cursor = Cursors.Hand;
            this.pct_1_0_1.Image = Properties.Resources.bad;
            this.pct_1_0_1.Location = new System.Drawing.Point(87, 17);
            this.pct_1_0_1.Name = "pct_1_0_1";
            this.pct_1_0_1.Size = new System.Drawing.Size(75, 75);
            this.pct_1_0_1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_1_0_1.TabIndex = 1;
            this.pct_1_0_1.TabStop = false;
            this.pct_1_0_1.Click += new System.EventHandler(this.BottomClick);
            // 
            // pct_1_0_0
            // 
            this.pct_1_0_0.BackColor = System.Drawing.Color.White;
            this.pct_1_0_0.BackgroundImage = Properties.Resources._123asd;
            this.pct_1_0_0.BackgroundImageLayout = ImageLayout.Center;
            this.pct_1_0_0.Beer = null;
            this.pct_1_0_0.Cursor = Cursors.Hand;
            this.pct_1_0_0.Image = Properties.Resources.good;
            this.pct_1_0_0.Location = new System.Drawing.Point(6, 17);
            this.pct_1_0_0.Name = "pct_1_0_0";
            this.pct_1_0_0.Size = new System.Drawing.Size(75, 75);
            this.pct_1_0_0.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_1_0_0.TabIndex = 1;
            this.pct_1_0_0.TabStop = false;
            this.pct_1_0_0.Click += new System.EventHandler(this.BottomClick);
            // 
            // grp_0_1
            // 
            this.grp_0_1.Controls.Add(this.pct_0_1_1);
            this.grp_0_1.Controls.Add(this.pct_0_1_0);
            this.grp_0_1.Location = new System.Drawing.Point(192, 398);
            this.grp_0_1.Name = "grp_0_1";
            this.grp_0_1.Size = new System.Drawing.Size(170, 102);
            this.grp_0_1.TabIndex = 1;
            this.grp_0_1.TabStop = false;
            // 
            // pct_0_1_1
            // 
            this.pct_0_1_1.BackColor = System.Drawing.Color.White;
            this.pct_0_1_1.BackgroundImage = Properties.Resources._123asd;
            this.pct_0_1_1.BackgroundImageLayout = ImageLayout.Center;
            this.pct_0_1_1.Beer = null;
            this.pct_0_1_1.Cursor = Cursors.Hand;
            this.pct_0_1_1.Image = Properties.Resources.bad;
            this.pct_0_1_1.Location = new System.Drawing.Point(87, 17);
            this.pct_0_1_1.Name = "pct_0_1_1";
            this.pct_0_1_1.Size = new System.Drawing.Size(75, 75);
            this.pct_0_1_1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_0_1_1.TabIndex = 1;
            this.pct_0_1_1.TabStop = false;
            this.pct_0_1_1.Click += new System.EventHandler(this.BottomClick);
            // 
            // pct_0_1_0
            // 
            this.pct_0_1_0.BackColor = System.Drawing.Color.White;
            this.pct_0_1_0.BackgroundImage = Properties.Resources._123asd;
            this.pct_0_1_0.BackgroundImageLayout = ImageLayout.Center;
            this.pct_0_1_0.Beer = null;
            this.pct_0_1_0.Cursor = Cursors.Hand;
            this.pct_0_1_0.Image = Properties.Resources.good;
            this.pct_0_1_0.Location = new System.Drawing.Point(6, 17);
            this.pct_0_1_0.Name = "pct_0_1_0";
            this.pct_0_1_0.Size = new System.Drawing.Size(75, 75);
            this.pct_0_1_0.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_0_1_0.TabIndex = 1;
            this.pct_0_1_0.TabStop = false;
            this.pct_0_1_0.Click += new System.EventHandler(this.BottomClick);
            // 
            // tb_sel
            // 
            this.tb_sel.Controls.Add(this.btn_win);
            this.tb_sel.Controls.Add(this.grp_w0_1);
            this.tb_sel.Controls.Add(this.grp_w1_0);
            this.tb_sel.Controls.Add(this.grp_w0_0);
            this.tb_sel.Controls.Add(this.grp_ww);
            this.tb_sel.Location = new System.Drawing.Point(4, 22);
            this.tb_sel.Name = "tb_sel";
            this.tb_sel.Padding = new Padding(3);
            this.tb_sel.Size = new System.Drawing.Size(730, 518);
            this.tb_sel.TabIndex = 4;
            this.tb_sel.Text = "tabPage5";
            this.tb_sel.UseVisualStyleBackColor = true;
            // 
            // btn_win
            // 
            this.btn_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_win.Location = new System.Drawing.Point(192, 398);
            this.btn_win.Name = "btn_win";
            this.btn_win.Size = new System.Drawing.Size(346, 102);
            this.btn_win.TabIndex = 10;
            this.btn_win.Text = "Победа!";
            this.btn_win.UseVisualStyleBackColor = true;
            // 
            // grp_w0_1
            // 
            this.grp_w0_1.Controls.Add(this.pct_w0_1_1);
            this.grp_w0_1.Controls.Add(this.pct_w0_1_0);
            this.grp_w0_1.Location = new System.Drawing.Point(368, 290);
            this.grp_w0_1.Name = "grp_w0_1";
            this.grp_w0_1.Size = new System.Drawing.Size(170, 102);
            this.grp_w0_1.TabIndex = 3;
            this.grp_w0_1.TabStop = false;
            // 
            // pct_w0_1_1
            // 
            this.pct_w0_1_1.BackColor = System.Drawing.Color.White;
            this.pct_w0_1_1.BackgroundImage = Properties.Resources._123asd;
            this.pct_w0_1_1.BackgroundImageLayout = ImageLayout.Center;
            this.pct_w0_1_1.Beer = null;
            this.pct_w0_1_1.Cursor = Cursors.Hand;
            this.pct_w0_1_1.Image = Properties.Resources.bad;
            this.pct_w0_1_1.Location = new System.Drawing.Point(87, 17);
            this.pct_w0_1_1.Name = "pct_w0_1_1";
            this.pct_w0_1_1.Size = new System.Drawing.Size(75, 75);
            this.pct_w0_1_1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_w0_1_1.TabIndex = 1;
            this.pct_w0_1_1.TabStop = false;
            // 
            // pct_w0_1_0
            // 
            this.pct_w0_1_0.BackColor = System.Drawing.Color.White;
            this.pct_w0_1_0.BackgroundImage = Properties.Resources._123asd;
            this.pct_w0_1_0.BackgroundImageLayout = ImageLayout.Center;
            this.pct_w0_1_0.Beer = null;
            this.pct_w0_1_0.Cursor = Cursors.Hand;
            this.pct_w0_1_0.Image = Properties.Resources.good;
            this.pct_w0_1_0.Location = new System.Drawing.Point(6, 17);
            this.pct_w0_1_0.Name = "pct_w0_1_0";
            this.pct_w0_1_0.Size = new System.Drawing.Size(75, 75);
            this.pct_w0_1_0.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_w0_1_0.TabIndex = 1;
            this.pct_w0_1_0.TabStop = false;
            // 
            // grp_w1_0
            // 
            this.grp_w1_0.Controls.Add(this.pct_w1_0_1);
            this.grp_w1_0.Controls.Add(this.pct_w1_0_0);
            this.grp_w1_0.Location = new System.Drawing.Point(279, 182);
            this.grp_w1_0.Name = "grp_w1_0";
            this.grp_w1_0.Size = new System.Drawing.Size(170, 102);
            this.grp_w1_0.TabIndex = 5;
            this.grp_w1_0.TabStop = false;
            // 
            // pct_w1_0_1
            // 
            this.pct_w1_0_1.BackColor = System.Drawing.Color.White;
            this.pct_w1_0_1.BackgroundImage = Properties.Resources._123asd;
            this.pct_w1_0_1.BackgroundImageLayout = ImageLayout.Center;
            this.pct_w1_0_1.Beer = null;
            this.pct_w1_0_1.Cursor = Cursors.Hand;
            this.pct_w1_0_1.Image = Properties.Resources.bad;
            this.pct_w1_0_1.Location = new System.Drawing.Point(87, 17);
            this.pct_w1_0_1.Name = "pct_w1_0_1";
            this.pct_w1_0_1.Size = new System.Drawing.Size(75, 75);
            this.pct_w1_0_1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_w1_0_1.TabIndex = 1;
            this.pct_w1_0_1.TabStop = false;
            // 
            // pct_w1_0_0
            // 
            this.pct_w1_0_0.BackColor = System.Drawing.Color.White;
            this.pct_w1_0_0.BackgroundImage = Properties.Resources._123asd;
            this.pct_w1_0_0.BackgroundImageLayout = ImageLayout.Center;
            this.pct_w1_0_0.Beer = null;
            this.pct_w1_0_0.Cursor = Cursors.Hand;
            this.pct_w1_0_0.Image = Properties.Resources.good;
            this.pct_w1_0_0.Location = new System.Drawing.Point(6, 17);
            this.pct_w1_0_0.Name = "pct_w1_0_0";
            this.pct_w1_0_0.Size = new System.Drawing.Size(75, 75);
            this.pct_w1_0_0.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_w1_0_0.TabIndex = 1;
            this.pct_w1_0_0.TabStop = false;
            // 
            // grp_w0_0
            // 
            this.grp_w0_0.Controls.Add(this.pct_w0_0_1);
            this.grp_w0_0.Controls.Add(this.pct_w0_0_0);
            this.grp_w0_0.Location = new System.Drawing.Point(192, 290);
            this.grp_w0_0.Name = "grp_w0_0";
            this.grp_w0_0.Size = new System.Drawing.Size(170, 102);
            this.grp_w0_0.TabIndex = 6;
            this.grp_w0_0.TabStop = false;
            // 
            // pct_w0_0_1
            // 
            this.pct_w0_0_1.BackColor = System.Drawing.Color.White;
            this.pct_w0_0_1.BackgroundImage = Properties.Resources._123asd;
            this.pct_w0_0_1.BackgroundImageLayout = ImageLayout.Center;
            this.pct_w0_0_1.Beer = null;
            this.pct_w0_0_1.Cursor = Cursors.Hand;
            this.pct_w0_0_1.Image = Properties.Resources.bad;
            this.pct_w0_0_1.Location = new System.Drawing.Point(87, 17);
            this.pct_w0_0_1.Name = "pct_w0_0_1";
            this.pct_w0_0_1.Size = new System.Drawing.Size(75, 75);
            this.pct_w0_0_1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_w0_0_1.TabIndex = 1;
            this.pct_w0_0_1.TabStop = false;
            // 
            // pct_w0_0_0
            // 
            this.pct_w0_0_0.BackColor = System.Drawing.Color.White;
            this.pct_w0_0_0.BackgroundImage = Properties.Resources._123asd;
            this.pct_w0_0_0.BackgroundImageLayout = ImageLayout.Center;
            this.pct_w0_0_0.Beer = null;
            this.pct_w0_0_0.Cursor = Cursors.Hand;
            this.pct_w0_0_0.Image = Properties.Resources.good;
            this.pct_w0_0_0.Location = new System.Drawing.Point(6, 17);
            this.pct_w0_0_0.Name = "pct_w0_0_0";
            this.pct_w0_0_0.Size = new System.Drawing.Size(75, 75);
            this.pct_w0_0_0.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_w0_0_0.TabIndex = 1;
            this.pct_w0_0_0.TabStop = false;
            // 
            // grp_ww
            // 
            this.grp_ww.Controls.Add(this.pct_ww);
            this.grp_ww.Location = new System.Drawing.Point(279, 6);
            this.grp_ww.Name = "grp_ww";
            this.grp_ww.Size = new System.Drawing.Size(170, 170);
            this.grp_ww.TabIndex = 9;
            this.grp_ww.TabStop = false;
            // 
            // pct_ww
            // 
            this.pct_ww.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pct_ww.Beer = null;
            this.pct_ww.Location = new System.Drawing.Point(22, 22);
            this.pct_ww.Name = "pct_ww";
            this.pct_ww.Size = new System.Drawing.Size(128, 128);
            this.pct_ww.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct_ww.TabIndex = 1;
            this.pct_ww.TabStop = false;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 552);
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.grp_info);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGame";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "BinaryBeer";
            this.FormClosing += new FormClosingEventHandler(this.FrmGame_FormClosing);
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.grp_info.ResumeLayout(false);
            this.grp_info.PerformLayout();
            ((ISupportInitialize)(this.pct_av)).EndInit();
            this.grp_0_0.ResumeLayout(false);
            ((ISupportInitialize)(this.pct_0_0_1)).EndInit();
            ((ISupportInitialize)(this.pct_0_0_0)).EndInit();
            this.grp_wnr_0.ResumeLayout(false);
            ((ISupportInitialize)(this.pct_wnr_0)).EndInit();
            this.tbc.ResumeLayout(false);
            this.tb_def.ResumeLayout(false);
            this.grp_0_3.ResumeLayout(false);
            ((ISupportInitialize)(this.pct_0_3_1)).EndInit();
            ((ISupportInitialize)(this.pct_0_3_0)).EndInit();
            this.grp_1_1.ResumeLayout(false);
            ((ISupportInitialize)(this.pct_1_1_1)).EndInit();
            ((ISupportInitialize)(this.pct_1_1_0)).EndInit();
            this.grp_0_2.ResumeLayout(false);
            ((ISupportInitialize)(this.pct_0_2_1)).EndInit();
            ((ISupportInitialize)(this.pct_0_2_0)).EndInit();
            this.grp_2_0.ResumeLayout(false);
            ((ISupportInitialize)(this.pct_2_0_1)).EndInit();
            ((ISupportInitialize)(this.pct_2_0_0)).EndInit();
            this.grp_1_0.ResumeLayout(false);
            ((ISupportInitialize)(this.pct_1_0_1)).EndInit();
            ((ISupportInitialize)(this.pct_1_0_0)).EndInit();
            this.grp_0_1.ResumeLayout(false);
            ((ISupportInitialize)(this.pct_0_1_1)).EndInit();
            ((ISupportInitialize)(this.pct_0_1_0)).EndInit();
            this.tb_sel.ResumeLayout(false);
            this.grp_w0_1.ResumeLayout(false);
            ((ISupportInitialize)(this.pct_w0_1_1)).EndInit();
            ((ISupportInitialize)(this.pct_w0_1_0)).EndInit();
            this.grp_w1_0.ResumeLayout(false);
            ((ISupportInitialize)(this.pct_w1_0_1)).EndInit();
            ((ISupportInitialize)(this.pct_w1_0_0)).EndInit();
            this.grp_w0_0.ResumeLayout(false);
            ((ISupportInitialize)(this.pct_w0_0_1)).EndInit();
            ((ISupportInitialize)(this.pct_w0_0_0)).EndInit();
            this.grp_ww.ResumeLayout(false);
            ((ISupportInitialize)(this.pct_ww)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_win;
        private GroupBox grp_info;
        private GroupBoxEx grp_2_0;
        private GroupBoxEx grp_0_0;
        private GroupBoxEx grp_0_1;
        private GroupBoxEx grp_w0_1;
        private GroupBoxEx grp_w1_0;
        private GroupBoxEx grp_w0_0;
        private GroupBoxEx grp_0_2;
        private GroupBoxEx grp_ww;
        private GroupBoxEx grp_0_3;
        private GroupBoxEx grp_1_0;
        private GroupBoxEx grp_1_1;
        private GroupBoxEx grp_wnr_0;
        private Label lbl_lbl_lbl;
        private Label lbl_lvl;
        private PictureBoxEx pct_1_0_1;
        private PictureBoxEx pct_1_0_0;
        private PictureBoxEx pct_1_1_1;
        private PictureBoxEx pct_1_1_0;
        private PictureBoxEx pct_wnr_0;
        private PictureBoxEx pct_av;
        private PictureBoxEx pct_2_0_1;
        private PictureBoxEx pct_2_0_0;
        private PictureBoxEx pct_0_0_0;
        private PictureBoxEx pct_0_0_1;
        private PictureBoxEx pct_0_1_1;
        private PictureBoxEx pct_0_1_0;
        private PictureBoxEx pct_w0_1_1;
        private PictureBoxEx pct_w0_1_0;
        private PictureBoxEx pct_w1_0_1;
        private PictureBoxEx pct_w1_0_0;
        private PictureBoxEx pct_0_2_1;
        private PictureBoxEx pct_w0_0_1;
        private PictureBoxEx pct_w0_0_0;
        private PictureBoxEx pct_ww;
        private PictureBoxEx pct_0_2_0;
        private PictureBoxEx pct_0_3_1;
        private PictureBoxEx pct_0_3_0;
        private TabControl tbc;
        private TabPage tb_def;
        private TabPage tb_sel;
        public Label lbl_name;
    }
}