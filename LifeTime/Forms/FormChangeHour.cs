using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LifeTime.Forms
{
    public partial class FormChangeHour : Form
    {
        public bool Forward = true;
        public TimeSpan TimeShift = TimeSpan.Zero;

        public FormChangeHour()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Forward = rbForward.Checked;
            TimeShift = TimeSpan.FromHours(dtpTimeShift.Value.Hour) + TimeSpan.FromMinutes(dtpTimeShift.Value.Minute);

            DialogResult = DialogResult.OK;
        }
    }
}
