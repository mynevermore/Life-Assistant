using System;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using LifeAssistant_ICT365_Assignment1.Model;
using LifeAssistant_ICT365_Assignment1.View;
using GoogleMaps.LocationServices;
using System.Xml.Linq;
using System.Collections.Generic;

namespace LifeAssistant_ICT365_Assignment1
{
    public partial class Viewer : Form
    {
        Home home = Home.Instance;

        GMapOverlay tempMarkers = new GMapOverlay("tempMarkers");
        GMapOverlay allMarkers = new GMapOverlay("allMarkers");
        GMapOverlay calMarkers = new GMapOverlay("calMarkers");
        GMapOverlay peopleMarkers = new GMapOverlay("peopleMarkers");
        GMapOverlay taskMarkers = new GMapOverlay("taskMarkers");
        GMapOverlay routes = new GMapOverlay("routes");
        XDocument events;
        XNamespace lle = "http://www.xyz.org/lifelogevents";

        private static Viewer aView = null;
        private Slide routeP;
        private Slide menuP;
        private Slide calendarP;
        private Slide peopleP;
        private Slide taskP;
        private Slide settingsP;

        internal Slide MenuP { get => menuP; set => menuP = value; }
        internal Slide CalendarP { get => calendarP; set => calendarP = value; }
        internal Slide PeopleP { get => peopleP; set => peopleP = value; }
        internal Slide TaskP { get => taskP; set => taskP = value; }
        internal Slide SettingsP { get => settingsP; set => settingsP = value; }
        internal Slide RouteP { get => routeP; set => routeP = value; }

        public static Viewer Instance()
        {
            if (aView == null)
            {
                aView = new Viewer();
            }
            return aView;
        }

        private Viewer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLibrary();

            gmap.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gmap.Position = new PointLatLng(home.Latitude, home.Longitude);
            gmap.ShowCenter = false;

            ButtonColours();
            InitialisePanes();
            Running();
        }

        private void LoadLibrary()
        {
            events = XDocument.Load("../../Resources/events.xml");
            home.setHome(events, lle);


        }

        private void ButtonColours()
        {
            menuButton.MouseEnter += OnMouseEnterButton;
            homeButton.MouseEnter += OnMouseEnterButton;
            peopleButton.MouseEnter += OnMouseEnterButton;
            toDoButton.MouseEnter += OnMouseEnterButton;
            calendarButton.MouseEnter += OnMouseEnterButton;
            helpButton.MouseEnter += OnMouseEnterButton;
            settingsButton.MouseEnter += OnMouseEnterButton;
            routeButton.MouseEnter += OnMouseEnterButton;

            menuButton.MouseLeave += OnMouseLeaveButton;
            homeButton.MouseLeave += OnMouseLeaveButton;
            peopleButton.MouseLeave += OnMouseLeaveButton;
            toDoButton.MouseLeave += OnMouseLeaveButton;
            calendarButton.MouseLeave += OnMouseLeaveButton;
            helpButton.MouseLeave += OnMouseLeaveButton;
            settingsButton.MouseLeave += OnMouseLeaveButton;
            routeButton.MouseLeave += OnMouseLeaveButton;

            menuButton.MouseDown += OnMouseDownButton;
            homeButton.MouseDown += OnMouseDownButton;
            peopleButton.MouseDown += OnMouseDownButton;
            toDoButton.MouseDown += OnMouseDownButton;
            calendarButton.MouseDown += OnMouseDownButton;
            helpButton.MouseDown += OnMouseDownButton;
            settingsButton.MouseDown += OnMouseDownButton;
            routeButton.MouseLeave += OnMouseLeaveButton;
        }

        internal void AddAppointment(List<object> list)
        {
            throw new NotImplementedException();
        }

        internal void AddMemory(List<object> list)
        {
            throw new NotImplementedException();
        }

        private void OnMouseEnterButton(object sender, EventArgs e)
        {
            var b = (Button)sender;
            b.BackColor = Color.LightSlateGray;
        }

        internal void AddPerson(List<object> list)
        {
            throw new NotImplementedException();
        }

