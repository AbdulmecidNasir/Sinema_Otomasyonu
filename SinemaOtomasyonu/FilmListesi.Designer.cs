namespace SinemaOtomasyonu
{
    partial class FilmListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmListesi));
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblIdNo = new System.Windows.Forms.Label();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.buttonFilm = new System.Windows.Forms.Button();
            this.pictureBoxNoPhoto = new System.Windows.Forms.PictureBox();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblIdNo);
            this.groupBox8.Controls.Add(this.lblFilmAdi);
            this.groupBox8.Controls.Add(this.buttonFilm);
            this.groupBox8.Controls.Add(this.pictureBoxNoPhoto);
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox8.Size = new System.Drawing.Size(188, 217);
            this.groupBox8.TabIndex = 20;
            this.groupBox8.TabStop = false;
            // 
            // lblIdNo
            // 
            this.lblIdNo.AutoSize = true;
            this.lblIdNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIdNo.Location = new System.Drawing.Point(13, 146);
            this.lblIdNo.Name = "lblIdNo";
            this.lblIdNo.Size = new System.Drawing.Size(53, 23);
            this.lblIdNo.TabIndex = 12;
            this.lblIdNo.Text = "label1";
            this.lblIdNo.Visible = false;
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.Location = new System.Drawing.Point(13, 2);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(63, 28);
            this.lblFilmAdi.TabIndex = 11;
            this.lblFilmAdi.Text = "label1";
            // 
            // buttonFilm
            // 
            this.buttonFilm.BackColor = System.Drawing.Color.Gold;
            this.buttonFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilm.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonFilm.Location = new System.Drawing.Point(13, 175);
            this.buttonFilm.Name = "buttonFilm";
            this.buttonFilm.Size = new System.Drawing.Size(167, 27);
            this.buttonFilm.TabIndex = 10;
            this.buttonFilm.Text = "DETAY";
            this.buttonFilm.UseVisualStyleBackColor = false;
            this.buttonFilm.Click += new System.EventHandler(this.buttonFilm_Click);
            // 
            // pictureBoxNoPhoto
            // 
            this.pictureBoxNoPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNoPhoto.Image")));
            this.pictureBoxNoPhoto.Location = new System.Drawing.Point(13, 29);
            this.pictureBoxNoPhoto.Name = "pictureBoxNoPhoto";
            this.pictureBoxNoPhoto.Size = new System.Drawing.Size(167, 140);
            this.pictureBoxNoPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNoPhoto.TabIndex = 9;
            this.pictureBoxNoPhoto.TabStop = false;
            // 
            // FilmListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox8);
            this.Name = "FilmListesi";
            this.Size = new System.Drawing.Size(208, 223);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button buttonFilm;
        public System.Windows.Forms.PictureBox pictureBoxNoPhoto;
        public System.Windows.Forms.Label lblFilmAdi;
        public System.Windows.Forms.Label lblIdNo;
    }
}
