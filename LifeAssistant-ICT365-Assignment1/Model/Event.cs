using System.Xml.Serialization;

namespace LifeAssistant_ICT365_Assignment1
{
    public abstract class Event
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected string Address { get; set; }
        protected string Notes { get; set; }
        protected double Latitude { get; set; }
        protected double Longitude { get; set; }
        protected string Date { get; set; }
        protected string FileAttached { get; set; }
        protected bool TrueFalse { get; set; }

        protected Event(int i, string tle, string n, string a, double lat, double lon, string d, string fa, bool tf)
        {
            Id = i;
            Name = tle;
            Notes = n;
            Address = a;
            Latitude = lat;
            Longitude = lon;
            Date = d;
            FileAttached = fa;
            TrueFalse = tf;
        }
    }

    public class Appointment : Event
    {
        public string RecurWhen { get; set; }
        public string Time { get; set; }

        public Appointment(int i, string tle, string n, string a, double lat, double lon, string d, string fa, bool rec, string recwhen, string ti) :
            base(i, tle, n, a, lat, lon, d, fa, rec)
        {
            RecurWhen = recwhen;
            Time = ti;
        }
    }

    public class Memory : Event
    {
        public string ReminderDate { get; set; }

        Memory(int i, string tle, string n, string a, double lat, double lon, string d, string fa, bool rem, string remdate) :
            base(i, tle, n, a, lat, lon, d, fa, rem)
        {
            ReminderDate = remdate;
        }
    }

    public class Person : Event
    {
        public string Relationship { get; set; }

        public Person(int i, string tle, string n, string a, double lat, double lon, string d, string fa, string relate) :
            base(i, tle, n, a, lat, lon, d, fa, false)
        {
            Relationship = relate;
        }
    }

    public class Task : Event
    {
        public Task(int i, string tle, string n, string a, double lat, double lon, string d, string fa, bool comp) :
                base(i, tle, n, a, lat, lon, d, fa, comp)
        {
        }
    }
}