        private void OnMouseLeaveButton(object sender, EventArgs e)
        {
            var b = (Button)sender;
            b.BackColor = Color.Transparent;
        }

        private void OnMouseDownButton(object sender, EventArgs e)
        {
            var b = (Button)sender;
            b.BackColor = Color.SlateBlue;
        }

        private void HelpMessage(object sender, MouseEventArgs e)
        {
            var hb = new HelpBox();
            hb.ShowDialog();

            bool clickedOk = hb.OKButtonClicked;
        }

        internal void AddTask(List<object> list)
        {
            throw new NotImplementedException();
        }

        private void setHome(object sender, EventArgs e)
        {
            try
            {
                home.setHome(HomeLocationBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Please try again.");
            }
        }

        private void Running()
        {
            homeButton.Click += new EventHandler(OnHomeClick);
            SetHomeButton.Click += new EventHandler(setHome);
            LocationSearchButton.Click += new EventHandler(searchLocation);
            NewEvent.Click += new EventHandler(Editing);
            //setRouteButton.Click += new EventHandler(RouteTrack);
        }

        //public void Form1_FormClosing(object sender, EventArgs e)
        //{
        //    XNamespace soap = "http://www.w3.org/2001/12/soap-envelope";

        //    XElement homeNode = new XElement("Home",
        //                            new XElement("latitude", home.Latitude),
        //                            new XElement("longitude", home.Longitude));


        //    XDocument saveDoc = new XDocument(
        //        new XDeclaration("1.0", "utf-8", String.Empty),
        //        new XElement(soap + "Envelope",
        //            new XAttribute(XNamespace.Xmlns + "SOAP-ENV", soap),
        //            new XElement(soap + "Body",
        //                new XAttribute(XNamespace.Xmlns + "lle", lle))),

        //                homeNode,
        //                appointmentNodes,
        //                peopleNodes,
        //                taskNodes,
        //                trackNodes,
        //                memoryNodes
        //    );

        //    saveDoc.Save("../../Resources/events.xml");
        //}

        //private void RouteTrack(object sender, EventArgs e)
        //{
        //    Track tr = new Track();

        //    var track = tr.setRoute();
        //    routes.Routes.Add(track);
        //    gmap.Overlays.Add(routes);
        //    gmap.Refresh();

        //    if (!tr.StartPoint.IsEmpty)
        //    {
        //        gmap.Position = tr.StartPoint;
        //        gmap.Zoom = 15;
        //    }
        //    else
        //    {
        //        gmap.Position = new PointLatLng(home.Latitude, home.Longitude);
        //        gmap.Zoom = 15;
        //    }
        //}

        private void Editing(object sender, EventArgs e)
        {
            var ae = new AddEvent();
            ae.ShowDialog();
        }

        private void searchLocation(object sender, EventArgs e)
        {
            try
            {
                var address = LocationSearch.Text;
                var locationService = new GoogleLocationService("AIzaSyCa-nRilPzCfmKTOGMZnEKEPB3X9w2szGw");
                var point = locationService.GetLatLongFromAddress(address);

                var location = new PointLatLng(point.Latitude, point.Longitude);
                gmap.Position = location;
                gmap.Zoom = 16;
                GMapMarker locMark = new GMarkerGoogle(location, GMarkerGoogleType.blue_pushpin);

                tempMarkers.Markers.Add(locMark);
                gmap.Overlays.Add(tempMarkers);
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid input. Please try again");
            }
        }

        private void InitialisePanes()
        {
            menuP = new Slide(menuPane, menuButton);
            calendarP = new Slide(calendarPane, calendarButton);
            peopleP = new Slide(peoplePane, peopleButton);
            taskP = new Slide(taskPane, toDoButton);
            settingsP = new Slide(settingsPane, settingsButton);
            routeP = new Slide(routePanel, routeButton);
        }

        private void OnHomeClick(object sender, EventArgs e)
        {
            gmap.Position = new PointLatLng(home.Latitude, home.Longitude);
            gmap.Zoom = 15;
        }
    }
}