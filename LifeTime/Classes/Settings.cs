using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Globalization;
using LifeTime.Enums;
using System.Threading;

namespace LifeTime.Classes
{
    public class Settings
    {
        private static string fileName = "Settings.xml";

        private bool _useSeconds = true;
        [XmlElement("UseSeconds")]
        [DefaultValue(true)]
        public bool UseSeconds
        {
            get { return _useSeconds; }
            set { _useSeconds = value; }
        }

        private bool _useMinutes = true;
        [XmlElement("UseMinutes")]
        [DefaultValue(true)]
        public bool UseMinutes
        {
            get { return _useMinutes; }
            set { _useMinutes = value; }
        }

        private bool _useHours = true;
        [XmlElement("UseHours")]
        [DefaultValue(true)]
        public bool UseHours
        {
            get { return _useHours; }
            set { _useHours = value; }
        }

        private bool _useDays = true;
        [XmlElement("UseDays")]
        [DefaultValue(true)]
        public bool UseDays
        {
            get { return _useDays; }
            set { _useDays = value; }
        }

        private bool _useWeeks = true;
        [XmlElement("UseWeeks")]
        [DefaultValue(true)]
        public bool UseWeeks
        {
            get { return _useWeeks; }
            set { _useWeeks = value; }
        }

        private bool _useMonthes = true;
        [XmlElement("UseMonthes")]
        [DefaultValue(true)]
        public bool UseMonthes
        {
            get { return _useMonthes; }
            set { _useMonthes = value; }
        }

        private bool _useYears = true;
        [XmlElement("UseYears")]
        [DefaultValue(true)]
        public bool UseYears
        {
            get { return _useYears; }
            set { _useYears = value; }
        }

        private bool _calcEveryYear = true;
        [XmlElement("CalcEveryYear")]
        [DefaultValue(true)]
        public bool CalcEveryYear
        {
            get { return _calcEveryYear; }
            set { _calcEveryYear = value; }
        }

        private int _previousDaysQuantity = 7;
        [XmlElement("PreviousDaysQuantity")]
        [DefaultValue(7)]
        public int PreviousDaysQuantity
        {
            get { return _previousDaysQuantity; }
            set { _previousDaysQuantity = value; }
        }

        private int _nextDaysQuantity = 30;
        [XmlElement("NextDaysQuantity")]
        [DefaultValue(30)]
        public int NextDaysQuantity
        {
            get { return _nextDaysQuantity; }
            set { _nextDaysQuantity = value; }
        }

        private int _recountDaysQuantity = 7;
        [XmlElement("RecountDaysQuantity")]
        [DefaultValue(7)]
        public int RecountDaysQuantity
        {
            get { return _recountDaysQuantity; }
            set { _recountDaysQuantity = value; }
        }

        private DateTime _lastRecalcDate = DateTime.MinValue;
        [XmlElement("LastRecalcDate")]
        public DateTime LastRecalcDate
        {
            get { return _lastRecalcDate; }
            set { _lastRecalcDate = value; }
        }

        private int _secondsStep = 0;
        [XmlElement("SecondsStep")]
        [DefaultValue(0)]
        public int SecondsStep
        {
            get { return _secondsStep; }
            set { _secondsStep = value; }
        }

        private bool _useSecondsStep = true;
        [XmlElement("UseSecondsStep")]
        [DefaultValue(true)]
        public bool UseSecondsStep
        {
            get { return _useSecondsStep; }
            set { _useSecondsStep = value; }
        }

        private int _minutesStep = 0;
        [XmlElement("MinutesStep")]
        [DefaultValue(0)]
        public int MinutesStep
        {
            get { return _minutesStep; }
            set { _minutesStep = value; }
        }

        private bool _useMinutesStep = true;
        [XmlElement("UseMinutesStep")]
        [DefaultValue(true)]
        public bool UseMinutesStep
        {
            get { return _useMinutesStep; }
            set { _useMinutesStep = value; }
        }

