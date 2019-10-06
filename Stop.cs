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

        public string longName;
        public double decLong;
        public double decLati;

        public Stop(string longName, double decLati, double decLong)
        {
            this.longName = longName;
            this.decLong = decLong;
            this.decLati = decLati;
        }

        public Stop()
        {

        }
        public string LongName { get => longName; set => longName = value; }
        public double DecLong { get => decLong; set => decLong = value; }
        public double DecLati { get => decLati; set => decLati = value; }

        public string toString()
        {
            return "" + LongName;
        }

    }
}
