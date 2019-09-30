namespace MIOStopsVisualization
{
    partial class StartWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartWindow));
            this.stopMap = new GMap.NET.WindowsForms.GMapControl();
            this.optionComBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSatelite = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnRelieve = new System.Windows.Forms.Button();
            this.tbZoom = new System.Windows.Forms.TrackBar();
            this.LbZoom = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LAB3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stopMap
            // 
            this.stopMap.Bearing = 0F;
            this.stopMap.CanDragMap = true;
            this.stopMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.stopMap.GrayScaleMode = false;
            this.stopMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.stopMap.LevelsKeepInMemmory = 5;
            this.stopMap.Location = new System.Drawing.Point(239, 0);
            this.stopMap.MarkersEnabled = true;
            this.stopMap.MaxZoom = 2;
            this.stopMap.MinZoom = 2;
            this.stopMap.MouseWheelZoomEnabled = true;
            this.stopMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.stopMap.Name = "stopMap";
            this.stopMap.NegativeMode = false;
            this.stopMap.PolygonsEnabled = true;
            this.stopMap.RetryLoadTile = 0;
            this.stopMap.RoutesEnabled = true;
            this.stopMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.stopMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.stopMap.ShowTileGridLines = false;
            this.stopMap.Size = new System.Drawing.Size(746, 629);
            this.stopMap.TabIndex = 1;
            this.stopMap.Zoom = 0D;
            this.stopMap.Load += new System.EventHandler(this.StopMap_Load);
            // 
            // optionComBox
            // 
            this.optionComBox.FormattingEnabled = true;
            this.optionComBox.Location = new System.Drawing.Point(40, 333);
            this.optionComBox.Name = "optionComBox";
            this.optionComBox.Size = new System.Drawing.Size(141, 21);
            this.optionComBox.TabIndex = 2;
            this.optionComBox.SelectedIndexChanged += new System.EventHandler(this.OptionComBox_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "OPCIONES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSatelite
            // 
            this.btnSatelite.Location = new System.Drawing.Point(77, 374);
            this.btnSatelite.Name = "btnSatelite";
            this.btnSatelite.Size = new System.Drawing.Size(75, 23);
            this.btnSatelite.TabIndex = 6;
            this.btnSatelite.Text = "Satelite";
            this.btnSatelite.UseVisualStyleBackColor = true;
            this.btnSatelite.Click += new System.EventHandler(this.btnSatelite_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(77, 415);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(75, 23);
            this.btnNormal.TabIndex = 7;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnRelieve
            // 
            this.btnRelieve.Location = new System.Drawing.Point(77, 456);
            this.btnRelieve.Name = "btnRelieve";
            this.btnRelieve.Size = new System.Drawing.Size(75, 23);
            this.btnRelieve.TabIndex = 8;
            this.btnRelieve.Text = "Relieve";
            this.btnRelieve.UseVisualStyleBackColor = true;
            this.btnRelieve.Click += new System.EventHandler(this.btnRelieve_Click);
            // 
            // tbZoom
            // 
            this.tbZoom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbZoom.Location = new System.Drawing.Point(40, 521);
            this.tbZoom.Maximum = 25;
            this.tbZoom.Name = "tbZoom";
            this.tbZoom.Size = new System.Drawing.Size(141, 45);
            this.tbZoom.TabIndex = 9;
            this.tbZoom.ValueChanged += new System.EventHandler(this.tbZoom_ValueChanged);
            // 
            // LbZoom
            // 
            this.LbZoom.AutoSize = true;
            this.LbZoom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LbZoom.Location = new System.Drawing.Point(37, 496);
            this.LbZoom.Name = "LbZoom";
            this.LbZoom.Size = new System.Drawing.Size(34, 13);
            this.LbZoom.TabIndex = 10;
            this.LbZoom.Text = "Zoom";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(233, 629);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox2.Image = global::MIOStopsVisualization.Properties.Resources.bus_stop_6_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(40, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 157);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MIOStopsVisualization.Properties.Resources.fondo_banner_3;
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(997, 644);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.label2.Location = new System.Drawing.Point(85, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "MIO";
            // 
            // LAB3
            // 
            this.LAB3.AutoSize = true;
            this.LAB3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LAB3.Location = new System.Drawing.Point(12, 239);
            this.LAB3.Name = "LAB3";
            this.LAB3.Size = new System.Drawing.Size(205, 13);
            this.LAB3.TabIndex = 13;
            this.LAB3.Text = "_________________________________";
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 629);
            this.Controls.Add(this.LAB3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LbZoom);
            this.Controls.Add(this.tbZoom);
            this.Controls.Add(this.btnRelieve);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnSatelite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optionComBox);
            this.Controls.Add(this.stopMap);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIO";
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl stopMap;
        private System.Windows.Forms.ComboBox optionComBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSatelite;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnRelieve;
        private System.Windows.Forms.TrackBar tbZoom;
        private System.Windows.Forms.Label LbZoom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LAB3;
    }
}

