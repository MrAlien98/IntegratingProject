using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIOStopsVisualization
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            ReadFile();
            InitializeComponent();
            Image banner = Image.FromFile("images/MIO_Logo.jpg");
            imgBanner.Image = banner;
        }

        public void ReadFile()
        {
            /*ArrayList stops = new ArrayList();
            string line = "";
            ToolTip myToolTip = new ToolTip();
            myToolTip.SetToolTip(txtTimeTaken, "Tiempo que toma leer el archivo stops.csv");*/
            try
            {
                /*StreamReader sr = new StreamReader("data/stops.csv");
                var watch = System.Diagnostics.Stopwatch.StartNew();
                while ((line = sr.ReadLine()) != null)
                {
                    stops.Add(line);
                }
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                var timef = elapsedMs * 0.001;
                txtTimeTaken.Text = "" + timef;
                MessageBox.Show(""+stops.Count);*/
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void ButStartOperation_Click(object sender, EventArgs e)
        {
            char s = '/';
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

            MapWindow mw = new MapWindow(this);
            this.Hide();
            mw.Show();
        }
    }
}
