using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIOStopsVisualization
{
    public partial class StartWindow : Form
    {
        public MIOApp app;
        public StartWindow()
        {
            InitializeComponent();
            app = new MIOApp();

            //ReadFile();

            var options = new List<String>();
            options.Add(" ");
            options.Add("Estaciones");
            options.Add("Paradas");
            options.Add("Zonas");
            this.optionComBox.DataSource = options;

            this.optionComBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public MIOApp GetApp()
        {
            return app;
        }

        public void ReadFile()
        {
            try
            {
                int i = 0;
                string line = "";
                StreamReader sr = new StreamReader("data/stops.csv");
                //var watch = System.Diagnostics.Stopwatch.StartNew();
                while ((line = sr.ReadLine()) != null)
                {
                    int type = 0;
                    String[] individual = line.Split(',');

                    double lat = double.Parse(individual[7], CultureInfo.InvariantCulture);
                    double lon = double.Parse(individual[6], CultureInfo.InvariantCulture);

                    if (individual[3].Contains("con") || individual[3].Contains("entre"))
                    {
                        type = 1;
                    }
                    else
                    {
                        type = 2;
                    }
                    Stop st = new Stop(individual[0], type, individual[2], individual[3], lon, lat);

                    if (type==1) {
                        app.getStreetStop().Add(st);
                    }
                    else
                    {
                        app.getStationStop().Add(st);
                    }
                    i++;
                }
                app.saveElements();
                //watch.Stop();
                //var elapsedMs = watch.ElapsedMilliseconds;
                //var timef = elapsedMs * 0.001;
            }
            catch (Exception e)
            { 
                MessageBox.Show(e.Message);
            }
        }


        private void StopMap_Load(object sender, EventArgs e)
        {
            stopMap.DragButton = MouseButtons.Left;
            stopMap.MapProvider = GMapProviders.GoogleMap;
            double latitud = 3.4372201;
            double longitud = -76.5224991;
            stopMap.Position = new PointLatLng(latitud, longitud);
            stopMap.MinZoom = 1;
            stopMap.MaxZoom = 100;
            stopMap.Zoom = 13;
        }


        private void drawStops()
        {
            stopMap.Overlays.Clear();

            GMapOverlay markers = new GMapOverlay("markers");
            foreach (var aux in GetApp().getStreetStop())
            {
                streetsMarker(aux.DecLati, aux.DecLong);
            }
            stopMap.Overlays.Add(markers);
            MessageBox.Show("Termino de dibujar las paradas");
        }

        private void streetsMarker(double lat, double lng)
        {
            PointLatLng point = new PointLatLng(lat, lng);
            GMapMarker theMarker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);

            GMapOverlay markers = new GMapOverlay("markers");

            markers.Markers.Add(theMarker);
            stopMap.Overlays.Add(markers);
        }

        public void drawStations()
        {
            stopMap.Overlays.Clear();

            foreach (var aux in GetApp().getStationStop())
            {
                stationsMarker(aux.DecLati, aux.DecLong);
            }
            MessageBox.Show("Termino de dibujar las estaciones");
        }

        private void stationsMarker(double lat, double lng)
        {
            PointLatLng point = new PointLatLng(lat, lng);
            GMapMarker theMarker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);

            GMapOverlay markers = new GMapOverlay("markers");

            markers.Markers.Add(theMarker);
            stopMap.Overlays.Add(markers);
        }

        public void drawZones()
        {
            MessageBox.Show("Termino de dibujar las zonas");
        }

        private void OptionComBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            verification();
        }

        private void verification()
        {
            int ind = optionComBox.SelectedIndex;

            if (ind == 1)
            {
                drawStations();
            }
            else if (ind == 2)
            {
                drawStops();
            }
            else if (ind == 3)
            {
                drawZones();
            }
            else
            {

            }
        }

        
    }
}
