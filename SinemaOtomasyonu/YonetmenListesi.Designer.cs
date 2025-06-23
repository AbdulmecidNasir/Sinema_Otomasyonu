namespace SinemaOtomasyonu
{
    partial class YonetmenListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YonetmenListesi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelID = new System.Windows.Forms.Label();
            this.pbResimDetay = new System.Windows.Forms.PictureBox();
            this.buttonDetay = new System.Windows.Forms.Button();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbResimDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 77);
            this.panel1.TabIndex = 0;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelID.Location = new System.Drawing.Point(246, 11);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(48, 20);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "label1";
            this.labelID.Visible = false;
            // 
            // pbResimDetay
            // 
            this.pbResimDetay.Image = ((System.Drawing.Image)(resources.GetObject("pbResimDetay.Image")));
            this.pbResimDetay.Location = new System.Drawing.Point(13, 0);
            this.pbResimDetay.Name = "pbResimDetay";
            this.pbResimDetay.Size = new System.Drawing.Size(123, 78);
            this.pbResimDetay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResimDetay.TabIndex = 3;
            this.pbResimDetay.TabStop = false;
            // 
            // buttonDetay
            // 
            this.buttonDetay.BackColor = System.Drawing.Color.Orange;
            this.buttonDetay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDetay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetay.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDetay.Location = new System.Drawing.Point(406, 6);
            this.buttonDetay.Name = "buttonDetay";
            this.buttonDetay.Size = new System.Drawing.Size(95, 31);
            this.buttonDetay.TabIndex = 9;
            this.buttonDetay.Text = "DETAY";
            this.buttonDetay.UseVisualStyleBackColor = false;
            this.buttonDetay.Click += new System.EventHandler(this.buttonDetay_Click);
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.Location = new System.Drawing.Point(142, 61);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(43, 17);
            this.lblCinsiyet.TabIndex = 10;
            this.lblCinsiyet.Text = "label1";
            this.lblCinsiyet.Visible = false;
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdSoyad.Location = new System.Drawing.Point(142, 21);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(113, 45);
            this.labelAdSoyad.TabIndex = 1;
            this.labelAdSoyad.Text = "label1";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Crimson;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(406, 46);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(95, 31);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "SIL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // YonetmenListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.buttonDetay);
            this.Controls.Add(this.pbResimDetay);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelAdSoyad);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "YonetmenListesi";
            this.Size = new System.Drawing.Size(504, 77);
            this.Load += new System.EventHandler(this.YonetmenListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResimDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label labelID;
        public System.Windows.Forms.PictureBox pbResimDetay;
        private System.Windows.Forms.Button buttonDetay;
        private System.Windows.Forms.Label lblCinsiyet;
        public System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.Button btnSil;
    }
}
