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
    public partial class FormCalculations : Form
    {
        DateTime _startDate = DateTime.Now;
        Settings _settings = null;

        public FormCalculations(string fio, DateTime startDate, Settings settings)
        {
            InitializeComponent();
            _startDate = startDate;
            _settings = settings;
            Text += " " + fio;

            dgvEvents.AutoGenerateColumns = false;

            nudSecondsStep.Value = settings.SecondsStep;
            nudMinutesStep.Value = settings.MinutesStep;
            nudHoursStep.Value = settings.HoursStep;
            nudDaysStep.Value = settings.DaysStep;
            nudWeeksStep.Value = settings.WeeksStep;
            nudMonthesStep.Value = settings.MonthesStep;

            chbSeconds.Checked = settings.UseSecondsStep;
            chbMinutes.Checked = settings.UseMinutesStep;
            chbHours.Checked = settings.UseHoursStep;
            chbDays.Checked = settings.UseDaysStep;
            chbWeeks.Checked = settings.UseWeeksStep;
            chbMonthes.Checked = settings.UseMonthesStep;
        }

        private void FormCalculations_Load(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            _settings.SecondsStep = (int)nudSecondsStep.Value;
            _settings.MinutesStep = (int)nudMinutesStep.Value;
            _settings.HoursStep = (int)nudHoursStep.Value;
            _settings.DaysStep = (int)nudDaysStep.Value;
            _settings.WeeksStep = (int)nudWeeksStep.Value;
            _settings.MonthesStep = (int)nudMonthesStep.Value;

            _settings.UseSecondsStep = chbSeconds.Checked;
            _settings.UseMinutesStep = chbMinutes.Checked;
            _settings.UseHoursStep = chbHours.Checked;
            _settings.UseDaysStep = chbDays.Checked;
            _settings.UseWeeksStep = chbWeeks.Checked;
            _settings.UseMonthesStep = chbMonthes.Checked;
            _settings.Save();

            TimeMeasure timeMeasure;
            TimeMeasureCollection timeMeasures = TimeMeasureCollection.Generate();
            dgvEvents.DataSource = null;
            List<DateEvent> events = new List<DateEvent>();
            if (chbSeconds.Checked && nudSecondsStep.Value > 0)
            {
                timeMeasure = timeMeasures.Find("Seconds");
                if (timeMeasure != null)
                    events.AddRange(GetEvents((uint)nudSecondsStep.Value, TimeSpan.FromSeconds((uint)nudSecondsStep.Value), timeMeasure));
            }
            if (chbMinutes.Checked && nudMinutesStep.Value > 0)
            {
                timeMeasure = timeMeasures.Find("Minutes");
                if (timeMeasure != null)
                    events.AddRange(GetEvents((uint)nudMinutesStep.Value, TimeSpan.FromMinutes((uint)nudMinutesStep.Value), timeMeasure));
            }
            if (chbHours.Checked && nudHoursStep.Value > 0)
            {
                timeMeasure = timeMeasures.Find("Hours");
                if (timeMeasure != null)
                    events.AddRange(GetEvents((uint)nudHoursStep.Value, TimeSpan.FromHours((uint)nudHoursStep.Value), timeMeasure));
            }
            if (chbDays.Checked && nudDaysStep.Value > 0)
            {
                timeMeasure = timeMeasures.Find("Days");
                if (timeMeasure != null)
                    events.AddRange(GetEvents((uint)nudDaysStep.Value, TimeSpan.FromDays((uint)nudDaysStep.Value), timeMeasure));
            }
            if (chbWeeks.Checked && nudWeeksStep.Value > 0)
            {
                timeMeasure = timeMeasures.Find("Weeks");
                if (timeMeasure != null)
                    events.AddRange(GetEvents((uint)nudWeeksStep.Value, TimeSpan.FromDays(7 * (uint)nudWeeksStep.Value), timeMeasure));
            }
            if (chbMonthes.Checked && nudMonthesStep.Value > 0)
            {
                timeMeasure = timeMeasures.Find("Monthes");
                if (timeMeasure != null)
                    events.AddRange(GetMonthEvents((int)nudMonthesStep.Value, timeMeasure));
            }

            if (rbResultByDates.Checked)
                events.Sort(DateEvent.Comparer);
            dgvEvents.DataSource = events;
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private List<DateEvent> GetEvents(uint step, TimeSpan stepTime, TimeMeasure measure)
        {
            List<DateEvent> result = new List<DateEvent>();
            DateTime date = _startDate;
            DateTime maxDate = date.AddYears(100);
            uint i = 0;
            while (date < maxDate)
            {
                date += stepTime;
                i += step;
                result.Add(new DateEvent() { Date = date, Quantity = i, TimeMeasure = measure });
            }
            return result;
        }

        private List<DateEvent> GetMonthEvents(int step, TimeMeasure measure)
        {
            List<DateEvent> result = new List<DateEvent>();
            DateTime date = _startDate;
            DateTime maxDate = date.AddYears(100);
            uint i = 0;
            while (date < maxDate)
            {
                date = date.AddMonths(step);
                i += (uint)step;
                result.Add(new DateEvent() { Date = date, Quantity = i, TimeMeasure = measure });
            }
            return result;
        }

        /*private class DateCalcEvent
        {
            public DateTime Date { get; set; }
            public uint Quantity { get; set; }
            public TimeMeasure Measure { get; set; }
            public string Info { get { return "" + Quantity + " " + Measure.ToString(Quantity); } }

            public static int Comparer(DateCalcEvent a, DateCalcEvent b)
            {
                return DateTime.Compare(a.Date, b.Date);
            }
        }*/
    }
}
