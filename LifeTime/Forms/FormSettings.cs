using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Days
{
    public partial class FormSettings : Form
    {
        Settings editedSettings;

        public FormSettings(Settings settings)
        {
            InitializeComponent();
            editedSettings = settings;

            chbUseSeconds.Checked = editedSettings.UseSeconds;
            chbUseMinutes.Checked = editedSettings.UseMinutes;
            chbUseHours.Checked = editedSettings.UseHours;
            chbUseDays.Checked = editedSettings.UseDays;
            chbUseWeeks.Checked = editedSettings.UseWeeks;
            chbUseMonthes.Checked = editedSettings.UseMonthes;
            chbUseYears.Checked = editedSettings.UseYears;
            chbEveryYear.Checked = editedSettings.CalcEveryYear;
            nudPreviousDays.Value = editedSettings.PreviousDaysQuantity;
            nudNextDays.Value = editedSettings.NextDaysQuantity;
            nudRecalcDays.Value = editedSettings.RecountDaysQuantity;
            chbExponent.Checked = editedSettings.UseExponentCalc;
            chbSameDigits.Checked = editedSettings.UseSameDigitsCalc;
            tbMidNums.Text = editedSettings.MidNumsString;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            editedSettings.UseSeconds = chbUseSeconds.Checked;
            editedSettings.UseMinutes = chbUseMinutes.Checked;
            editedSettings.UseHours = chbUseHours.Checked;
            editedSettings.UseDays = chbUseDays.Checked;
            editedSettings.UseWeeks = chbUseWeeks.Checked;
            editedSettings.UseMonthes = chbUseMonthes.Checked;
            editedSettings.UseYears = chbUseYears.Checked;
            editedSettings.CalcEveryYear = chbEveryYear.Checked;
            editedSettings.PreviousDaysQuantity = (int)nudPreviousDays.Value;
            editedSettings.NextDaysQuantity = (int)nudNextDays.Value;
            editedSettings.RecountDaysQuantity = (int)nudRecalcDays.Value;
            editedSettings.UseExponentCalc = chbExponent.Checked;
            editedSettings.UseSameDigitsCalc = chbSameDigits.Checked;
            editedSettings.MidNumsString = tbMidNums.Text;

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
