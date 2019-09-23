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
        private Hashtable<string, Stop> hash;

        public MIOApp()
        {
            hash = new Hashtable<string, Stop>(100);
        }

        public Hashtable<string, Stop> getHash()
        {
            return hash;
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
