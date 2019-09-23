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
                    app.getHash().add(individual[0], st);
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

        /*public void threadReader()
        {
            ThreadStart delegado = new ThreadStart(ReadFile);
            Thread hilo = new Thread(delegado);
            hilo.Start();
        }*/

        private void heehee()
        {
            /* char s = '/';
             char b = '1';
             char p = '-';
             char q = ')';
             char m = '.';
             char c = '"';
             String fuck = "\n__________________" + s + c + "_" + s + q +
                 "\n_________________" + s + c + "_" + m + m + s + 
                 "\n_______________" + s + m + m + m + "_" + m + s + 
                 "\n_____________" + s + m + m + m + "_" + m + s + 
                 "\n_______" + s + c + c + s + c + "_" + m + m + m + c + s + c + c + c + m + 
                 "¸\n___" + s + c + s + m + m + m + s + m + m + m + "_" + m + s + m + m + m + "_" + m + m + m + m + 
                 "--\n_" + p + c + p + m + m + m + c + p + m + m + m + "_" + m + m + m + m + m + m + m + "_,~" + s + c + m + m + m + c + q + 
                 "\n__" + b + m + m + m + m + m + m + m + m + m + m + "_" + m + m + m + m + m + "_" + m + m + b + s + m + m + m + m + s + 
                 "\n_____" + c + c + m + m + m + b + m + m + m + m + "_" + m + m + m + m + m + "_" + m + "__" + m + m + c + 
                 "\n______" + b + m + m + m + m + m + m + m + "_" + m + m + m + m + m + "_" + m + m + p + 
                 "_\n________" + b + m + m + m + m + m + "_" + m + m + m + m + m + "_" + m + m + m + b + 
                 "_\n__________" + b + m + m + m + m + m + "_" + m + m + m + m + m + "_" + m + m + m + b;
             MessageBox.Show(fuck);
             */
            //threadReader();
            MapWindow mw = new MapWindow(this);
            this.Hide();
            mw.Show();
        }
    }
}
