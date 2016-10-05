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
    public partial class FormMain : Form
    {
        private TimeMeasureCollection timeMeasures;
        private ContactCollection contacts;
        private DateEventCollection dateEvents;
        private Settings settings;
        private bool formMaximized = false;
        private const string version = "1.1.3";

        private BackgroundWorker bgwLoader;

        public FormMain()
        {
            InitializeComponent();
            dgvContacts.AutoGenerateColumns = false;
            dgvFutureEvents.AutoGenerateColumns = false;
            dgvPastEvents.AutoGenerateColumns = false;

            tsslContactCount.Alignment = ToolStripItemAlignment.Right;

            bgwLoader = new BackgroundWorker();
            bgwLoader.DoWork += bgwLoader_DoWork;
            bgwLoader.RunWorkerCompleted += bgwLoader_RunWorkerCompleted;
        }

        private void tMain_Tick(object sender, EventArgs e)
        {
            if (tMain.Interval < 1000 * 60 * 60 * 24)
                tMain.Interval = 1000 * 60 * 60 * 24;
            if (niMain.Visible)
            {
                List<DateEvent> dateEventsToday = dateEvents.GetTodayEvents();
                if (dateEventsToday.Count > 0)
                {
                    niMain.BalloonTipText = "";
                    foreach (DateEvent dateEvent in dateEventsToday)
                        niMain.BalloonTipText += "" + dateEvent.Contact.Fio + ": " + dateEvent.Info + "\r\n";
                    niMain.ShowBalloonTip(10000);
                }
            }
            if (settings.LastRecalcDate.AddDays(settings.RecountDaysQuantity).Date >= DateTime.Now.Date)
                tsmiRecalc_Click(sender, e);
        }

        #region Load

        private void FormMain_Load(object sender, EventArgs e)
        {
            formMaximized = this.WindowState == FormWindowState.Maximized;
            bgwLoader.RunWorkerAsync();
        }

        void bgwLoader_DoWork(object sender, DoWorkEventArgs e)
        {
            timeMeasures = TimeMeasureCollection.Generate();
            contacts = ContactCollection.Load();
            dateEvents = DateEventCollection.Load(timeMeasures, contacts);
            settings = Settings.Load();
        }

        void bgwLoader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tsmiRecalc_Click(sender, EventArgs.Empty);
            for (int i = 0; i < tscbContactSort.Items.Count; i++)
                if (tscbContactSort.Items[i].ToString() == settings.ContactSort)
                    tscbContactSort.SelectedItem = tscbContactSort.Items[i];

            tMain.Interval = (int)(DateTime.Now.AddDays(1).Date - DateTime.Now).TotalMilliseconds;
            tMain.Enabled = true;
        }

        #endregion

        private void AddContact()
        {
            FormAddContact formAddContact = new FormAddContact();
            if (formAddContact.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Contact contact = formAddContact.EditedContact;
                contacts.Add(contact, settings.ContactSort);
                contacts.Save();
                dateEvents.Add(contact, timeMeasures, settings);
                dateEvents.Save();
                RefreshTables();
                foreach (DataGridViewRow row in dgvContacts.Rows)
                    if ((row.DataBoundItem as Contact).Id == contact.Id)
                    {
                        row.Selected = true;
                        break;
                    }
            }
        }

        private void EditContact()
        {
            if (dgvContacts.SelectedRows.Count <= 0)
                return;
            FormAddContact formAddContact = new FormAddContact(dgvContacts.SelectedRows[0].DataBoundItem as Contact);
            if (formAddContact.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                contacts.Save();
                if (formAddContact.Recalc)
                {
                    dateEvents.Remove(formAddContact.EditedContact);
                    dateEvents.Add(formAddContact.EditedContact, timeMeasures, settings);
                    dateEvents.Save();
                }
                RefreshTables();
            }
        }

        private void RemoveContact()
        {
            if (dgvContacts.SelectedRows.Count > 0)
            {
                Contact contactTodelete = dgvContacts.SelectedRows[0].DataBoundItem as Contact;
                if (MessageBox.Show("Вы уверены что хотите удалить контакт " + contactTodelete.Fio, "Удаление", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    contacts.Remove(contactTodelete);
                    contacts.Save();
                    dateEvents.Remove(contactTodelete);
                    dateEvents.Save();
                    RefreshTables();
                }
            }
        }

        private void OpenCalculations()
        {
            if (dgvContacts.SelectedRows.Count > 0)
            {
                Contact contact = dgvContacts.SelectedRows[0].DataBoundItem as Contact;
                FormCalculations form = new FormCalculations(contact.Fio, contact.BirthDate, settings);
                form.Show();
            }
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMain.SelectedTab == tpContacts)
                foreach (Control control in tcEvents.SelectedTab.Controls)
                {
                    if (!(control is DataGridView))
                        continue;
                    DataGridView dgv = control as DataGridView;
                    if (dgv.SelectedRows.Count <= 0)
                        return;
                    Contact contact = (dgv.SelectedRows[0].DataBoundItem as DateEvent).Contact;
                    SelectContact(contact);
                }
        }

        #region Tables

        void RefreshTables()
        {
            bsContacts.DataSource = tsmiEnableFilter.Checked ? contacts.Contacts.FindAll(c => c.Fio.ToLower().Contains(tstbFilter.Text.ToLower())) : new List<Contact>(contacts.Contacts);
            // bsContacts.Sort = "Fio";
            bsContacts.ResetBindings(false);
            dgvFutureEvents.DataSource = dateEvents.GetFutureEvents();
            dgvPastEvents.DataSource = dateEvents.GetPastEvents();
            RefreshCurrentContactInfo();
        }

        private void dgvContacts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenCalculations();
            /*if (e.RowIndex >= 0)
                EditContact(dgvContacts.Rows[e.RowIndex].DataBoundItem as Contact);*/
        }

        private void dgvContacts_SelectionChanged(object sender, EventArgs e)
        {
            RefreshCurrentContactInfo();
        }

        private void dgvContacts_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Insert: AddContact(); break;
                case Keys.F2: EditContact(); break;
                case Keys.Delete: RemoveContact(); break;
                case Keys.Enter: OpenCalculations(); break;
            }
        }

        private void dgvFutureEvents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                OpenDateEventInfo(dgvFutureEvents.Rows[e.RowIndex].DataBoundItem as DateEvent);
        }

        private void dgvPastEvents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                OpenDateEventInfo(dgvPastEvents.Rows[e.RowIndex].DataBoundItem as DateEvent);
        }

        private void OpenDateEventInfo(DateEvent dateEvent)
        {
            FormEventInfo formEventInfo = new FormEventInfo(dateEvent);
            formEventInfo.ShowDialog();
        }

        private void RefreshCurrentContactInfo()
        {
            if (dgvContacts.SelectedRows.Count > 0)
            {
                tsslContactCount.Text = "" + (dgvContacts.Rows.IndexOf(dgvContacts.SelectedRows[0]) + 1) + " / " + contacts.Contacts.Count;

                string lifeTimeText = "Контакт прожил полных";
                DateTime birthDate = (dgvContacts.SelectedRows[0].DataBoundItem as Contact).BirthDate;
                TimeSpan lifeTime = DateTime.Now - birthDate;
                DateTime date = birthDate;
                int monthes = 0;
                int years = 0;
                while (date < DateTime.Now.AddMonths(-1))
                {
                    date = date.AddMonths(1);
                    monthes++;
                    if (monthes % 12 == 0)
                        years++;
                }
                lifeTimeText += " лет: " + years;
                lifeTimeText += ", месяцев: " + monthes.ToString("N0");
                double days = Math.Floor(lifeTime.TotalDays);
                lifeTimeText += ", недель: " + Math.Floor(days / 7).ToString("N0");
                lifeTimeText += ", дней: " + days.ToString("N0");
                lifeTimeText += ", часов: " + Math.Floor(lifeTime.TotalHours).ToString("N0");
                lifeTimeText += ", минут: " + Math.Floor(lifeTime.TotalMinutes).ToString("N0");
                lifeTimeText += ", секунд: " + Math.Floor(lifeTime.TotalSeconds).ToString("N0");

                tsslContactLifeTime.Text = lifeTimeText;
            }
            else
            {
                tsslContactLifeTime.Text = "";
                tsslContactCount.Text = "";
            }
        }

        private void SelectContact(Contact contact)
        {
            foreach (DataGridViewRow row in dgvContacts.Rows)
                if (row.DataBoundItem as Contact == contact)
                {
                    dgvContacts.Rows[row.Index].Selected = true;
                    dgvContacts.FirstDisplayedScrollingRowIndex = row.Index;
                }
        }

        #endregion

        #region Menu

        private void tsmiSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings(settings);
            if (formSettings.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                settings.Save();
        }

        private void tsmiRecalc_Click(object sender, EventArgs e)
        {
            dateEvents.Recalc(contacts, timeMeasures, settings);
            dateEvents.Save();
            RefreshTables();
            settings.LastRecalcDate = DateTime.Now;
            settings.Save();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            (new FormAbout(version)).ShowDialog();
        }

        private void tsmiAddContact_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        private void tsmiEditContact_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        private void tsmiRemoveContact_Click(object sender, EventArgs e)
        {
            RemoveContact();
        }

        private void tsmiCalculations_Click(object sender, EventArgs e)
        {
            OpenCalculations();
        }

        private void tsmiChangeHour_Click(object sender, EventArgs e)
        {
            FormChangeHour formChangeHour = new FormChangeHour();
            if (formChangeHour.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                contacts.ShiftTime(formChangeHour.Forward, formChangeHour.TimeShift);
                contacts.Save();
                RefreshTables();
            }
        }

        private void tscbContactSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contact selectedContact = null;
            if (dgvContacts.SelectedRows.Count > 0)
                selectedContact = dgvContacts.SelectedRows[0].DataBoundItem as Contact;


            contacts.Sort(tscbContactSort.SelectedItem.ToString());
            RefreshTables();
            settings.ContactSort = tscbContactSort.SelectedItem.ToString();
            settings.Save();

            if (settings.ContactSort == "По датам")
            {
                for (int i = 0; i < dgvContacts.Rows.Count; i++)
                {
                    Contact contact = dgvContacts.Rows[i].DataBoundItem as Contact;
                    DateTime datetime = new DateTime(DateTime.Now.Year, contact.BirthDate.Month, contact.BirthDate.Day);
                    if (datetime >= DateTime.Now)
                    {
                        int select = i > 0 ? i - 1 : i;
                        dgvContacts.Rows[select].Selected = true;
                        dgvContacts.FirstDisplayedScrollingRowIndex = select;
                        return;
                    }
                }
                dgvContacts.Rows[dgvContacts.Rows.Count - 1].Selected = true;
            }
            else if (selectedContact != null)
                SelectContact(selectedContact);
        }

        private void tsmiEnableFilter_CheckedChanged(object sender, EventArgs e)
        {
            tstbFilter.Visible = tsmiEnableFilter.Checked;
            RefreshTables();
        }

        private void tstbFilter_TextChanged(object sender, EventArgs e)
        {
            RefreshTables();
            tscbContactSort_SelectedIndexChanged(sender, e);
        }

        #endregion

        #region Resize

        private void ShowForm()
        {
            this.WindowState = formMaximized ? FormWindowState.Maximized : FormWindowState.Normal;
            this.ShowInTaskbar = true;
            niMain.Visible = false;
        }

        private void HideForm()
        {
            this.ShowInTaskbar = false;
            niMain.Visible = true;
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                HideForm();
            else
                formMaximized = this.WindowState == FormWindowState.Maximized;
        }

        #endregion

        #region Tray

        private void niMain_DoubleClick(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void tsmiShow_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void niMain_BalloonTipClicked(object sender, EventArgs e)
        {
            ShowForm();
        }

        #endregion
    }
}