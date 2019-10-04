using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MIOStopsVisualization
{
    public class MIOApp
    { 
        private List<Stop> streetStopList;
        private List<Stop> stationStopList;
        private List<Stop> specificStation;

        private Bus testBus;

        public MIOApp()
        {
            loadElements();
            testBus = null;
            //streetStopList = new List<Stop>();
            //stationStopList = new List<Stop>();
        }

        public double adjustCoordinates(string value)
        {
            double result = double.Parse(value, CultureInfo.InvariantCulture);
            return result / 10000000;
        }

        public void setTestBus(string lat, string lon, string busId)
        {
            this.testBus = new Bus(adjustCoordinates(lat), adjustCoordinates(lon), busId);
        }

        public Bus getTestBus()
        {
            return testBus;
        }

        public List<Stop> getStreetStop()
        {
            return streetStopList;
        }

        public List<Stop> getStationStop()
        {
            return stationStopList;
        }

        public void saveElements()
        {
            try
            {
                BinaryFormatter format = new BinaryFormatter();
                FileStream stream = new FileStream("data/StreetStopsList.txt", FileMode.Create);
                format.Serialize(stream, streetStopList);

                FileStream stream2 = new FileStream("data/StationStopsList.txt", FileMode.Create);
                format.Serialize(stream2, stationStopList);

                stream.Close();
                stream2.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public void loadElements()
        {
            BinaryFormatter format = new BinaryFormatter();

            FileStream stream = new FileStream("data/StreetStopsList.txt", FileMode.Open);

            FileStream stream2 = new FileStream("data/StationStopsList.txt", FileMode.Open);

            streetStopList = (List<Stop>) format.Deserialize(stream);
            stationStopList = (List<Stop>)format.Deserialize(stream2);

            stream.Close();
            stream2.Close();
        }
    }
}
