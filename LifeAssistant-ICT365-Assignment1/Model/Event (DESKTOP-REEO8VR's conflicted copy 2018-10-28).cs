using System.Xml.Serialization;

namespace mynevermore.LifeAssistant 
{
    public abstract class Event
    {
        protected int Id { get; set; }
        protected string Type { get; set; }
        protected string Name { get; set; }
        protected string Address { get; set; }
        protected string Notes { get; set; }
        protected double Latitude { get; set; }
        protected double Longitude { get; set; }
        protected string Date { get; set; }
        protected int[] Related { get; set; }
        protected string FileAttached { get; set; }
        protected bool TrueFalse { get; set; }

        protected Event(int i, string t, string tle, string n, string a, double lat, double lon, string d, int[] r, string fa, bool tf)
        {
            Id = i;
            Type = t;
            Name = tle;
            Notes = n;
            Address = a;
            Latitude = lat;
            Longitude = lon;
            Date = d;
            Related = r;
            FileAttached = fa;
            TrueFalse = tf;
        }
    }

    public class Appointment : Event
    {
        public string RecurWhen { get; set; }
        public string Time { get; set; }

        public Appointment(int i, string t, string tle, string n, string a, double lat, double lon, string d, int[] r, string fa, bool rec, string recwhen, string ti) :
            base(i, t, tle, n, a, lat, lon, d, r, fa, rec)
        {
            RecurWhen = recwhen;
            Time = ti;
        }
    }

    public class Memory : Event
    {
        public string ReminderDate { get; set; }

        Memory(int i, string t, string tle, string n, string a, double lat, double lon, string d, int[] r, string fa, bool rem, string remdate) :
            base(i, t, tle, n, a, lat, lon, d, r, fa, rem)
        {
            ReminderDate = remdate;
        }
    }

    public class Person : Event
    {
        public string Relationship { get; set; }

        public Person(int i, string t, string tle, string n, string a, double lat, double lon, string d, int[] r, string fa, string relate) :
            base(i, t, tle, n, a, lat, lon, d, r, fa, false)
        {
            Relationship = relate;
        }
    }

    public class Task : Event
    {
        public Task(int i, string t, string tle, string n, string a, double lat, double lon, string d, int[] r, string fa, bool comp) :
                base(i, t, tle, n, a, lat, lon, d, r, fa, comp)
        {
        }
    }
}