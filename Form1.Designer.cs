namespace MIOStopsVisualization
{
    partial class Form1
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
            this.imgBanner = new System.Windows.Forms.PictureBox();
            this.butStartOperation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBanner
            // 
            this.imgBanner.ImageLocation = "";
            this.imgBanner.Location = new System.Drawing.Point(12, 12);
            this.imgBanner.Name = "imgBanner";
            this.imgBanner.Size = new System.Drawing.Size(599, 177);
            this.imgBanner.TabIndex = 0;
            this.imgBanner.TabStop = false;
            // 
            // butStartOperation
            // 
            this.butStartOperation.Location = new System.Drawing.Point(251, 214);
            this.butStartOperation.Name = "butStartOperation";
            this.butStartOperation.Size = new System.Drawing.Size(120, 23);
            this.butStartOperation.TabIndex = 1;
            this.butStartOperation.Text = "Iniciar Operacion";
            this.butStartOperation.UseVisualStyleBackColor = true;
            this.butStartOperation.Click += new System.EventHandler(this.ButStartOperation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 290);
            this.Controls.Add(this.butStartOperation);
            this.Controls.Add(this.imgBanner);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBanner;
        private System.Windows.Forms.Button butStartOperation;
    }
}

