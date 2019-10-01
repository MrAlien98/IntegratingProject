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
            this.lbOpt = new System.Windows.Forms.Label();
            this.btnSatelite = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnRelieve = new System.Windows.Forms.Button();
            this.tbZoom = new System.Windows.Forms.TrackBar();
            this.LbZoom = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.LAB3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbCentro = new System.Windows.Forms.CheckBox();
            this.cbValleDeLili = new System.Windows.Forms.CheckBox();
            this.cbMenga = new System.Windows.Forms.CheckBox();
            this.cbCalima = new System.Windows.Forms.CheckBox();
            this.cbAguablanca = new System.Windows.Forms.CheckBox();
            this.cbCiudadCordoba = new System.Windows.Forms.CheckBox();
            this.cbGuadalupe = new System.Windows.Forms.CheckBox();
            this.cbCañaveralejo = new System.Windows.Forms.CheckBox();
            this.cbPrado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // stopMap
            // 
            this.stopMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopMap.Bearing = 0F;
            this.stopMap.CanDragMap = true;
            this.stopMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.stopMap.GrayScaleMode = false;
            this.stopMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.stopMap.LevelsKeepInMemmory = 5;
            this.stopMap.Location = new System.Drawing.Point(223, 0);
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
            this.stopMap.Size = new System.Drawing.Size(775, 629);
            this.stopMap.TabIndex = 1;
            this.stopMap.Zoom = 0D;
            this.stopMap.Load += new System.EventHandler(this.StopMap_Load);
            // 
            // optionComBox
            // 
            this.optionComBox.FormattingEnabled = true;
            this.optionComBox.Location = new System.Drawing.Point(36, 280);
            this.optionComBox.Name = "optionComBox";
            this.optionComBox.Size = new System.Drawing.Size(141, 21);
            this.optionComBox.TabIndex = 2;
            this.optionComBox.SelectedIndexChanged += new System.EventHandler(this.OptionComBox_SelectedIndexChanged_1);
            // 
            // lbOpt
            // 
            this.lbOpt.AutoSize = true;
            this.lbOpt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOpt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbOpt.Location = new System.Drawing.Point(12, 249);
            this.lbOpt.Name = "lbOpt";
            this.lbOpt.Size = new System.Drawing.Size(95, 18);
            this.lbOpt.TabIndex = 3;
            this.lbOpt.Text = "OPCIONES";
            this.lbOpt.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSatelite
            // 
            this.btnSatelite.Location = new System.Drawing.Point(64, 330);
            this.btnSatelite.Name = "btnSatelite";
            this.btnSatelite.Size = new System.Drawing.Size(75, 23);
            this.btnSatelite.TabIndex = 6;
            this.btnSatelite.Text = "Satelite";
            this.btnSatelite.UseVisualStyleBackColor = true;
            this.btnSatelite.Click += new System.EventHandler(this.btnSatelite_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(64, 419);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(75, 23);
            this.btnNormal.TabIndex = 7;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnRelieve
            // 
            this.btnRelieve.Location = new System.Drawing.Point(64, 373);
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
            this.tbZoom.Location = new System.Drawing.Point(40, 524);
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
            this.LbZoom.Location = new System.Drawing.Point(33, 491);
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
            this.LAB3.Location = new System.Drawing.Point(12, 221);
            this.LAB3.Name = "LAB3";
            this.LAB3.Size = new System.Drawing.Size(205, 13);
            this.LAB3.TabIndex = 13;
            this.LAB3.Text = "_________________________________";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
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
            // cbCentro
            // 
            this.cbCentro.AutoSize = true;
            this.cbCentro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbCentro.Location = new System.Drawing.Point(135, 353);
            this.cbCentro.Name = "cbCentro";
            this.cbCentro.Size = new System.Drawing.Size(71, 17);
            this.cbCentro.TabIndex = 14;
            this.cbCentro.Text = "CENTRO";
            this.cbCentro.UseVisualStyleBackColor = false;
            this.cbCentro.Visible = false;
            this.cbCentro.CheckedChanged += new System.EventHandler(this.cbCentro_CheckedChanged);
            // 
            // cbValleDeLili
            // 
            this.cbValleDeLili.AutoSize = true;
            this.cbValleDeLili.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbValleDeLili.Location = new System.Drawing.Point(12, 330);
            this.cbValleDeLili.Name = "cbValleDeLili";
            this.cbValleDeLili.Size = new System.Drawing.Size(98, 17);
            this.cbValleDeLili.TabIndex = 15;
            this.cbValleDeLili.Text = "VALLE DE LILÍ";
            this.cbValleDeLili.UseVisualStyleBackColor = false;
            this.cbValleDeLili.Visible = false;
            this.cbValleDeLili.CheckedChanged += new System.EventHandler(this.cbValleDeLili_CheckedChanged);
            // 
            // cbMenga
            // 
            this.cbMenga.AutoSize = true;
            this.cbMenga.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbMenga.Location = new System.Drawing.Point(135, 330);
            this.cbMenga.Name = "cbMenga";
            this.cbMenga.Size = new System.Drawing.Size(65, 17);
            this.cbMenga.TabIndex = 16;
            this.cbMenga.Text = "MENGA";
            this.cbMenga.UseVisualStyleBackColor = false;
            this.cbMenga.Visible = false;
            this.cbMenga.CheckedChanged += new System.EventHandler(this.cbMenga_CheckedChanged);
            // 
            // cbCalima
            // 
            this.cbCalima.AutoSize = true;
            this.cbCalima.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbCalima.Location = new System.Drawing.Point(135, 402);
            this.cbCalima.Name = "cbCalima";
            this.cbCalima.Size = new System.Drawing.Size(65, 17);
            this.cbCalima.TabIndex = 17;
            this.cbCalima.Text = "CALIMA";
            this.cbCalima.UseVisualStyleBackColor = false;
            this.cbCalima.Visible = false;
            this.cbCalima.CheckedChanged += new System.EventHandler(this.cbCalima_CheckedChanged);
            // 
            // cbAguablanca
            // 
            this.cbAguablanca.AutoSize = true;
            this.cbAguablanca.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbAguablanca.Location = new System.Drawing.Point(12, 402);
            this.cbAguablanca.Name = "cbAguablanca";
            this.cbAguablanca.Size = new System.Drawing.Size(98, 17);
            this.cbAguablanca.TabIndex = 18;
            this.cbAguablanca.Text = "AGUABLANCA";
            this.cbAguablanca.UseVisualStyleBackColor = false;
            this.cbAguablanca.Visible = false;
            this.cbAguablanca.CheckedChanged += new System.EventHandler(this.cbAguablanca_CheckedChanged);
            // 
            // cbCiudadCordoba
            // 
            this.cbCiudadCordoba.AutoSize = true;
            this.cbCiudadCordoba.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbCiudadCordoba.Location = new System.Drawing.Point(40, 425);
            this.cbCiudadCordoba.Name = "cbCiudadCordoba";
            this.cbCiudadCordoba.Size = new System.Drawing.Size(123, 17);
            this.cbCiudadCordoba.TabIndex = 19;
            this.cbCiudadCordoba.Text = "CIUDAD CÓRDOBA";
            this.cbCiudadCordoba.UseVisualStyleBackColor = false;
            this.cbCiudadCordoba.Visible = false;
            this.cbCiudadCordoba.CheckedChanged += new System.EventHandler(this.cbCiudadCordoba_CheckedChanged);
            // 
            // cbGuadalupe
            // 
            this.cbGuadalupe.AutoSize = true;
            this.cbGuadalupe.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbGuadalupe.Location = new System.Drawing.Point(12, 379);
            this.cbGuadalupe.Name = "cbGuadalupe";
            this.cbGuadalupe.Size = new System.Drawing.Size(92, 17);
            this.cbGuadalupe.TabIndex = 20;
            this.cbGuadalupe.Text = "GUADALUPE";
            this.cbGuadalupe.UseVisualStyleBackColor = false;
            this.cbGuadalupe.Visible = false;
            this.cbGuadalupe.CheckedChanged += new System.EventHandler(this.cbGuadalupe_CheckedChanged);
            // 
            // cbCañaveralejo
            // 
            this.cbCañaveralejo.AutoSize = true;
            this.cbCañaveralejo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbCañaveralejo.Location = new System.Drawing.Point(12, 353);
            this.cbCañaveralejo.Name = "cbCañaveralejo";
            this.cbCañaveralejo.Size = new System.Drawing.Size(110, 17);
            this.cbCañaveralejo.TabIndex = 21;
            this.cbCañaveralejo.Text = "CAÑAVERALEJO";
            this.cbCañaveralejo.UseVisualStyleBackColor = false;
            this.cbCañaveralejo.Visible = false;
            this.cbCañaveralejo.CheckedChanged += new System.EventHandler(this.cbCañaveralejo_CheckedChanged);
            // 
            // cbPrado
            // 
            this.cbPrado.AutoSize = true;
            this.cbPrado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbPrado.Location = new System.Drawing.Point(135, 379);
            this.cbPrado.Name = "cbPrado";
            this.cbPrado.Size = new System.Drawing.Size(64, 17);
            this.cbPrado.TabIndex = 22;
            this.cbPrado.Text = "PRADO";
            this.cbPrado.UseVisualStyleBackColor = false;
            this.cbPrado.Visible = false;
            this.cbPrado.CheckedChanged += new System.EventHandler(this.cbPrado_CheckedChanged);
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 629);
            this.Controls.Add(this.cbPrado);
            this.Controls.Add(this.cbCañaveralejo);
            this.Controls.Add(this.cbGuadalupe);
            this.Controls.Add(this.cbCiudadCordoba);
            this.Controls.Add(this.cbAguablanca);
            this.Controls.Add(this.cbCalima);
            this.Controls.Add(this.cbMenga);
            this.Controls.Add(this.cbValleDeLili);
            this.Controls.Add(this.cbCentro);
            this.Controls.Add(this.LAB3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LbZoom);
            this.Controls.Add(this.tbZoom);
            this.Controls.Add(this.btnRelieve);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnSatelite);
            this.Controls.Add(this.lbOpt);
            this.Controls.Add(this.optionComBox);
            this.Controls.Add(this.stopMap);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIO";
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl stopMap;
        private System.Windows.Forms.ComboBox optionComBox;
        private System.Windows.Forms.Label lbOpt;
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
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox cbCentro;
        private System.Windows.Forms.CheckBox cbValleDeLili;
        private System.Windows.Forms.CheckBox cbMenga;
        private System.Windows.Forms.CheckBox cbCalima;
        private System.Windows.Forms.CheckBox cbAguablanca;
        private System.Windows.Forms.CheckBox cbCiudadCordoba;
        private System.Windows.Forms.CheckBox cbGuadalupe;
        private System.Windows.Forms.CheckBox cbCañaveralejo;
        private System.Windows.Forms.CheckBox cbPrado;
    }
}

