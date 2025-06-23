namespace SinemaOtomasyonu
{
    partial class oListeAraci
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oListeAraci));
            this.pbOListeFoto = new System.Windows.Forms.PictureBox();
            this.labelAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbOListeFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbOListeFoto
            // 
            this.pbOListeFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbOListeFoto.Image")));
            this.pbOListeFoto.Location = new System.Drawing.Point(3, 0);
            this.pbOListeFoto.Name = "pbOListeFoto";
            this.pbOListeFoto.Size = new System.Drawing.Size(36, 38);
            this.pbOListeFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOListeFoto.TabIndex = 0;
            this.pbOListeFoto.TabStop = false;
            // 
            // labelAdi
            // 
            this.labelAdi.AutoSize = true;
            this.labelAdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdi.Location = new System.Drawing.Point(45, 5);
            this.labelAdi.Name = "labelAdi";
            this.labelAdi.Size = new System.Drawing.Size(59, 25);
            this.labelAdi.TabIndex = 1;
            this.labelAdi.Text = "label1";
            this.labelAdi.Click += new System.EventHandler(this.labelAdi_Click);
            this.labelAdi.MouseLeave += new System.EventHandler(this.labelAdi_MouseLeave);
            this.labelAdi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelAdi_MouseMove);
            // 
            // oListeAraci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.labelAdi);
            this.Controls.Add(this.pbOListeFoto);
            this.Name = "oListeAraci";
            this.Size = new System.Drawing.Size(215, 32);
            this.Load += new System.EventHandler(this.oListeAraci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbOListeFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOListeFoto;
        public System.Windows.Forms.Label labelAdi;
    }
}
