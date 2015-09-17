using System;
using System.Windows.Forms;

namespace BinaryBeer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnStats_Click(object sender, EventArgs e)
        {
            var frmstats = new FrmStats();
            frmstats.ShowDialog();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            txtName.Visible = GbxName.Visible = lblName.Visible = true;
            BtnStart.Text = @"Продолжить";
            if (BtnStart.Text == @"Продолжить" &&  string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show(@"Заполните необходимые поля!", @"Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Hide();
                var frmnewgame = new FrmGame {lbl_name = {Text = txtName.Text}};
                frmnewgame.ShowDialog();
                Show();
               
            }
        }

        private void FrmAbout_Click(object sender, EventArgs e)
        {
            var frmabout = new FrmAbout();
            frmabout.ShowDialog();
        }
    }
}