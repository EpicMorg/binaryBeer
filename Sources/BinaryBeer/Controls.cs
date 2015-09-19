using System.Windows.Forms;
using BinaryBeer.Properties;

namespace BinaryBeer
{
    public class PictureBoxEx : PictureBox
    {
        private Beer _beer;

        public Beer Beer
        {
            get
            {
                return _beer;
            }
            set
            {
                this.BackgroundImageLayout = ImageLayout.Zoom;
                this.BackgroundImage = value?.Image ?? Resources._123asd;
                _beer = value;
            }
        }
    }

    public class GroupBoxEx : GroupBox {
        public int Round { get; set; }
    }
}
