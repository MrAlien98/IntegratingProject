using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIOStopsVisualization
{
    public partial class MapWindow : Form
    {
        StartWindow st;

        public MapWindow(StartWindow st)
        {
            this.st = st;
            InitializeComponent();

            var options = new List<String>();
            options.Add(" ");
            options.Add("Estaciones");
            options.Add("Paradas");
            options.Add("Zonas");
            this.optionComBox.DataSource = options;

            this.optionComBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void MapWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            st.Show();
        }

        private void drawStops()
        {
            GMapOverlay markers = new GMapOverlay("markers");
            foreach (var aux in st.GetApp().getStreetStop())
            {
                    streetsMarker(aux.DecLati, aux.DecLati);
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
            foreach (var aux in st.GetApp().getStationStop())
            {
                    stationsMarker(aux.DecLati, aux.DecLati);
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

            /*char s = '/';
            char b = '1';
            char p = '-';
            char q = ')';
            char m = '.';
            char c = '"';
            String fuck = "\n__________________" + s + c + "_" + s + q +
                "\n_________________" + s + c + "_" + m + m + s +
                "\n_______________" + s + m + m + m + "_" + m + s +
                "\n_____________" + s + m + m + m + "_" + m + s +
                "\n_______" + s + c + c + s + c + "_" + m + m + m + c + s + c + c + c + m +
                "¸\n___" + s + c + s + m + m + m + s + m + m + m + "_" + m + s + m + m + m + "_" + m + m + m + m +
                "--\n_" + p + c + p + m + m + m + c + p + m + m + m + "_" + m + m + m + m + m + m + m + "_,~" + s + c + m + m + m + c + q +
                "\n__" + b + m + m + m + m + m + m + m + m + m + m + "_" + m + m + m + m + m + "_" + m + m + b + s + m + m + m + m + s +
                "\n_____" + c + c + m + m + m + b + m + m + m + m + "_" + m + m + m + m + m + "_" + m + "__" + m + m + c +
                "\n______" + b + m + m + m + m + m + m + m + "_" + m + m + m + m + m + "_" + m + m + p +
                "_\n________" + b + m + m + m + m + m + "_" + m + m + m + m + m + "_" + m + m + m + b +
                "_\n__________" + b + m + m + m + m + m + "_" + m + m + m + m + m + "_" + m + m + m + b;
            MessageBox.Show(fuck);*/
            //MessageBox.Show("Epale, Epale\nMi piernita");
        }

        private void OptionComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            verification();
        }

        private void verification()
        {
            int ind = optionComBox.SelectedIndex;

            if (ind == 1 )
            {
                drawStations();
            }else if(ind == 2)
            {
                drawStops();
            }
            else if(ind == 3)
            {
                drawZones();
            }
            else
            {

            }
        }



    }
}
