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
            if (!items.Any()) return;
            dataGridView1.Rows.Add( items.Length );
            var beers = Beer.GetBeers();
            for ( int i = 0; i < items.Length; i++ ) {
                var t = items[ i ];
                var row = dataGridView1.Rows[ i ];
                row.Cells[ 0 ].Value = t.Player;
                var cell = row.Cells[1];
                var image = beers.FirstOrDefault(a=>a.Name==t.BeerName).Image;
                row.Height = image.Height;
                cell.Value = image;

            }
        }
    }
}
