using System;
using System.Collections.Generic;
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

        public MIOApp()
        {
            loadElements();
            //streetStopList = new List<Stop>();
            //stationStopList = new List<Stop>();
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
