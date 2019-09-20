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
    class MIOApp
    {

        private Hashtable<string, Stop> list;

        public MIOApp()
        {
            List = new Hashtable<string, Stop>(100);
        }

        internal Hashtable<string, Stop> List { get => list; set => list = value; }

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
