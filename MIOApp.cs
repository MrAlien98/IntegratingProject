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

        private List<Stop> list;

        public MIOApp()
        {
            List = new List<Stop>();
        }

        internal List<Stop> List { get => list; set => list = value; }

        public void saveElements()
        {
            try
            {
                var stream = File.OpenWrite("data/StopsList.txt");
                var xmlSer = new XmlSerializer(typeof(List<Stop>));
                xmlSer.Serialize(stream, list);
                stream.Close();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
