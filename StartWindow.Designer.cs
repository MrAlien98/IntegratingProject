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
            this.btnSatelite = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnRelieve = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.cbCentro = new System.Windows.Forms.CheckBox();
            this.cbValleDeLili = new System.Windows.Forms.CheckBox();
            this.cbMenga = new System.Windows.Forms.CheckBox();
            this.cbCalima = new System.Windows.Forms.CheckBox();
            this.cbAguablanca = new System.Windows.Forms.CheckBox();
            this.cbCiudadCordoba = new System.Windows.Forms.CheckBox();
            this.cbGuadalupe = new System.Windows.Forms.CheckBox();
            this.cbCañaveralejo = new System.Windows.Forms.CheckBox();
            this.cbPrado = new System.Windows.Forms.CheckBox();
            this.cbStation = new System.Windows.Forms.CheckBox();
            this.cbStops = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.zoomOutButton = new System.Windows.Forms.Button();
            this.zoomInButton = new System.Windows.Forms.Button();
            this.butStartSimulation = new System.Windows.Forms.Button();
            this.zonasCombo = new System.Windows.Forms.ComboBox();
            this.vistasCombo = new System.Windows.Forms.ComboBox();
            this.btBorrar = new System.Windows.Forms.Button();
            this.routesCheckedList = new System.Windows.Forms.CheckedListBox();
            this.zonesCheckedList = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.stopMap.Size = new System.Drawing.Size(1043, 707);
            this.stopMap.TabIndex = 1;
            this.stopMap.Zoom = 0D;
            this.stopMap.Load += new System.EventHandler(this.StopMap_Load);
            // 
            // optionComBox
            // 
            this.optionComBox.FormattingEnabled = true;
            this.optionComBox.Location = new System.Drawing.Point(672, 12);
            this.optionComBox.Name = "optionComBox";
            this.optionComBox.Size = new System.Drawing.Size(141, 21);
            this.optionComBox.TabIndex = 2;
            this.optionComBox.Visible = false;
            this.optionComBox.SelectedIndexChanged += new System.EventHandler(this.OptionComBox_SelectedIndexChanged_1);
            // 
            // btnSatelite
            // 
            this.btnSatelite.Location = new System.Drawing.Point(699, 14);
            this.btnSatelite.Name = "btnSatelite";
            this.btnSatelite.Size = new System.Drawing.Size(75, 23);
            this.btnSatelite.TabIndex = 6;
            this.btnSatelite.Text = "Satelite";
            this.btnSatelite.UseVisualStyleBackColor = true;
            this.btnSatelite.Visible = false;
            this.btnSatelite.Click += new System.EventHandler(this.btnSatelite_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(699, 14);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(75, 23);
            this.btnNormal.TabIndex = 7;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnRelieve
            // 
            this.btnRelieve.Location = new System.Drawing.Point(699, 8);
            this.btnRelieve.Name = "btnRelieve";
            this.btnRelieve.Size = new System.Drawing.Size(75, 23);
            this.btnRelieve.TabIndex = 8;
            this.btnRelieve.Text = "Relieve";
            this.btnRelieve.UseVisualStyleBackColor = true;
            this.btnRelieve.Visible = false;
            this.btnRelieve.Click += new System.EventHandler(this.btnRelieve_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(217, 707);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // cbCentro
            // 
            this.cbCentro.AutoSize = true;
            this.cbCentro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbCentro.Location = new System.Drawing.Point(675, 16);
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
            this.cbValleDeLili.Location = new System.Drawing.Point(681, 12);
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
            this.cbMenga.Location = new System.Drawing.Point(681, 12);
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
            this.cbCalima.Location = new System.Drawing.Point(699, 16);
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
            this.cbAguablanca.Location = new System.Drawing.Point(681, 14);
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
            this.cbCiudadCordoba.Location = new System.Drawing.Point(675, 14);
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
            this.cbGuadalupe.Location = new System.Drawing.Point(672, 12);
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
            this.cbCañaveralejo.Location = new System.Drawing.Point(681, 14);
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
            this.cbPrado.Location = new System.Drawing.Point(675, 12);
            this.cbPrado.Name = "cbPrado";
            this.cbPrado.Size = new System.Drawing.Size(64, 17);
            this.cbPrado.TabIndex = 22;
            this.cbPrado.Text = "PRADO";
            this.cbPrado.UseVisualStyleBackColor = false;
            this.cbPrado.Visible = false;
            this.cbPrado.CheckedChanged += new System.EventHandler(this.cbPrado_CheckedChanged);
            // 
            // cbStation
            // 
            this.cbStation.AutoSize = true;
            this.cbStation.BackColor = System.Drawing.Color.Transparent;
            this.cbStation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbStation.BackgroundImage")));
            this.cbStation.Checked = true;
            this.cbStation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStation.Location = new System.Drawing.Point(12, 283);
            this.cbStation.Name = "cbStation";
            this.cbStation.Size = new System.Drawing.Size(94, 17);
            this.cbStation.TabIndex = 23;
            this.cbStation.Text = "ESTACIONES";
            this.cbStation.UseVisualStyleBackColor = false;
            this.cbStation.CheckedChanged += new System.EventHandler(this.CheckedBoxDrawStations);
            // 
            // cbStops
            // 
            this.cbStops.AutoSize = true;
            this.cbStops.BackColor = System.Drawing.Color.Transparent;
            this.cbStops.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbStops.BackgroundImage")));
            this.cbStops.Location = new System.Drawing.Point(125, 283);
            this.cbStops.Name = "cbStops";
            this.cbStops.Size = new System.Drawing.Size(77, 17);
            this.cbStops.TabIndex = 24;
            this.cbStops.Text = "PARADAS";
            this.cbStops.UseVisualStyleBackColor = false;
            this.cbStops.CheckedChanged += new System.EventHandler(this.cbStops_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.secondsLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.minutesLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.hoursLabel);
            this.panel1.Location = new System.Drawing.Point(239, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 49);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(95, 30);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(19, 13);
            this.secondsLabel.TabIndex = 4;
            this.secondsLabel.Text = "00";
            this.secondsLabel.Click += new System.EventHandler(this.secondsLabel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = ":";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(54, 30);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(19, 13);
            this.minutesLabel.TabIndex = 2;
            this.minutesLabel.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = ":";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(13, 30);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(19, 13);
            this.hoursLabel.TabIndex = 0;
            this.hoursLabel.Text = "00";
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.BackColor = System.Drawing.Color.LightGray;
            this.zoomOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomOutButton.ForeColor = System.Drawing.Color.Black;
            this.zoomOutButton.Location = new System.Drawing.Point(1221, 673);
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(37, 29);
            this.zoomOutButton.TabIndex = 29;
            this.zoomOutButton.Text = "-";
            this.zoomOutButton.UseVisualStyleBackColor = false;
            this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
            // 
            // zoomInButton
            // 
            this.zoomInButton.BackColor = System.Drawing.Color.LightGray;
            this.zoomInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomInButton.ForeColor = System.Drawing.Color.Black;
            this.zoomInButton.Location = new System.Drawing.Point(1221, 638);
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(37, 29);
            this.zoomInButton.TabIndex = 29;
            this.zoomInButton.Text = "+";
            this.zoomInButton.UseVisualStyleBackColor = false;
            this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
            // 
            // butStartSimulation
            // 
            this.butStartSimulation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butStartSimulation.Image = ((System.Drawing.Image)(resources.GetObject("butStartSimulation.Image")));
            this.butStartSimulation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butStartSimulation.Location = new System.Drawing.Point(38, 171);
            this.butStartSimulation.Name = "butStartSimulation";
            this.butStartSimulation.Size = new System.Drawing.Size(136, 36);
            this.butStartSimulation.TabIndex = 30;
            this.butStartSimulation.Text = "Iniciar Simulación";
            this.butStartSimulation.UseVisualStyleBackColor = false;
            this.butStartSimulation.Click += new System.EventHandler(this.ButStartSimulation_Click);
            // 
            // zonasCombo
            // 
            this.zonasCombo.FormattingEnabled = true;
            this.zonasCombo.Location = new System.Drawing.Point(656, 12);
            this.zonasCombo.Name = "zonasCombo";
            this.zonasCombo.Size = new System.Drawing.Size(190, 21);
            this.zonasCombo.TabIndex = 31;
            this.zonasCombo.SelectedIndexChanged += new System.EventHandler(this.zonasCombo_SelectedIndexChanged);
            // 
            // vistasCombo
            // 
            this.vistasCombo.FormattingEnabled = true;
            this.vistasCombo.Location = new System.Drawing.Point(656, 12);
            this.vistasCombo.Name = "vistasCombo";
            this.vistasCombo.Size = new System.Drawing.Size(190, 21);
            this.vistasCombo.TabIndex = 33;
            this.vistasCombo.SelectedIndexChanged += new System.EventHandler(this.vistasCombo_SelectedIndexChanged);
            // 
            // btBorrar
            // 
            this.btBorrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btBorrar.Image")));
            this.btBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBorrar.Location = new System.Drawing.Point(38, 222);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(136, 36);
            this.btBorrar.TabIndex = 34;
            this.btBorrar.Text = "Limpiar";
            this.btBorrar.UseVisualStyleBackColor = false;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // routesCheckedList
            // 
            this.routesCheckedList.CheckOnClick = true;
            this.routesCheckedList.FormattingEnabled = true;
            this.routesCheckedList.Items.AddRange(new object[] {
            "Todos los buses"});
            this.routesCheckedList.Location = new System.Drawing.Point(12, 466);
            this.routesCheckedList.Name = "routesCheckedList";
            this.routesCheckedList.Size = new System.Drawing.Size(190, 229);
            this.routesCheckedList.TabIndex = 36;
            this.routesCheckedList.SelectedIndexChanged += new System.EventHandler(this.routesCheckedListBox1_SelectedIndexChanged);
            // 
            // zonesCheckedList
            // 
            this.zonesCheckedList.CheckOnClick = true;
            this.zonesCheckedList.FormattingEnabled = true;
            this.zonesCheckedList.Location = new System.Drawing.Point(12, 306);
            this.zonesCheckedList.Name = "zonesCheckedList";
            this.zonesCheckedList.Size = new System.Drawing.Size(190, 154);
            this.zonesCheckedList.TabIndex = 37;
            this.zonesCheckedList.SelectedIndexChanged += new System.EventHandler(this.ZonesCheckedList_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 707);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 110);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "01-NOV-18";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 707);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.zonesCheckedList);
            this.Controls.Add(this.routesCheckedList);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.vistasCombo);
            this.Controls.Add(this.zonasCombo);
            this.Controls.Add(this.butStartSimulation);
            this.Controls.Add(this.zoomInButton);
            this.Controls.Add(this.zoomOutButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbStops);
            this.Controls.Add(this.cbStation);
            this.Controls.Add(this.cbPrado);
            this.Controls.Add(this.cbCañaveralejo);
            this.Controls.Add(this.cbGuadalupe);
            this.Controls.Add(this.cbCiudadCordoba);
            this.Controls.Add(this.cbAguablanca);
            this.Controls.Add(this.cbCalima);
            this.Controls.Add(this.cbMenga);
            this.Controls.Add(this.cbValleDeLili);
            this.Controls.Add(this.cbCentro);
            this.Controls.Add(this.btnRelieve);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnSatelite);
            this.Controls.Add(this.optionComBox);
            this.Controls.Add(this.stopMap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartWindow_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl stopMap;
        private System.Windows.Forms.ComboBox optionComBox;
        private System.Windows.Forms.Button btnSatelite;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnRelieve;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Splitter splitter1;
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
        private System.Windows.Forms.CheckBox cbStation;
        private System.Windows.Forms.CheckBox cbStops;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Button zoomOutButton;
        private System.Windows.Forms.Button zoomInButton;
        private System.Windows.Forms.Button butStartSimulation;
        private System.Windows.Forms.ComboBox zonasCombo;
        private System.Windows.Forms.ComboBox vistasCombo;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.CheckedListBox routesCheckedList;
        private System.Windows.Forms.CheckedListBox zonesCheckedList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

