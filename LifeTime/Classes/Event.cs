using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;

namespace Days
{
    [Serializable]
    public class DateEvent
    {
        private int _id;
        private DateTime _date = DateTime.MinValue;
        private Contact _contact;
        private int _contactId;
        private uint _quantity;
        private TimeMeasure _timeMeasure;
        private int _timeMeasureId;

        [XmlElement("Id")]
        [DefaultValue(0)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [XmlElement("Date")]
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        [XmlIgnore]
        public string DateString
        {
            get { return _date.ToString("dd.MM.yyyy HH:mm"); }
        }

        [XmlIgnore]
        public string Info { get { return "" + _quantity.ToString("N0") + " " + _timeMeasure.ToString(_quantity); } }

        [XmlIgnore]
        public Contact Contact
        {
            get { return _contact; }
            set { _contact = value; }
        }

        [XmlElement("ContactId")]
        [DefaultValue(-1)]
        public int ContactId
        {
            get { return Contact != null ? Contact.Id : _contactId; }
            set { _contactId = value; }
        }

        [XmlElement("Quantity")]
        [DefaultValue(0)]
        public uint Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        [XmlIgnore]
        public TimeMeasure TimeMeasure
        {
            get { return _timeMeasure; }
            set { _timeMeasure = value; }
        }

        [XmlElement("TimeMeasureId")]
        [DefaultValue(-1)]
        public int TimeMeasureId
        {
            get { return TimeMeasure != null ? TimeMeasure.Id : _timeMeasureId; }
            set { _timeMeasureId = value; }
        }

        public DateEvent()
        { }

        public DateEvent(Contact contact, DateTime date, TimeMeasure timeMeasure, uint quantity)
        {
            _contact = contact;
            _date = date;
            _timeMeasure = timeMeasure;
            _quantity = quantity;
        }

        public static int Comparer(DateEvent a, DateEvent b)
        {
            return DateTime.Compare(a.Date, b.Date);
        }
    }

    [XmlRoot("DateEventCollection")]
    public class DateEventCollection
    {
        private static string fileName = "DateEvents.xml";
        private List<DateEvent> _dateEvents;
        private Dictionary<int, DateEvent> _dateEventDictionary;

        [XmlArray("DateEvents"), XmlArrayItem("DateEvent")]
        public List<DateEvent> DateEvents
        {
            get { return _dateEvents; }
            set { _dateEvents = value; }
        }

        public DateEventCollection()
        {
            _dateEvents = new List<DateEvent>();
            _dateEventDictionary = new Dictionary<int, DateEvent>();
        }


        public void Add(Contact contact, TimeMeasureCollection timeMeasures, Settings settings)
        {
            TimeMeasure timeMeasure;
            if (settings.UseSeconds)
            {
                timeMeasure = timeMeasures.Find("Seconds");
                if (timeMeasure != null)
                    CalculateEvents(contact, timeMeasure, settings);
            }
            if (settings.UseMinutes)
            {
                timeMeasure = timeMeasures.Find("Minutes");
                if (timeMeasure != null)
                    CalculateEvents(contact, timeMeasure, settings);
            }
            if (settings.UseHours)
            {
                timeMeasure = timeMeasures.Find("Hours");
                if (timeMeasure != null)
                    CalculateEvents(contact, timeMeasure, settings);
            }
            if (settings.UseDays)
            {
                timeMeasure = timeMeasures.Find("Days");
                if (timeMeasure != null)
                    CalculateEvents(contact, timeMeasure, settings);
            }
            if (settings.UseWeeks)
            {
                timeMeasure = timeMeasures.Find("Weeks");
                if (timeMeasure != null)
                    CalculateEvents(contact, timeMeasure, settings);
            }
            if (settings.UseMonthes)
            {
                timeMeasure = timeMeasures.Find("Monthes");
                if (timeMeasure != null)
                    CalculateLongEvents(contact, timeMeasure, settings);
            }
            if (settings.UseYears)
            {
                timeMeasure = timeMeasures.Find("Years");
                if (timeMeasure != null)
                    CalculateLongEvents(contact, timeMeasure, settings);
            }
        }

