namespace MIOStopsVisualization
{
    partial class MapWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stopMap = new GMap.NET.WindowsForms.GMapControl();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.optionComBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.stopMap.Location = new System.Drawing.Point(214, 0);
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
            this.stopMap.Size = new System.Drawing.Size(761, 528);
            this.stopMap.TabIndex = 0;
            this.stopMap.Zoom = 0D;
            this.stopMap.Load += new System.EventHandler(this.StopMap_Load);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(208, 536);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // optionComBox
            // 
            this.optionComBox.FormattingEnabled = true;
            this.optionComBox.Location = new System.Drawing.Point(12, 38);
            this.optionComBox.Name = "optionComBox";
            this.optionComBox.Size = new System.Drawing.Size(121, 21);
            this.optionComBox.TabIndex = 1;
            this.optionComBox.SelectedIndexChanged += new System.EventHandler(this.OptionComBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtros";
            // 
            // MapWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 536);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optionComBox);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.stopMap);
            this.Name = "MapWindow";
            this.Text = "MapWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MapWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl stopMap;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ComboBox optionComBox;
        private System.Windows.Forms.Label label1;
    }
}