using DataStructures;
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
        }

        private void MapWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            st.Show();
        }

        private void drawStops()
        {
            for (int i=0;i<st.GetApp().getStationStop().Count;i++)
            {
                stopMap.DragButton = MouseButtons.Left;
                stopMap.CanDragMap = true;
                stopMap.MapProvider = GMapProviders.GoogleMap;
                stopMap.Position = new PointLatLng(st.GetApp().getStationStop()[i].DecLati, st.GetApp().getStationStop()[i].DecLong);
                stopMap.MinZoom = 0;
                stopMap.MaxZoom = 24;
                stopMap.Zoom = 9;
                stopMap.AutoScroll = true;

                //marcador
                markerOverlay = new GMapOverlay("Marcador");
                marker = new GMarkerGoogle(new PointLatLng(st.GetApp().getStationStop()[i].DecLati, st.GetApp().getStationStop()[i].DecLong), GMarkerGoogleType.blue);
                markerOverlay.Markers.Add(marker);

                marker.ToolTipMode = MarkerTooltipMode.Always;


                stopMap.Overlays.Add(markerOverlay);
            }

            for (int i = 0; i < st.GetApp().getStreetStop().Count; i++)
            {
                stopMap.DragButton = MouseButtons.Left;
                stopMap.CanDragMap = true;
                stopMap.MapProvider = GMapProviders.GoogleMap;
                stopMap.Position = new PointLatLng(st.GetApp().getStreetStop()[i].DecLati, st.GetApp().getStreetStop()[i].DecLong);
                stopMap.MinZoom = 0;
                stopMap.MaxZoom = 24;
                stopMap.Zoom = 9;
                stopMap.AutoScroll = true;

                //marcador
                markerOverlay = new GMapOverlay("Marcador");
                marker = new GMarkerGoogle(new PointLatLng(st.GetApp().getStreetStop()[i].DecLati, st.GetApp().getStreetStop()[i].DecLong), GMarkerGoogleType.blue);
                markerOverlay.Markers.Add(marker);

                marker.ToolTipMode = MarkerTooltipMode.Always;


                stopMap.Overlays.Add(markerOverlay);
            }

            /*for (int i=0;i<st.GetApp().getHash().size();i++)
            {
                LinkedList<string, Stop>[] node = st.GetApp().getHash().getNodes();
                for(int j = 0; j < 3; j++)
                {
                    HashNode<string, Stop> actual = node[j].getFirst();
                    if (actual != null)
                    {
                        while (actual != null)
                        {
                            Stop actualStop = actual.getValue();

                            stopMap.DragButton = MouseButtons.Left;
                            stopMap.CanDragMap = true;
                            stopMap.MapProvider = GMapProviders.GoogleMap;
                            stopMap.Position = new PointLatLng(actualStop.DecLati, actualStop.DecLong);
                            stopMap.MinZoom = 0;
                            stopMap.MaxZoom = 24;
                            stopMap.Zoom = 9;
                            stopMap.AutoScroll = true;

                            //marcador
                            markerOverlay = new GMapOverlay("Marcador");
                            marker = new GMarkerGoogle(new PointLatLng(actualStop.DecLati, actualStop.DecLong), GMarkerGoogleType.blue);
                            markerOverlay.Markers.Add(marker);

                            marker.ToolTipMode = MarkerTooltipMode.Always;


                            stopMap.Overlays.Add(markerOverlay);

                            actual = actual.getNext();
                        }
                    }
                }
            }*/
        }

        private void StopMap_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Epale, Epale\nMi piernita");
            drawStops();
        }
    }
}
