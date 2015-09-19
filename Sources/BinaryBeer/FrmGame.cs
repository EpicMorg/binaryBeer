using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryBeer {
    public partial class FrmGame : Form {
        private int _set = -1;
        private Beer[] _beers;

        public FrmGame(string name) {
            InitializeComponent();
            lbl_name.Text = name;
            _beers = Beer.GetBeers().ToArray();
            NextSet();
        }

        private void FrmGame_FormClosing(object sender, FormClosingEventArgs e) =>
            e.Cancel = MessageBox.Show(Properties.Resources.CloseGameProgressWillBeLost, Properties.Resources.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No;

        private async void BottomClick(object sender, EventArgs e) {
            var selected = (sender as PictureBoxEx);
            var beer = selected.Beer;
            var parent = selected.Parent as GroupBoxEx;
            var other = parent.Controls.OfType<PictureBoxEx>().FirstOrDefault( a => a != selected );

            parent.Enabled = false;
            other.Image = Properties.Resources.bad;
            selected.Image = Properties.Resources.good;

            var nextRound = parent.Round+1;
            Control frame = tb_def;

            var nrr = frame.Controls.OfType<GroupBoxEx>()
                .Where( a => a.Round == nextRound )
                .ToArray();

            var next = nrr.SelectMany( a => a.Controls.OfType<PictureBoxEx>() )
                    .Where( a => a.Beer == null )
                    .ToArray();

            if ( next.Any() ) {
                //not next round
                next.FirstOrDefault().Beer = beer;

                if ( next.Count() == 1 ) foreach ( var b in nrr ) b.Enabled = true; //enable next row
            }
            else {
                pct_wnr_0.Beer = beer;
#if !DEBUG
                await Task.Delay( 1500 );
#endif
                NextSet();
            }
        }
        List<Beer> bs = new List<Beer>();
        private void NextSet() {
            //todo: save & check if final
            _set++;
            lbl_lvl.Text = (_set + 1).ToString();
            if ( pct_wnr_0.Beer != null ) {
                bs.Add(pct_wnr_0.Beer);
            }
            if ( _set * 8 < _beers.Length ) {
                NextSetStd();
            }
            else {
                tbc.SelectedTab = tb_sel;
                var gs =
                    tb_sel.Controls.OfType<GroupBoxEx>()
                          .Where( a => a.Round == 0 )
                          .SelectMany( a => a.Controls.OfType<PictureBoxEx>() )
                          .ToArray();
                for ( int i = 0; i < bs.Count; i++ ) {
                    gs[ i ].Beer = bs[ i ];
                }
            }
        }

        private void NextSetStd() {
            this.SuspendLayout();
            var gbs = tb_def.Controls.OfType<GroupBoxEx>().ToArray();
            foreach ( var gb in gbs ) gb.Enabled = false;
            foreach ( var gb in gbs.Where( a => a.Round == 0 ) ) gb.Enabled = true;
            foreach ( var pb in gbs.SelectMany( a => a.Controls.OfType<PictureBoxEx>() ) ) {
                pb.Beer = null;
                pb.Image = null;
            }
            var boxes =
                gbs.Where( a => a.Round == 0 )
                   .SelectMany( a => a.Controls.OfType<PictureBoxEx>() )
                   .Select( ( value, index ) => new { value, index } )
                   .ToArray();
            var beers = _beers.Skip( 8 * _set ).Take( 8 ).ToArray();
            pct_wnr_0.Beer = null;
            foreach ( var gb in boxes ) gb.value.Beer = beers[ gb.index ];
            this.ResumeLayout();
            Application.DoEvents();
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {

        }

        private void UpClick(object sender, EventArgs e)
        {
            var selected = (sender as PictureBoxEx);
            var beer = selected.Beer;
            var parent = selected.Parent as GroupBoxEx;
            var other = parent.Controls.OfType<PictureBoxEx>().FirstOrDefault(a => a != selected);

            parent.Enabled = false;
            other.Image = Properties.Resources.bad;
            selected.Image = Properties.Resources.good;

            var nextRound = parent.Round + 1;
            Control frame = tb_sel;

            var nrr = frame.Controls.OfType<GroupBoxEx>()
                .Where(a => a.Round == nextRound)
                .ToArray();

            var next = nrr.SelectMany(a => a.Controls.OfType<PictureBoxEx>())
                    .Where(a => a.Beer == null)
                    .ToArray();

            if (next.Any())
            {
                //not next round
                next.FirstOrDefault().Beer = beer;

                if (next.Count() == 1) foreach (var b in nrr) b.Enabled = true; //enable next row
            }
            else {
                pct_ww.Beer = beer;
                btn_win.Enabled = true;
            }
        }

        private void btn_win_Click(object sender, EventArgs e)
        {
            StatMan.Add( new Item() {
                BeerName = pct_ww.Beer.Name,
                Player = lbl_name.Text
            } );
            this.Close();
        }
    }
}
