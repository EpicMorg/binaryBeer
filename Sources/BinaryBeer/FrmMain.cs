using System;
using System.Windows.Forms;

namespace BinaryBeer {
    public partial class FrmMain : Form {
        public FrmMain() {
            InitializeComponent();
        }
        
        private void BtnExit_Click( object sender, EventArgs e ) => Application.Exit();

        private void BtnStats_Click( object sender, EventArgs e ) => new FrmStatss().ShowDialog();

        private void BtnStart_Click( object sender, EventArgs e ) {
            txtName.Visible = GbxName.Visible = lblName.Visible = true;
            BtnStart.Text = Properties.Resources.Continue;
            if ( BtnStart.Text == Properties.Resources.Continue && string.IsNullOrWhiteSpace( txtName.Text ) ) {
                MessageBox.Show( Properties.Resources.FillRequiredFields, Properties.Resources.Warning,
                    MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else {
                Hide();
                new FrmGame( txtName.Text ) {lbl_name = {Text = txtName.Text}}.ShowDialog();
                Show();
            }
        }

        private void FrmAbout_Click( object sender, EventArgs e ) => new FrmAbout().ShowDialog();
    }
}