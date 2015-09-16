using System;
using System.Reflection;
using System.Windows.Forms;

namespace BinaryBeer
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private static string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            LblVer.Text = @"Версия " + AssemblyVersion;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
