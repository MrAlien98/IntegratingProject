namespace MIOStopsVisualization
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.label1 = new System.Windows.Forms.Label();
            this.carga = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.carga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "MIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // carga
            // 
            this.carga.Image = ((System.Drawing.Image)(resources.GetObject("carga.Image")));
            this.carga.Location = new System.Drawing.Point(-2, -1);
            this.carga.Name = "carga";
            this.carga.Size = new System.Drawing.Size(445, 444);
            this.carga.TabIndex = 1;
            this.carga.TabStop = false;
            this.carga.Click += new System.EventHandler(this.carga_Click);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 443);
            this.Controls.Add(this.carga);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.Opacity = 0.8D;
            this.Text = "Loading";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox carga;
    }
}