        private int _hoursStep = 0;
        [XmlElement("HoursStep")]
        [DefaultValue(0)]
        public int HoursStep
        {
            get { return _hoursStep; }
            set { _hoursStep = value; }
        }

        private bool _useHoursStep = true;
        [XmlElement("UseHoursStep")]
        [DefaultValue(true)]
        public bool UseHoursStep
        {
            get { return _useHoursStep; }
            set { _useHoursStep = value; }
        }

        private int _daysStep = 0;
        [XmlElement("DaysStep")]
        [DefaultValue(0)]
        public int DaysStep
        {
            get { return _daysStep; }
            set { _daysStep = value; }
        }

        private bool _useDaysStep = true;
        [XmlElement("UseDaysStep")]
        [DefaultValue(true)]
        public bool UseDaysStep
        {
            get { return _useDaysStep; }
            set { _useDaysStep = value; }
        }

        private int _weeksStep = 0;
        [XmlElement("WeeksStep")]
        [DefaultValue(0)]
        public int WeeksStep
        {
            get { return _weeksStep; }
            set { _weeksStep = value; }
        }

        private bool _useWeeksStep = true;
        [XmlElement("UseWeeksStep")]
        [DefaultValue(true)]
        public bool UseWeeksStep
        {
            get { return _useWeeksStep; }
            set { _useWeeksStep = value; }
        }

        private int _monthesStep = 0;
        [XmlElement("MonthesStep")]
        [DefaultValue(0)]
        public int MonthesStep
        {
            get { return _monthesStep; }
            set { _monthesStep = value; }
        }

        private bool _useMonthesStep = true;
        [XmlElement("UseMonthesStep")]
        [DefaultValue(true)]
        public bool UseMonthesStep
        {
            get { return _useMonthesStep; }
            set { _useMonthesStep = value; }
        }

        private bool _useExponentCalc = true;
        [XmlElement("UseExponentCalc")]
        [DefaultValue(true)]
        public bool UseExponentCalc
        {
            get { return _useExponentCalc; }
            set { _useExponentCalc = value; }
        }

        private bool _useSameDigitsCalc = true;
        [XmlElement("UseSameDigitsCalc")]
        [DefaultValue(true)]
        public bool UseSameDigitsCalc
        {
            get { return _useSameDigitsCalc; }
            set { _useSameDigitsCalc = value; }
        }

        private string _midNums = "2.5;7.5";
        [XmlElement("MidNumsString")]
        [DefaultValue("2.5;7.5")]
        public string MidNumsString
        {
            get { return _midNums; }
            set { _midNums = value; }
        }

        private string _contactSort = "По именам";
        [XmlElement("ContactSort")]
        [DefaultValue("По именам")]
        public string ContactSort
        {
            get { return _contactSort; }
            set { _contactSort = value; }
        }

        private AvailableLocalizations _currentLocalization = AvailableLocalizations.English;
        [DefaultValue(AvailableLocalizations.English)]
        public AvailableLocalizations CurrentLocalization
        {
            get { return _currentLocalization; }
            set { _currentLocalization = value; }
        }

        [XmlIgnore]
        public List<double> MidNums
        {
            get
            {
                List<double> result = new List<double>();
                string midNums = _midNums.Replace(',', '.');
                string[] splitNums = midNums.Split(';');
                for (int i = 0; i < splitNums.Length; i++)
                {
                    double num = 0;
                    if (double.TryParse(splitNums[i], System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out num))
                        result.Add(num);
                }

                return result;
            }
        }

        public void Save()
        {
            XmlSerializeHelper.SerializeAndSave(fileName, this);
        }

        public static Settings Load()
        {
            try
            {
                return fileName.LoadAndDeserialize<Settings>();
            }
            catch
            {
                return new Settings();
            }
        }

        internal CultureInfo GetCulture()
        {
            return new CultureInfo(EnumHelper.GetEnumDescription(CurrentLocalization));
        }

        internal void SetCulture(AvailableLocalizations newLocalization)
        {
            CurrentLocalization = newLocalization;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(EnumHelper.GetEnumDescription(CurrentLocalization));
        }
    }
}
