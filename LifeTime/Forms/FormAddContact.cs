using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LifeTime.Classes;
using LifeTime.Properties;

namespace LifeTime.Forms
{
    public partial class FormAddContact : Form
    {
        public Contact EditedContact;
        public bool Recalc = false;

        public FormAddContact()
        {
            InitializeComponent();
            dtpBirth.Value = DateTime.Now;
        }

        public FormAddContact(Contact contact)
        {
            InitializeComponent();
            EditedContact = contact;
            tbFio.Text = contact.Fio;
            dtpBirth.Value = contact.BirthDate;
            tbInfo.Text = contact.Info;
            Text = Resources.ResourceManager.GetString("FormAddContact_EditText");
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DateTime newDate = GetDate();
            if (EditedContact != null)
            {
                if (newDate != EditedContact.BirthDate)
                {
                    if (MessageBox.Show(Resources.ResourceManager.GetString("NewDate_Question"), Resources.ResourceManager.GetString("NewDate_Caption"), MessageBoxButtons.YesNo) == DialogResult.Yes)
                        Recalc = true;
                }
                EditedContact.Fio = tbFio.Text;
                EditedContact.Info = tbInfo.Text;
                EditedContact.BirthDate = newDate;
            }
            else
            {
                EditedContact = new Contact(tbFio.Text, newDate, tbInfo.Text);
            }

            DialogResult = DialogResult.OK;
        }

        private DateTime GetDate()
        {
            return new DateTime(dtpBirth.Value.Year, dtpBirth.Value.Month, dtpBirth.Value.Day, dtpBirth.Value.Hour, dtpBirth.Value.Minute, 0);
        }

        private void dtpBirth_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan lifeTime = DateTime.Now - dtpBirth.Value;
            lSeconds.Text = "" + Math.Floor(lifeTime.TotalSeconds).ToString("N0");
            lMinutes.Text = "" + Math.Floor(lifeTime.TotalMinutes).ToString("N0");
            lHours.Text = "" + Math.Floor(lifeTime.TotalHours).ToString("N0");
            double days = Math.Floor(lifeTime.TotalDays);
            lDays.Text = "" + days.ToString("N0");
            lWeeks.Text = "" + Math.Floor(days / 7).ToString("N0");
            int monthes = 0;
            int years = 0;
            DateTime date = dtpBirth.Value;
            while (date < DateTime.Now.AddMonths(-1))
            {
                date = date.AddMonths(1);
                monthes++;
                if (monthes % 12 == 0)
                    years++;
            }
            lMonthes.Text = "" + monthes.ToString("N0");
            lYears.Text = "" + years;
        }
    }
}
