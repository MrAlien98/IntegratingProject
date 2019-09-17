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
        //String nombre = "";
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

        private void StopMap_Load(object sender, EventArgs e)
        {
            stopMap.DragButton = MouseButtons.Left;
            stopMap.CanDragMap = true;
            stopMap.MapProvider = GMapProviders.GoogleMap;
            stopMap.Position = new PointLatLng(latInicial, lngInicial);
            stopMap.MinZoom = 0;
            stopMap.MaxZoom = 24;
            stopMap.Zoom = 9;
            stopMap.AutoScroll = true;

            //marcador
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(latInicial, lngInicial), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker);

            marker.ToolTipMode = MarkerTooltipMode.Always;


            stopMap.Overlays.Add(markerOverlay);
        }
    }
}
