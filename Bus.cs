using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIOStopsVisualization
{
    public class Bus
    {
        private double lat;
        private double lon;
        private string busId;
        //KeyValuePair double : lat, double : long
        private List<KeyValuePair<double, double>> coordinates;

        public Bus(double lat, double lon, string busId)
        {
            this.lat = lat;
            this.lon = lon;
            this.busId = busId;
            coordinates = new List<KeyValuePair<double, double>>();
            coordinates.Add(new KeyValuePair<double, double>(lat, lon));
        }

        public void setLat(double lat)
        {
            this.lat = lat;
        }

        public void setLon(double lon)
        {
            this.lon = lon;
        }

        public void setBusId(string busId)
        {
            this.busId = busId;
        }

        public double getLat()
        {
            return lat;
        }

        public double getLon()
        {
            return lon;
        }

        public string getBusId()
        {
            return busId;
        }

        public void setCoordinates(List<KeyValuePair<double, double>> coordinates)
        {
            this.coordinates = coordinates;
        }

        public List<KeyValuePair<double, double>> getCoordinates()
        {
            return coordinates;
        }

    }
}
