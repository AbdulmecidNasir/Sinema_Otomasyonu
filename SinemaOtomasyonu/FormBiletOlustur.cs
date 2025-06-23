using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace SinemaOtomasyonu
{
    public partial class FormBiletOlustur : Form
    {
        public FormBiletOlustur()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=THEONEDEVELOPER\\MSSQLSERVER01;Initial Catalog=sinemaOtomasyonuDB;Integrated Security=True;");

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBiletOlustur_Load(object sender, EventArgs e)
        {
            filmAdiGetir();
            biletNoOlustur();
        }
        void biletNoOlustur()
        {
            //kod oluşturma işlemi gerçekleştireceğiz./Random
            Random random = new Random();
            string characters = "12345678998765432112345678";
            string kod = "";
            for (int i = 1; i < 11; i++)
            {
                kod += characters[random.Next(characters.Length)];
            }
            textBiletNo.Text = kod.ToString();
        }
        void filmAdiGetir()
        {
            string sorgu = "SELECT * FROM TBL_Filmler";
            conn.Open();
            SqlCommand command = new SqlCommand(sorgu, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                // Tarih dönüşümü için try-catch bloğu ekledik
                try
                {
                    string gelenTarih = reader["TARIH"].ToString();
                    DateTime fTarih = Convert.ToDateTime(gelenTarih);
                    DateTime bugun = DateTime.Today;
                    TimeSpan timeSpan = fTarih - bugun;
                    if (timeSpan.TotalDays <= 0)
                    {
                        cbFilmAdi.Items.Add(reader["ADI"].ToString());
                    }
                }
                catch (FormatException)
                {
                    // Hatalı tarih formatını atla
                    continue;
                }
            }
            conn.Close();
        }
        private void cbFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTarih.Items.Clear();
            string sorgu = "SELECT DISTINCT Tarih FROM TBL_Kontrol WHERE FilmAdi = @filmAdi";
            conn.Open();
            SqlCommand command = new SqlCommand(sorgu, conn);
            command.Parameters.AddWithValue("@filmAdi", cbFilmAdi.Text.ToString());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbTarih.Items.Add(reader["Tarih"].ToString());
            }
            conn.Close();
        }
        void sectiklerimiz()
        {
            textSecilenKoltuklar.Text = "";
            foreach (string item in lbBelirlenen.Items)
            {
                textSecilenKoltuklar.Text += "," + item;
            }
            if (textSecilenKoltuklar.Text.Length > 1)
            {
                textSecilenKoltuklar.Text = textSecilenKoltuklar.Text.Substring(1);
            }
        }
        void kaydetmeMetodu()
        {
            string sorgu = "INSERT INTO TBL_Biletler (Bkod,AdSoyad,TellNo,KoltukNO,FilmAdi,Tarih,Saat,Salon,Tur,IslemSaati) VALUES (@bkod,@adsoyad,@tellno,@koltukno,@filmadi,@tarih,@saat,@salon,@tur,@islemsaati)";
            conn.Close();
            conn.Open();
            SqlCommand kayit = new SqlCommand(sorgu, conn);
            kayit.Parameters.AddWithValue("@bkod", textBiletNo.Text.ToString());
            kayit.Parameters.AddWithValue("@adsoyad", textAdSoyad.Text.ToString());
            kayit.Parameters.AddWithValue("@tellno", textTellNo.Text.ToString());
            kayit.Parameters.AddWithValue("@koltukno", textSecilenKoltuklar.Text.ToString());
            kayit.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            kayit.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
            kayit.Parameters.AddWithValue("@saat", lblSeansSec.Text.ToString());
            kayit.Parameters.AddWithValue("@salon", cbSalon.Text.ToString());
            kayit.Parameters.AddWithValue("@tur", cbBiletTuru.Text.ToString());
            kayit.Parameters.AddWithValue("@islemsaati", DateTime.Now.ToString());
            kayit.ExecuteNonQuery();
            conn.Close();

            string sorgular = "UPDATE TBL_Kontrol SET Koltuklar = @numara WHERE FilmAdi = @filmadi AND Tarih = @tarih AND Saat = @saat AND SalonAdi = @salonadi";
            conn.Open();
            SqlCommand guncelle = new SqlCommand(sorgular, conn);
            if (lblGelenKoltuk.Text.ToString() == "")
            {
                guncelle.Parameters.AddWithValue("@numara",textSecilenKoltuklar.Text.ToString());
            }
            else
            {
                guncelle.Parameters.AddWithValue("@numara", lblGelenKoltuk.Text.ToString() + "," + textSecilenKoltuklar.Text.ToString());
            }
            guncelle.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            guncelle.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
            guncelle.Parameters.AddWithValue("@saat", lblSeansSec.Text.ToString());
            guncelle.Parameters.AddWithValue("@salonadi", cbSalon.Text.ToString());
            guncelle.ExecuteNonQuery();
            conn.Close();
            
            MessageBox.Show("BİLET SATIŞI BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİRİLDİ!");
            salonDurumGeldi();
            lblGelenKoltuk.Text = "";
            listeGelenKoltuk.Items.Clear();
            lbBelirlenen.Items.Clear();
            textSecilenKoltuklar.Text = "";
        }
        void biletNOSorgula()
        {
            string sorgu = "SELECT * FROM TBL_Biletler WHERE Bkod = @no";
            conn.Open();
            SqlCommand command = new SqlCommand(sorgu, conn);
            command.Parameters.AddWithValue("@no", textBiletNo.Text.ToString());
            SqlDataReader reader = command.ExecuteReader();
            if (!reader.Read())
            {
                kaydetmeMetodu();
            }
            else
            {
                biletNoOlustur();
                conn.Close();
                biletNOSorgula();
            }
            conn.Close();
        }

        private void buttonOlustur_Click(object sender, EventArgs e)
        {
            if (textAdSoyad.Text != "" && textBiletNo.Text != "" && textSecilenKoltuklar.Text != "" && textTellNo.Text != "" && cbBiletTuru.Text != "" && cbFilmAdi.Text != "" && cbSalon.Text != "" && cbTarih.Text != "")
            {
                //kayıt işlemlerimiz bu alanda geçrekleştirilecektir.|
                biletNOSorgula();//ve sorgulama sonucunda var olan numara veritabanında kayıtlı değil ise kayıt ekleme işlemi gerçekleştirilecektir.bu medodun içerisnde işlmeler yapılacaktır.
            }
            else
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI EKSİKSİZ DOLDURUNUZ!");
            }
        }
            void doldur()
            {
                koltukPaneli.Controls.Clear();
                int sayi = Convert.ToInt16(lblKoltukSayisi.Text);
                for (int i = 1; i <= sayi; i++)
                {
                    Button btn = new Button();
                    if (i <= 10)
                    {
                        btn.Text = "A" + i.ToString();
                        btn.Name = "A" + i.ToString();
                    }
                    else if (i <= 20)
                    {
                        btn.Text = "B" + i.ToString();
                        btn.Name = "B" + i.ToString();
                    }
                    else if (i <= 30)
                    {
                        btn.Text = "C" + i.ToString();
                        btn.Name = "C" + i.ToString();
                    }
                    else if (i <= 40)
                    {
                        btn.Text = "D" + i.ToString();
                        btn.Name = "D" + i.ToString();
                    }
                    else if (i <= 50)
                    {
                        btn.Text = "E" + i.ToString();
                        btn.Name = "E" + i.ToString();
                    }
                    else if (i <= 60)
                    {
                        btn.Text = "F" + i.ToString();
                        btn.Name = "F" + i.ToString();
                    }
                    else if (i <= 70)
                    {
                        btn.Text = "G" + i.ToString();
                        btn.Name = "G" + i.ToString();
                    }
                    else if (i <= 80)
                    {
                        btn.Text = "H" + i.ToString();
                        btn.Name = "H" + i.ToString();
                    }
                    else if (i <= 90)
                    {
                        btn.Text = "I" + i.ToString();
                        btn.Name = "I" + i.ToString();
                    }
                    else if (i <= 100)
                    {
                        btn.Text = "J" + i.ToString();
                        btn.Name = "J" + i.ToString();
                    }
                    btn.Width = 80;
                    btn.Height = 80;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.ForeColor = Color.Yellow;
                    btn.Click += Btn_Click;
                    if (listeGelenKoltuk.Items.Contains(btn.Text))
                    {
                        btn.Image = (System.Drawing.Image)(Properties.Resources.chair);
                        btn.Image = new Bitmap(Properties.Resources.chair, new Size(63, 62));
                        btn.ForeColor = Color.Black;
                        //btn.BackColor = Color.Red;
                    }
                    else
                    {
                        btn.Image = (System.Drawing.Image)(Properties.Resources.seat_5198161);
                        btn.Image = new Bitmap(Properties.Resources.seat_5198161, new Size(63, 62));
                        btn.ForeColor = Color.Red;
                        //btn.BackColor = Color.Purple;
                    }
                    koltukPaneli.Controls.Add(btn);
                }
            }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.ForeColor == Color.Black)//arkaplan kırmızı // dolu
            {
                MessageBox.Show("BU KOLTUK DOLUDUR!");
            }
            else
            {
                if (btn.ForeColor == Color.Orange)
                {
                    // Koltuğu iptal edip boş hale getir
                    btn.Image = new Bitmap(Properties.Resources.seat_5198161, new Size(63, 62));
                    btn.ForeColor = Color.Red; // Boş koltuk
                    lbBelirlenen.Items.Remove(btn.Text); // Seçim listesinden çıkar
                    sectiklerimiz();
                }
                else
                {
                    // Koltuk boşsa, seçili hale getir
                    btn.Image = new Bitmap(Properties.Resources.sofa, new Size(63, 62));
                    btn.ForeColor = Color.Orange; // Seçili koltuk
                    lbBelirlenen.Items.Add(btn.Text); // Seçim listesine ekle
                    sectiklerimiz();
                }
            }
        }
        private void cbTarih_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string saatler = "";
            panelSeans.Controls.Clear();
            string sorgu = "SELECT DISTINCT Saat FROM TBL_Kontrol WHERE FilmAdi = @filmAdi AND Tarih = @tarih";
            conn.Open();
            SqlCommand command = new SqlCommand(sorgu, conn);
            command.Parameters.AddWithValue("@filmAdi", cbFilmAdi.Text);
            command.Parameters.AddWithValue("@tarih", cbTarih.Text);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                saatler = reader["Saat"].ToString();
                RadioButton rdn = new RadioButton();
                rdn.Text = saatler;
                rdn.ForeColor = Color.Red;
                rdn.Width = 80;
                panelSeans.Controls.Add(rdn);
                rdn.CheckedChanged += new EventHandler(seansSaatleri);

            }
            conn.Close();
        }
        void seansSaatleri(object sender, EventArgs e)
        {
            foreach (RadioButton item in panelSeans.Controls)
            {
                if (item.Checked)
                {
                    lblSeansSec.Text = item.Text;
                    cbSalon.Items.Clear();

                    string sorgu = "SELECT DISTINCT SalonAdi FROM TBL_Kontrol WHERE FilmAdi = @filmAdi AND Tarih = @tarih AND Saat = @saat";
                    conn.Open();
                    SqlCommand command = new SqlCommand(sorgu, conn);
                    command.Parameters.AddWithValue("@filmAdi", cbFilmAdi.Text);
                    command.Parameters.AddWithValue("@tarih", cbTarih.Text);
                    command.Parameters.AddWithValue("@saat", lblSeansSec.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cbSalon.Items.Add(reader["SalonAdi"].ToString());

                    }
                    conn.Close();
                }
            }
        }
        void koltukGetir()
        {
            lblGelenKoltuk.Text = "";
            panelSeans.Controls.Clear();
            string sorgu = "SELECT * FROM TBL_Kontrol WHERE FilmAdi = @filmAdi AND Tarih = @tarih AND Saat = @saat AND SalonAdi = @salonAdi";
            conn.Open();
            SqlCommand command = new SqlCommand(sorgu, conn);
            command.Parameters.AddWithValue("@filmAdi", cbFilmAdi.Text);
            command.Parameters.AddWithValue("@tarih", cbTarih.Text);
            command.Parameters.AddWithValue("@saat", lblSeansSec.Text);
            command.Parameters.AddWithValue("@salonAdi", cbSalon.Text);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblGelenKoltuk.Text = " ," + reader["Koltuklar"].ToString();
                if (lblGelenKoltuk.Text.Length > 2)
                {
                    lblGelenKoltuk.Text = lblGelenKoltuk.Text.Substring(2);
                }
                else
                {
                    lblGelenKoltuk.Text = "";
                }
            }
            conn.Close();
            koltukAyirma();
        }
        void koltukAyirma()
        {
            listeGelenKoltuk.Items.Clear();
            string no = "";
            string[] sec;
            no = lblGelenKoltuk.Text.ToString();
            sec = no.Split(',');
            foreach (string bulunan in sec)
            {
                listeGelenKoltuk.Items.Add(bulunan);
            }
        }
        private void cbSalon_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            salonDurumGeldi();
        }
        void salonDurumGeldi()
        {
            string sorgu = "SELECT * FROM TBL_Salonlar WHERE SalonAdi = @salonAdi";
            conn.Open();
            SqlCommand command = new SqlCommand(sorgu, conn);
            command.Parameters.AddWithValue("@salonAdi", cbSalon.Text);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblKoltukSayisi.Text = reader["KoltukSayisi"].ToString();
            }
            conn.Close();
            koltukGetir();
            doldur();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblGelenKoltuk.Text = "";
            lblKoltukSayisi.Text = "";
            lblSeansSec.Text = "";
            textBiletNo.Text = "";
            textAdSoyad.Text = "";
            textTellNo.Text = "";
            textSecilenKoltuklar.Text = "";
            cbBiletTuru.Text = "";
            cbSalon.Text = "";
            cbTarih.Text = "";
            cbSalon.Items.Clear();
            cbTarih.Items.Clear();
            cbBiletTuru.Items.Clear();
            cbBiletTuru.Items.Add("YETİŞKİN");
            cbBiletTuru.Items.Add("ÖĞRENCİ");
            biletNoOlustur();
            panelSeans.Controls.Clear();
            koltukPaneli.Controls.Clear();
            lbBelirlenen.Items.Clear();
            cbFilmAdi.Items.Clear();
            listeGelenKoltuk.Items.Clear();
            filmAdiGetir();
            textAdSoyad.Focus();
        }

    }
    
}
