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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.stopMap = new GMap.NET.WindowsForms.GMapControl();
            this.optionComBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(222, 629);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // stopMap
            // 
            this.stopMap.Bearing = 0F;
            this.stopMap.CanDragMap = true;
            this.stopMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.stopMap.GrayScaleMode = false;
            this.stopMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.stopMap.LevelsKeepInMemmory = 5;
            this.stopMap.Location = new System.Drawing.Point(228, 12);
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
            this.stopMap.Size = new System.Drawing.Size(757, 605);
            this.stopMap.TabIndex = 1;
            this.stopMap.Zoom = 0D;
            this.stopMap.Load += new System.EventHandler(this.StopMap_Load);
            // 
            // optionComBox
            // 
            this.optionComBox.FormattingEnabled = true;
            this.optionComBox.Location = new System.Drawing.Point(12, 48);
            this.optionComBox.Name = "optionComBox";
            this.optionComBox.Size = new System.Drawing.Size(121, 21);
            this.optionComBox.TabIndex = 2;
            this.optionComBox.SelectedIndexChanged += new System.EventHandler(this.OptionComBox_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Opciones";
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optionComBox);
            this.Controls.Add(this.stopMap);
            this.Controls.Add(this.splitter1);
            this.Name = "StartWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl stopMap;
        private System.Windows.Forms.ComboBox optionComBox;
        private System.Windows.Forms.Label label1;
    }
}

