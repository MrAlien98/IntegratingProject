using DataStructures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MIOStopsVisualization
{
    public class MIOApp
    { 
        private List<Stop> streetStopList;
        private List<Stop> stationStopList;

        public MIOApp()
        {
            streetStopList = new List<Stop>();
            stationStopList = new List<Stop>();
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
            /*try
            {
                var stream = File.OpenWrite("data/StopsList.txt");
                var xmlSer = new XmlSerializer(typeof(Hashtable<string,Stop>));
                xmlSer.Serialize(stream, list);
                stream.Close();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
        }
    }
}
