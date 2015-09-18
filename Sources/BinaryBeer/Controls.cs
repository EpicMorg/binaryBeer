using System.Windows.Forms;

namespace BinaryBeer
{
    public class PictureBoxEx : PictureBox
    {
        public Beer Beer { get; set; }
    }

    public class GroupBoxEx : GroupBox {
        public int Round { get; set; }
    }
}