        public void Remove(Contact contact)
        {
            List<DateEvent> toDelete = _dateEvents.FindAll(de => de.ContactId == contact.Id);
            _dateEvents.RemoveAll(de => de.ContactId == contact.Id);
            foreach (DateEvent dateEvent in toDelete)
                _dateEventDictionary.Remove(dateEvent.Id);
        }

        public void Recalc(ContactCollection contacts, TimeMeasureCollection timeMeasures, Settings settings)
        {
            _dateEvents.Clear();
            _dateEventDictionary.Clear();
            foreach (Contact contact in contacts.Contacts)
                Add(contact, timeMeasures, settings);
        }

        public List<DateEvent> GetTodayEvents()
        {
            return _dateEvents.FindAll(de => de.Date.Date == DateTime.Now.Date);
        }

        public List<DateEvent> GetFutureEvents()
        {
            return _dateEvents.FindAll(de => de.Date.Date >= DateTime.Today);
        }

        public List<DateEvent> GetPastEvents()
        {
            return _dateEvents.FindAll(de => de.Date.Date < DateTime.Today);
        }


        public void Save()
        {
            XmlSerializeHelper.SerializeAndSave(fileName, this);
        }

        public static DateEventCollection Load(TimeMeasureCollection timeMeasures, ContactCollection contacts)
        {
            DateEventCollection result;
            try
            {
                result = fileName.LoadAndDeserialize<DateEventCollection>();
            }
            catch
            {
                return new DateEventCollection();
            }

            List<DateEvent> toChangeId = new List<DateEvent>();

            foreach (DateEvent dateEvent in result.DateEvents)
            {
                dateEvent.TimeMeasure = timeMeasures.Get(dateEvent.TimeMeasureId);
                dateEvent.Contact = contacts.Get(dateEvent.ContactId);
                if (result._dateEventDictionary.ContainsKey(dateEvent.Id))
                    toChangeId.Add(dateEvent);
                else
                    result._dateEventDictionary[dateEvent.Id] = dateEvent;
            }

            foreach (DateEvent dateEvent in toChangeId)
            {
                dateEvent.Id = result.GetNextId();
                result._dateEventDictionary[dateEvent.Id] = dateEvent;
            }

            return result;
        }


        private int GetNextId()
        {
            int result = 0;
            foreach (int id in _dateEventDictionary.Keys)
                if (result < id)
                    result = id;

            return ++result;
        }

        private DateEvent Add(Contact contact, DateTime date, TimeMeasure timeMeasure, uint quantity)
        {
            if (_dateEvents.Exists(de => de.Contact.Id == contact.Id && de.Quantity == quantity && de.TimeMeasure.Id == timeMeasure.Id))
                return null;

            DateEvent dateEvent = new DateEvent(contact, date, timeMeasure, quantity);
            dateEvent.Id = GetNextId();
            _dateEvents.Add(dateEvent);
            _dateEventDictionary.Add(dateEvent.Id, dateEvent);
            _dateEvents.Sort(DateEvent.Comparer);
            return dateEvent;
        }

