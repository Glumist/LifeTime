using System;
using System.Windows.Forms;

namespace LifeTime.Forms
{
    public partial class FormAbout : Form
    {
        public FormAbout(string version)
        {
            InitializeComponent();
            textBox_Version.Text = version;
        }
    }
}
