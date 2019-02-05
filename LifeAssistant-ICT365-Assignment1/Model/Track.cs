using System.Collections.Generic;
using System.Xml.Serialization;

namespace LifeAssistant_ICT365_Assignment1.Model
{
    [XmlRoot(ElementName ="lle:track")]
    public class Trail
    {
        [XmlElement(ElementName = "lle:trackid")]
        public string Trackid { get; set; }
        [XmlElement(ElementName ="lle:name")]
        public string TrackName { get; set; }
        [XmlElement(ElementName ="lle:points")]
        public List<Pointer> points { get; set; }
    }

    [XmlRoot(ElementName ="lle:point")]
    public class Pointer
    {
        [XmlAttribute(AttributeName ="latitude")]
        public double Latitude { get; set; }
        [XmlAttribute(AttributeName = "longitude")]
        public double Longitude { get; set; }
    }
}
