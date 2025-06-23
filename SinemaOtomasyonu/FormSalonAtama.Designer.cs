namespace SinemaOtomasyonu
{
    partial class FormSalonAtama
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblSecilen = new System.Windows.Forms.Label();
            this.cbSalon = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panelSeans = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.FilmVizyonTarihi = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbFilmAdi = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.buttonOlustur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDoluSaatler = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 54);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(941, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "[SALON ATAMA EKRANI]";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbSalon);
            this.groupBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.Location = new System.Drawing.Point(19, 149);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox7.Size = new System.Drawing.Size(281, 70);
            this.groupBox7.TabIndex = 23;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "SALON ADI";
            // 
            // lblSecilen
            // 
            this.lblSecilen.AutoSize = true;
            this.lblSecilen.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecilen.Location = new System.Drawing.Point(425, 458);
            this.lblSecilen.Name = "lblSecilen";
            this.lblSecilen.Size = new System.Drawing.Size(73, 25);
            this.lblSecilen.TabIndex = 24;
            this.lblSecilen.Text = "label2";
            this.lblSecilen.Visible = false;
            // 
            // cbSalon
            // 
            this.cbSalon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalon.FormattingEnabled = true;
            this.cbSalon.Location = new System.Drawing.Point(10, 31);
            this.cbSalon.Name = "cbSalon";
            this.cbSalon.Size = new System.Drawing.Size(261, 36);
            this.cbSalon.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.panelSeans);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(321, 60);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox6.Size = new System.Drawing.Size(674, 361);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SAAT/SEANS";
            // 
            // panelSeans
            // 
            this.panelSeans.AutoScroll = true;
            this.panelSeans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSeans.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelSeans.Location = new System.Drawing.Point(10, 30);
            this.panelSeans.Name = "panelSeans";
            this.panelSeans.Padding = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.panelSeans.Size = new System.Drawing.Size(654, 328);
            this.panelSeans.TabIndex = 23;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.FilmVizyonTarihi);
            this.groupBox5.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(17, 227);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox5.Size = new System.Drawing.Size(281, 77);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TARIH";
            this.groupBox5.UseWaitCursor = true;
            // 
            // FilmVizyonTarihi
            // 
            this.FilmVizyonTarihi.Location = new System.Drawing.Point(13, 33);
            this.FilmVizyonTarihi.Name = "FilmVizyonTarihi";
            this.FilmVizyonTarihi.Size = new System.Drawing.Size(258, 34);
            this.FilmVizyonTarihi.TabIndex = 0;
            this.FilmVizyonTarihi.UseWaitCursor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbFilmAdi);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(19, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox4.Size = new System.Drawing.Size(281, 71);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FILM ADI";
            // 
            // cbFilmAdi
            // 
            this.cbFilmAdi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbFilmAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilmAdi.FormattingEnabled = true;
            this.cbFilmAdi.Location = new System.Drawing.Point(10, 32);
            this.cbFilmAdi.Name = "cbFilmAdi";
            this.cbFilmAdi.Size = new System.Drawing.Size(261, 36);
            this.cbFilmAdi.TabIndex = 0;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Crimson;
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.Location = new System.Drawing.Point(19, 375);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(276, 46);
            this.btnTemizle.TabIndex = 37;
            this.btnTemizle.Text = "TEMIZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // buttonOlustur
            // 
            this.buttonOlustur.BackColor = System.Drawing.Color.Lime;
            this.buttonOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOlustur.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonOlustur.Location = new System.Drawing.Point(19, 326);
            this.buttonOlustur.Name = "buttonOlustur";
            this.buttonOlustur.Size = new System.Drawing.Size(276, 43);
            this.buttonOlustur.TabIndex = 36;
            this.buttonOlustur.Text = "TAMAMLA";
            this.buttonOlustur.UseVisualStyleBackColor = false;
            this.buttonOlustur.Click += new System.EventHandler(this.buttonOlustur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDoluSaatler);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(17, 427);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox1.Size = new System.Drawing.Size(281, 70);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DOLU SAATLER";
            this.groupBox1.Visible = false;
            // 
            // cbDoluSaatler
            // 
            this.cbDoluSaatler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbDoluSaatler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoluSaatler.FormattingEnabled = true;
            this.cbDoluSaatler.Location = new System.Drawing.Point(10, 31);
            this.cbDoluSaatler.Name = "cbDoluSaatler";
            this.cbDoluSaatler.Size = new System.Drawing.Size(261, 36);
            this.cbDoluSaatler.TabIndex = 0;
            // 
            // FormSalonAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 421);
            this.Controls.Add(this.lblSecilen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.buttonOlustur);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(450, 220);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormSalonAtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormSalonAtama";
            this.Load += new System.EventHandler(this.FormSalonAtama_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblSecilen;
        private System.Windows.Forms.ComboBox cbSalon;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.FlowLayoutPanel panelSeans;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbFilmAdi;
        private System.Windows.Forms.DateTimePicker FilmVizyonTarihi;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button buttonOlustur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDoluSaatler;
    }
}