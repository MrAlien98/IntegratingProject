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
            try
            {
                var stream = File.OpenWrite("data/StreetStopsList.txt");
                var xmlSer = new XmlSerializer(typeof(List<Stop>));
                xmlSer.Serialize(stream, streetStopList);

                var stream2 = File.OpenWrite("data/StationStopsList.txt");
                xmlSer.Serialize(stream2, stationStopList);

                stream.Close();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void loadElelemts()
        {
            try
            {
                var stream = File.OpenWrite("data/StreetStopsList.txt");
                //stream.Read = streetStopList;
            }catch(Exception e) {

            }
            
        }
    }
}
