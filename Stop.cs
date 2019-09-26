using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIOStopsVisualization
{ 
    [Serializable]
    public class Stop
    {
        public const int StreetStop = 1;
        public const int StationStop = 2;

        public string stopID;
        public int type;
        public string shortName;
        public string longName;
        public double decLong;
        public double decLati;

        public Stop(string stopID, int type, string shortName, string longName, double decLong, double decLati)
        {
            this.stopID = stopID;
            this.type = type;
            this.shortName = shortName;
            this.longName = longName;
            this.decLong = decLong;
            this.decLati = decLati;
        }

        public Stop()
        {

        }

        public string StopID { get => stopID; set => stopID = value; }
        public int Type { get => type; set => type = value; }
        public string ShortName { get => shortName; set => shortName = value; }
        public string LongName { get => longName; set => longName = value; }
        public double DecLong { get => decLong; set => decLong = value; }
        public double DecLati { get => decLati; set => decLati = value; }

        public string toString()
        {
            return "" + shortName;
        }

    }
}