        private void CalculateEvents(Contact contact, TimeMeasure timeMeasure, Settings settings)
        {
            DateTime date = contact.BirthDate;
            DateTime maxDate = DateTime.Now + TimeSpan.FromDays(settings.NextDaysQuantity);
            DateTime minDate = DateTime.Now - TimeSpan.FromDays(settings.PreviousDaysQuantity);

            if (settings.UseExponentCalc)
            {
                uint baseCount = 1;
                date += TimeSpan.FromTicks(timeMeasure.Duration.Ticks * baseCount);
                while (date < maxDate)
                {
                    for (uint i = 1; i < 10; i++)
                    {
                        if (date > minDate && date < maxDate)
                            Add(contact, date, timeMeasure, i * baseCount);
                        date += TimeSpan.FromTicks(timeMeasure.Duration.Ticks * baseCount);
                        if (date > maxDate)
                            break;
                    }
                    baseCount *= 10;
                }
            }
            if (settings.UseSameDigitsCalc)
            {
                int exponent = 1;
                date = contact.BirthDate;

                while (date < maxDate)
                {
                    uint num = 0;
                    for (int i = 0; i < exponent; i++)
                        num += (uint)Math.Pow(10, i);
                    exponent++;

                    date = contact.BirthDate;
                    for (uint i = 1; i < 10; i++)
                    {
                        date += TimeSpan.FromTicks(timeMeasure.Duration.Ticks * num);
                        if (date > minDate && date < maxDate)
                            Add(contact, date, timeMeasure, i * num);
                        if (date > maxDate)
                            break;
                    }
                }
            }
            foreach (double num in settings.MidNums)
            {
                uint baseCount = 1;
                while (contact.BirthDate.AddTicks(timeMeasure.Duration.Ticks * baseCount) < maxDate)
                {
                    uint controlNum = (uint)(baseCount * num);
                    if ((double)controlNum == baseCount * num)
                    {
                        DateTime midDate = contact.BirthDate.AddTicks(timeMeasure.Duration.Ticks * controlNum);
                        if (midDate > minDate && midDate < maxDate)
                            Add(contact, midDate, timeMeasure, controlNum);
                    }
                    baseCount *= 10;
                }
            }
        }

        private void CalculateLongEvents(Contact contact, TimeMeasure timeMeasure, Settings settings)
        {
            if (timeMeasure.Name != "Monthes" && timeMeasure.Name != "Years")
                return;

            DateTime date = contact.BirthDate;
            DateTime maxDate = DateTime.Now + TimeSpan.FromDays(settings.NextDaysQuantity);
            DateTime minDate = DateTime.Now - TimeSpan.FromDays(settings.PreviousDaysQuantity);

            if (settings.UseExponentCalc)
            {
                int baseCount = 1;
                while (date < maxDate)
                {
                    if (timeMeasure.Name == "Years" && settings.CalcEveryYear)
                    {
                        date = date.AddYears(1);
                        if (date > minDate && date < maxDate)
                            Add(contact, date, timeMeasure, (uint)baseCount);
                        baseCount++;
                    }
                    else
                    {
                        for (int i = 1; i <= 10; i++)
                        {
                            if (timeMeasure.Name == "Monthes")
                                date = date.AddMonths(baseCount);
                            else if (timeMeasure.Name == "Years")
                                date = date.AddYears(baseCount);

                            if (date > minDate && date < maxDate)
                                Add(contact, date, timeMeasure, (uint)(i * baseCount));
                            if (date > maxDate)
                                break;
                        }

                        baseCount *= 10;
                    }
                }
            }

            if (settings.UseSameDigitsCalc)
            {
                int exponent = 1;
                date = contact.BirthDate;

                while (date < maxDate)
                {
                    int num = 0;
                    for (int i = 0; i < exponent; i++)
                        num += (int)Math.Pow(10, i);
                    exponent++;

                    date = contact.BirthDate;
                    for (uint i = 1; i < 10; i++)
                    {
                        if (timeMeasure.Name == "Monthes")
                            date = date.AddMonths(num);
                        else if (timeMeasure.Name == "Years")
                            date = date.AddYears(num);

                        if (date > minDate && date < maxDate)
                            Add(contact, date, timeMeasure, (uint)(i * num));
                        if (date > maxDate)
                            break;
                    }
                }
            }
            foreach (double num in settings.MidNums)
            {
                int baseCount = 1;
                while ((timeMeasure.Name == "Monthes" && contact.BirthDate.AddMonths(baseCount) < maxDate) ||
                    (timeMeasure.Name == "Years" && contact.BirthDate.AddYears(baseCount) < maxDate))
                {
                    int controlNum = (int)(baseCount * num);
                    if ((double)controlNum == baseCount * num)
                    {
                        DateTime midDate = DateTime.MinValue;
                        if (timeMeasure.Name == "Monthes")
                            midDate = contact.BirthDate.AddMonths(controlNum);
                        else if (timeMeasure.Name == "Years")
                            midDate = contact.BirthDate.AddYears(controlNum);
                        if (midDate > minDate && midDate < maxDate)
                            Add(contact, midDate, timeMeasure, (uint)controlNum);
                    }
                    baseCount *= 10;
                }
            }
        }
    }
}
