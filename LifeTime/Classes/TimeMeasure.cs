using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;

namespace LifeTime.Classes
{
    public class TimeMeasure
    {
        private int _id;
        private string _name;
        private Dictionary<Measure, string> _strings;
        private TimeSpan _duration;

        [XmlElement("Id")]
        [DefaultValue(0)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [XmlElement("Name")]
        [DefaultValue("")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [XmlIgnore]
        public Dictionary<Measure, string> Strings
        {
            get { return _strings; }
            set { _strings = value; }
        }

        [XmlArray("Strings"), XmlArrayItem("String")]
        public List<DictionaryItem> StringsList
        {
            get
            {
                List<DictionaryItem> result = new List<DictionaryItem>();
                foreach (Measure key in _strings.Keys)
                    result.Add(new DictionaryItem() { Id = (int)key, String = _strings[key] });
                return result;
            }
            set
            {
                _strings = new Dictionary<Measure, string>();
                foreach (DictionaryItem item in value)
                    _strings.Add((Measure)item.Id, item.String);
            }
        }

        [XmlElement("Duration")]
        public TimeSpan Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public TimeMeasure()
        {
            _strings = new Dictionary<Measure, string>();
        }

        public TimeMeasure(string name, TimeSpan duration)
            : this()
        {
            _name = name;
            _duration = duration;
        }

        public override string ToString()
        {
            return _name;
        }

        public string ToString(uint quantity)
        {
            int modulo = (int)(quantity % 100);

            Measure measure;

            if ((modulo > 4 && modulo <= 20) || modulo % 10 == 0 || modulo % 10 > 4)
                measure = Measure.Many;
            else if (modulo % 10 == 1)
                measure = Measure.One;
            else
                measure = Measure.Few;

            if (_strings.ContainsKey(measure))
                return _strings[measure];
            else
                return _name;
        }
    }

    [XmlRoot("TimeMeasureCollection")]
    public class TimeMeasureCollection
    {
        private static string fileName = "TimeMeasures.xml";
        private List<TimeMeasure> _timeMeasures;
        private Dictionary<int, TimeMeasure> _timeMeasureDictionary;

        [XmlArray("TimeMeasures"), XmlArrayItem("TimeMeasure")]
        public List<TimeMeasure> TimeMeasures
        {
            get { return _timeMeasures; }
            set { _timeMeasures = value; }
        }

        public TimeMeasureCollection()
        {
            _timeMeasures = new List<TimeMeasure>();
            _timeMeasureDictionary = new Dictionary<int, TimeMeasure>();
        }

        public TimeMeasure Add(string name, TimeSpan duration)
        {
            TimeMeasure timeMeasure = new TimeMeasure(name, duration);
            timeMeasure.Id = GetNextId();
            _timeMeasures.Add(timeMeasure);
            _timeMeasureDictionary.Add(timeMeasure.Id, timeMeasure);
            return timeMeasure;
        }

        public TimeMeasure Get(int id)
        {
            if (_timeMeasureDictionary.ContainsKey(id))
                return _timeMeasureDictionary[id];
            return null;
        }

        public TimeMeasure Find(string name)
        {
            return _timeMeasures.Find(tm => tm.Name == name);
        }

        private int GetNextId()
        {
            int result = 0;
            foreach (int id in _timeMeasureDictionary.Keys)
                if (result < id)
                    result = id;

            return ++result;
        }

        public void Save()
        {
            XmlSerializeHelper.SerializeAndSave(fileName, this);
        }

        public static TimeMeasureCollection Load()
        {
            TimeMeasureCollection result;

            try
            {
                result = fileName.LoadAndDeserialize<TimeMeasureCollection>();
            }
            catch
            {
                return new TimeMeasureCollection();
            }

            List<TimeMeasure> toChangeId = new List<TimeMeasure>();

            foreach (TimeMeasure timeMeasure in result._timeMeasures)
                if (result._timeMeasureDictionary.ContainsKey(timeMeasure.Id))
                    toChangeId.Add(timeMeasure);
                else
                    result._timeMeasureDictionary[timeMeasure.Id] = timeMeasure;

            foreach (TimeMeasure timeMeasure in toChangeId)
            {
                timeMeasure.Id = result.GetNextId();
                result._timeMeasureDictionary[timeMeasure.Id] = timeMeasure;
            }

            return result;
        }

        public static TimeMeasureCollection Generate()
        {
            TimeMeasureCollection result = new TimeMeasureCollection();

            TimeMeasure seconds = result.Add("Seconds", TimeSpan.FromSeconds(1));
            seconds.Strings.Add(Measure.One, "секунда");
            seconds.Strings.Add(Measure.Few, "секунды");
            seconds.Strings.Add(Measure.Many, "секунд");

            TimeMeasure minutes = result.Add("Minutes", TimeSpan.FromMinutes(1));
            minutes.Strings.Add(Measure.One, "минута");
            minutes.Strings.Add(Measure.Few, "минуты");
            minutes.Strings.Add(Measure.Many, "минут");

            TimeMeasure hours = result.Add("Hours", TimeSpan.FromHours(1));
            hours.Strings.Add(Measure.One, "час");
            hours.Strings.Add(Measure.Few, "часа");
            hours.Strings.Add(Measure.Many, "часов");

            TimeMeasure days = result.Add("Days", TimeSpan.FromDays(1));
            days.Strings.Add(Measure.One, "день");
            days.Strings.Add(Measure.Few, "дня");
            days.Strings.Add(Measure.Many, "дней");

            TimeMeasure weeks = result.Add("Weeks", TimeSpan.FromDays(7));
            weeks.Strings.Add(Measure.One, "неделя");
            weeks.Strings.Add(Measure.Few, "недели");
            weeks.Strings.Add(Measure.Many, "недель");

            TimeMeasure monthes = result.Add("Monthes", TimeSpan.Zero);
            monthes.Strings.Add(Measure.One, "месяц");
            monthes.Strings.Add(Measure.Few, "месяца");
            monthes.Strings.Add(Measure.Many, "месяцев");

            TimeMeasure years = result.Add("Years", TimeSpan.Zero);
            years.Strings.Add(Measure.One, "год");
            years.Strings.Add(Measure.Few, "года");
            years.Strings.Add(Measure.Many, "лет");

            return result;
        }
    }

    public enum Measure
    {
        One = 1,
        Few = 2,
        Many = 5
    }

    public class DictionaryItem
    {
        [XmlElement("Id")]
        public int Id { get; set; }
        [XmlElement("String")]
        public string String { get; set; }
    }
}
