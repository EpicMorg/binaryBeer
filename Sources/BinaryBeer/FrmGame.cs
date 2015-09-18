using System;
using System.Linq;
using System.Windows.Forms;

namespace BinaryBeer {
    public partial class FrmGame : Form {
        public FrmGame(string name) {
            lbl_name.Text = name;
            InitializeComponent();
        }

        private void FrmGame_FormClosing(object sender, FormClosingEventArgs e) =>
            e.Cancel = MessageBox.Show(Properties.Resources.CloseGameProgressWillBeLost, Properties.Resources.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No;

        private void BottomClick(object sender, EventArgs e) {
            var selected = (sender as PictureBoxEx);
            var parent = selected.Parent;
            var other = parent.Controls.OfType<PictureBoxEx>().FirstOrDefault( a => a != selected );

            parent.Enabled = false;
            other.Image = Properties.Resources.bad;
            selected.Image = Properties.Resources.good;

            
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {

        }
    }
}
