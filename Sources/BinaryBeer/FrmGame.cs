using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryBeer
{
    public partial class FrmGame : Form
    {
        public FrmGame()
        {
            InitializeComponent();
        }

        private void FrmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show(@"Закрыть игру? Результат не будет сохранен.", @"Вниание!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No;
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {

        } 
    }
}
