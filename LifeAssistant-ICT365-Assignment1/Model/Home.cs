using GoogleMaps.LocationServices;
using System;
using System.Xml.Linq;
using System.Linq;

namespace LifeAssistant_ICT365_Assignment1.Model
{
    public class Home
    {
        private static Home instance = null;
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        private Home() {
        }

        public static Home Instance
        {
            get
            {
                if (instance == null)
                    instance = new Home();

                return instance;
            }
        }

        public void setHome(string addy)
        {
            var address = addy;
            var locationService = new GoogleLocationService("AIzaSyCa - nRilPzCfmKTOGMZnEKEPB3X9w2szGw");
            var point = locationService.GetLatLongFromAddress(address);

            Latitude = point.Latitude;
            Longitude = point.Longitude;
        }

        public void setHome(double lat, double longi)
        {
            Latitude = lat;
            Longitude = longi;
        }

        public void setHome(XDocument events, XNamespace lle)
        {
            var childlat = events.Descendants(lle+"Home").Descendants(lle+"latitude").Single().Value;
            var childlong = events.Descendants(lle+"Home").Descendants(lle+"longitude").Single().Value;

            Latitude = Convert.ToDouble(childlat);
            Longitude = Convert.ToDouble(childlong);
        }
    }
}
