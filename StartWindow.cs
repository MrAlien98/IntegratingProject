using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIOStopsVisualization
{
    public partial class StartWindow : Form
    {
        public MIOApp app;
        public StartWindow()
        {
            InitializeComponent();

            app = new MIOApp();
            ReadFile();

            Image banner = Image.FromFile("images/MIO_Logo.jpg");
            imgBanner.Image = banner;
        }

        public MIOApp GetApp()
        {
            return app;
        }

        public void ReadFile()
        {
            try
            {
                int i = 0;
                string line = "";
                StreamReader sr = new StreamReader("data/stops.csv");
                //var watch = System.Diagnostics.Stopwatch.StartNew();
                while ((line = sr.ReadLine()) != null)
                {
                    int type = 0;
                    String[] individual = line.Split(',');

                    double lat = double.Parse(individual[6], CultureInfo.InvariantCulture);
                    double lon = double.Parse(individual[7], CultureInfo.InvariantCulture); ;

                    if (individual[3].Contains("con") || individual[3].Contains("entre"))
                    {
                        type = 1;
                    }
                    else
                    {
                        type = 2;
                    }
                    Stop st = new Stop(individual[0], type, individual[2], individual[3], lon, lat);

                    if (type==1) {
                        app.getStreetStop().Add(st);
                    }
                    else
                    {
                        app.getStationStop().Add(st);
                    }
                    i++;
                }
                app.saveElements();
                heehee();
                /*watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                var timef = elapsedMs * 0.001;*/
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void heehee()
        {
            this.Hide();
            MapWindow mw = new MapWindow(this);
            mw.Show();
        }
    }
}
