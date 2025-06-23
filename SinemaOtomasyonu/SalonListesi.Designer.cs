namespace SinemaOtomasyonu
{
    partial class SalonListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalonListesi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSalonAdi = new System.Windows.Forms.Label();
            this.labelKoltukSayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 96);
            this.panel1.TabIndex = 0;
            this.panel1.MouseLeave += new System.EventHandler(this.ayril);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.ayril);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            // 
            // labelSalonAdi
            // 
            this.labelSalonAdi.AutoSize = true;
            this.labelSalonAdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSalonAdi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSalonAdi.Location = new System.Drawing.Point(138, 22);
            this.labelSalonAdi.Name = "labelSalonAdi";
            this.labelSalonAdi.Size = new System.Drawing.Size(104, 41);
            this.labelSalonAdi.TabIndex = 2;
            this.labelSalonAdi.Text = "label1";
            this.labelSalonAdi.MouseLeave += new System.EventHandler(this.ayril);
            this.labelSalonAdi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            // 
            // labelKoltukSayisi
            // 
            this.labelKoltukSayisi.AutoSize = true;
            this.labelKoltukSayisi.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKoltukSayisi.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelKoltukSayisi.Location = new System.Drawing.Point(204, 59);
            this.labelKoltukSayisi.Name = "labelKoltukSayisi";
            this.labelKoltukSayisi.Size = new System.Drawing.Size(78, 31);
            this.labelKoltukSayisi.TabIndex = 3;
            this.labelKoltukSayisi.Text = "label2";
            this.labelKoltukSayisi.MouseLeave += new System.EventHandler(this.ayril);
            this.labelKoltukSayisi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(118, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Koltuk Sayisi :";
            this.label1.MouseLeave += new System.EventHandler(this.ayril);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            // 
            // SalonListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelKoltukSayisi);
            this.Controls.Add(this.labelSalonAdi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "SalonListesi";
            this.Size = new System.Drawing.Size(275, 96);
            this.MouseLeave += new System.EventHandler(this.ayril);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label labelSalonAdi;
        public System.Windows.Forms.Label labelKoltukSayisi;
        public System.Windows.Forms.Label label1;
    }
}
