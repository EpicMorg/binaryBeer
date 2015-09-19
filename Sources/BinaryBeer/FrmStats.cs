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
    public partial class FrmStatss : Form
    {
        public FrmStatss()
        {
            InitializeComponent();
        }

        private void BtnStatsClean_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Очистить статистику? Все результаты будут потеряны.", @"Вниание!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
        }

        private void FrmStatss_Load( object sender, EventArgs e ) {
            var items = StatMan.Get();
            dataGridView1.Rows.Add( items.Length );
            var beers = Beer.GetBeers();
            for ( int i = 0; i < items.Length; i++ ) {
                var t = items[ i ];
                dataGridView1.Rows[ i ].Cells[ 0 ].Value = t.Player;
                dataGridView1.Rows[i].Cells[1].Value = beers.FirstOrDefault(a=>a.Name==t.BeerName).Image;
            }
        }
    }
}
