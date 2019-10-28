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
        private List<Bus> buses;
        private List<KeyValuePair<string, string> > routes;

        private Bus testBus;

        public MIOApp()
        {
            loadElements();
            
            testBus = null;

            routes = new List<KeyValuePair<string, string>>();
            //buses = new List<Bus>();
            //streetStopList = new List<Stop>();
            //stationStopList = new List<Stop>();

            routesList();
        }

        public List<KeyValuePair<string, string>> getRoutes()
        {
            return routes;
        }

        public void routesList()
        {
            try
            {
                StreamReader sr = new StreamReader("data/routesListFull.txt");
                string line = sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    routes.Add(new KeyValuePair<string, string>(line.Split(',')[2], line.Split(',')[0]));
                }
            }
            catch (Exception e)
            {

            }
            saveRoutes();
        }

        public void saveRoutes()
        {
            try
            {
                BinaryFormatter format = new BinaryFormatter();
                FileStream stream = new FileStream("data/routesList.txt", FileMode.Create);
                format.Serialize(stream, routes);

                stream.Close();
            }
            catch(Exception e)
            {

            }
        }

        public List<Bus> getBuses()
        {
            return buses;
        }

        public void setBuses(List<Bus> buses)
        {
            this.buses = buses;
        }

        public double adjustCoordinates(string value)
        {
            double result = double.Parse(value, CultureInfo.InvariantCulture);
            return result;
        }

        public double adjustCoordinates(string value, int i)
        {
            double result = double.Parse(value, CultureInfo.InvariantCulture);
            return result/10000000;
        }

        public void setTestBus(string lat, string lon, string busId, string lineId)
        {
            this.testBus = new Bus(adjustCoordinates(lat), adjustCoordinates(lon), busId, lineId);
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

        public void saveBuses()
        {
            try
            {
                BinaryFormatter format = new BinaryFormatter();
                FileStream stream = new FileStream("data/Buses.txt", FileMode.Create);

                format.Serialize(stream, buses);

                stream.Close();
            }catch(Exception e)
            {

            }
        }

        public void loadElements()
        {
            BinaryFormatter format = new BinaryFormatter();

            FileStream stream = new FileStream("data/StreetStopsList.txt", FileMode.Open);
            FileStream stream2 = new FileStream("data/StationStopsList.txt", FileMode.Open);
            FileStream stream3 = new FileStream("data/Buses.txt", FileMode.Open);
            //FileStream stream4 = new FileStream("data/routesList.txt", FileMode.Open);

            streetStopList = (List<Stop>) format.Deserialize(stream);
            stationStopList = (List<Stop>)format.Deserialize(stream2);
                        buses = (List<Bus>)format.Deserialize(stream3);
              //          routes = (List<KeyValuePair<string, string>>)format.Deserialize(stream4);

            stream.Close();
            stream2.Close();
            stream3.Close();
            //stream4.Close();

        }
    }
}
