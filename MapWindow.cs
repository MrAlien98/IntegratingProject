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

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        String nombre = "";
        double latInicial = 3.3417918;
        double lngInicial = -76.5328215;

        StartWindow st;

        public MapWindow(StartWindow st)
        {
            this.st = st;
            InitializeComponent();

            var options = new List<String>();
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
            stopMap.Overlays.Clear();
           
            for (int i = 0; i < st.GetApp().getStreetStop().Count; i++)
            {
                stopMap.DragButton = MouseButtons.Left;
                stopMap.CanDragMap = true;
                stopMap.MapProvider = GMapProviders.GoogleMap;
                stopMap.Position = new PointLatLng(st.GetApp().getStreetStop()[i].DecLati, st.GetApp().getStreetStop()[i].DecLong);
                stopMap.MinZoom = 0;
                stopMap.MaxZoom = 24;
                stopMap.Zoom = 12;
                stopMap.AutoScroll = true;

                //marcador
                markerOverlay = new GMapOverlay("Marcador");
                marker = new GMarkerGoogle(new PointLatLng(st.GetApp().getStreetStop()[i].DecLati, st.GetApp().getStreetStop()[i].DecLong), GMarkerGoogleType.blue);
                markerOverlay.Markers.Add(marker);

                marker.ToolTipMode = MarkerTooltipMode.Always;

                stopMap.Overlays.Add(markerOverlay);
            }

            MessageBox.Show("Termino de dibujar las paradas");

        }

        public void drawStations()
        {
            stopMap.Overlays.Clear();

            for (int i = 0; i < st.GetApp().getStationStop().Count; i++)
            {
                stopMap.DragButton = MouseButtons.Left;
                stopMap.CanDragMap = true;
                stopMap.MapProvider = GMapProviders.GoogleMap;
                stopMap.Position = new PointLatLng(st.GetApp().getStationStop()[i].DecLati, st.GetApp().getStationStop()[i].DecLong);
                stopMap.MinZoom = 0;
                stopMap.MaxZoom = 24;
                stopMap.Zoom = 12;
                stopMap.AutoScroll = true;

                //marcador
                markerOverlay = new GMapOverlay("Marcador");
                marker = new GMarkerGoogle(new PointLatLng(st.GetApp().getStationStop()[i].DecLati, st.GetApp().getStationStop()[i].DecLong), GMarkerGoogleType.blue);
                markerOverlay.Markers.Add(marker);

                marker.ToolTipMode = MarkerTooltipMode.Always;

                stopMap.Overlays.Add(markerOverlay);
            }

            MessageBox.Show("Termino de dibujar las estaciones");

        }

        public void drawZones()
        {
            stopMap.Overlays.Clear();

            stopMap.DragButton = MouseButtons.Left;
            stopMap.CanDragMap = true;
            stopMap.MapProvider = GMapProviders.GoogleMap;
            stopMap.Position = new PointLatLng(3.3417918, -76.5328215);
            stopMap.MinZoom = 0;
            stopMap.MaxZoom = 24;
            stopMap.Zoom = 12;
            stopMap.AutoScroll = true;

            MessageBox.Show("Termino de dibujar las zonas");

        }

        private void StopMap_Load(object sender, EventArgs e)
        {

            stopMap.DragButton = MouseButtons.Left;
            stopMap.CanDragMap = true;
            stopMap.MapProvider = GMapProviders.GoogleMap;
            stopMap.Position = new PointLatLng(3.3417918, -76.5328215);
            stopMap.MinZoom = 0;
            stopMap.MaxZoom = 24;
            stopMap.Zoom = 12;
            stopMap.AutoScroll = true;

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

            if (ind == 0 )
            {
                drawStations();
            }else if(ind == 1)
            {
                drawStops();
            }
            else
            {
                drawZones();
            }
        }
    }
}
