using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;

namespace LifeTime.Classes
{
    public class Contact
    {
        private int _id;
        private string _fio;
        private DateTime _birthDate = DateTime.MinValue;
        private string _info;

        [XmlElement("Id")]
        [DefaultValue(0)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [XmlElement("Fio")]
        [DefaultValue("")]
        public string Fio
        {
            get { return _fio; }
            set { _fio = value; }
        }

        [XmlElement("BirthDate")]
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        [XmlIgnore]
        public string BirthDateString
        {
            get { return _birthDate.ToString("dd.MM.yyyy HH:mm"); }
        }

        [XmlElement("Info")]
        [DefaultValue("")]
        public string Info
        {
            get { return _info; }
            set { _info = value; }
        }

        public Contact()
        { }

        public Contact(string fio, DateTime birthDate, string info)
        {
            _fio = fio;
            _birthDate = birthDate;
            _info = info;
        }

        public override string ToString()
        {
            return _fio;
        }

        public static int ComparerByFio(Contact a, Contact b)
        {
            return string.Compare(a.Fio, b.Fio);
        }

        public static int ComparerByDate(Contact a, Contact b)
        {
            DateTime aDate = new DateTime(2000, a.BirthDate.Month, a.BirthDate.Day, a.BirthDate.Hour, a.BirthDate.Minute, a.BirthDate.Second);
            DateTime bDate = new DateTime(2000, b.BirthDate.Month, b.BirthDate.Day, b.BirthDate.Hour, b.BirthDate.Minute, b.BirthDate.Second);

            return DateTime.Compare(aDate, bDate);
        }
    }

    [XmlRoot("ContactCollection")]
    public class ContactCollection
    {
        private static string fileName = "Contacts.xml";
        private List<Contact> _contacts;
        private Dictionary<int, Contact> _contactDictionary;

        [XmlArray("Contacts"), XmlArrayItem("Contact")]
        public List<Contact> Contacts
        {
            get { return _contacts; }
            set { _contacts = value; }
        }

        public ContactCollection()
        {
            _contacts = new List<Contact>();
            _contactDictionary = new Dictionary<int, Contact>();
        }

        /*public Contact Add(string name, DateTime birthDate, string info)
        {
            Contact contact = new Contact(name, birthDate, info);
            return Add(contact);
        }*/

        public Contact Add(Contact contact, string sortOrder)
        {
            contact.Id = GetNextId();
            _contacts.Add(contact);
            _contactDictionary.Add(contact.Id, contact);
            Sort(sortOrder);
            return contact;
        }

        public Contact Get(int id)
        {
            if (_contactDictionary.ContainsKey(id))
                return _contactDictionary[id];
            return null;
        }

        public void Remove(Contact contact)
        {
            if (_contactDictionary.ContainsKey(contact.Id))
                _contactDictionary.Remove(contact.Id);
            _contacts.Remove(contact);
        }

        public void ShiftTime(bool forward, TimeSpan timeShift)
        {
            if (forward)
                foreach (Contact contact in _contacts)
                    contact.BirthDate = contact.BirthDate + timeShift;
            else
                foreach (Contact contact in _contacts)
                    contact.BirthDate = contact.BirthDate - timeShift;
        }

        public void Sort(string order)
        {
            if (order == "По именам")
                Contacts.Sort(Contact.ComparerByFio);
            else if (order == "По датам")
                Contacts.Sort(Contact.ComparerByDate);
        }

        private int GetNextId()
        {
            int result = 0;
            foreach (int id in _contactDictionary.Keys)
                if (result < id)
                    result = id;

            return ++result;
        }


        public void Save()
        {
            XmlSerializeHelper.SerializeAndSave(fileName, this);
        }

        public static ContactCollection Load()
        {
            ContactCollection result;

            try
            {
                result = fileName.LoadAndDeserialize<ContactCollection>();
            }
            catch
            {
                return new ContactCollection();
            }

            List<Contact> toChangeId = new List<Contact>();

            foreach (Contact contact in result._contacts)
                if (result._contactDictionary.ContainsKey(contact.Id))
                    toChangeId.Add(contact);
                else
                    result._contactDictionary[contact.Id] = contact;

            foreach (Contact contact in toChangeId)
            {
                contact.Id = result.GetNextId();
                result._contactDictionary[contact.Id] = contact;
            }

            return result;
        }
    }
}
