using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace SinemaOtomasyonu
{
    public partial class FormFilmKayit : Form
    {
        public FormFilmKayit()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=THEONEDEVELOPER\\MSSQLSERVER01;Initial Catalog=sinemaOtomasyonuDB;Integrated Security=True;");

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            verileriSil();
        }
        void verileriSil()
        {
            conn.Open();
            SqlCommand command = new SqlCommand("DELETE FROM TBL_Secilenler", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
        int selectedNumber = 0;
        private void cbImdbPuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedNumber = int.Parse(cbImdbPuan.SelectedItem.ToString());
        }
        public string resimYolu = "";
        private void buttonFotoYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg | All Files | *.*";
            ofd.FilterIndex = 3;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxNoPhoto.Image = new Bitmap(ofd.FileName);
                resimYolu = ofd.FileName.ToString();
            }
        }
        void bugununTarihi()
        {
            FilmVizyonTarihi.Value = DateTime.Today;
        }
        void yListeGetir()
        {
            string sorgu = "SELECT * FROM TB_Yonetmenler";
            fYonetmenPaneli.Controls.Clear();
            conn.Open();
            SqlCommand komut = new SqlCommand(sorgu, conn);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                uListeAraci arac = new uListeAraci();
                arac.labelAdi.Text = reader["AdSoyad"].ToString();
                fYonetmenPaneli.Controls.Add(arac);
            }
            conn.Close();

        }
        void oListeGetir()
        {
            string sorgu = "SELECT * FROM TBL_Oyuncular";
            fOyunucPaneli.Controls.Clear();
            conn.Open();
            SqlCommand komut = new SqlCommand(sorgu, conn);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                oListeAraci arac = new oListeAraci();
                arac.labelAdi.Text = reader["AdSoyad"].ToString();
                fOyunucPaneli.Controls.Add(arac);
            }
            conn.Close();

        }
        private void textFilmAciklamasi_TextChanged(object sender, EventArgs e)
        {
            //Biyografi textBox icindeki 300 karakter imlecini girilen karakter sayisi kadar azaltiyor
            int karakterSayisi = textFilmAciklamasi.Text.Length;
            int geri = 300 - karakterSayisi;
            labelSayac300.Text = geri.ToString();
            if (geri > 20)
            {
                labelSayac300.ForeColor = Color.Black;
            }
            if (geri <= 50)
            {
                labelSayac300.ForeColor = Color.Orange;
            }
            if (geri <= 20)
            {
                labelSayac300.ForeColor = Color.Red;
            }
        }

        private void FormFilmKayit_Load(object sender, EventArgs e)
        {
            yListeGetir();
            oListeGetir();
            bugununTarihi();
            textFilmAdi.Focus();
        }

        private void textOyuncuAra_TextChanged(object sender, EventArgs e)
        {
            oyuncuAra();
        }
        void oyuncuAra()
        {
            string sorgu = "SELECT * FROM TBL_Oyuncular WHERE AdSoyad LIKE '%" + textOyuncuAra.Text + "%'";
            fOyunucPaneli.Controls.Clear();
            conn.Open();
            SqlCommand komut = new SqlCommand(sorgu, conn);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                oListeAraci arac = new oListeAraci();
                arac.labelAdi.Text = reader["AdSoyad"].ToString();
                fOyunucPaneli.Controls.Add(arac);
            }
            conn.Close();
        }
        void yonetmenAra()
        {
            string sorgu = "SELECT * FROM TB_Yonetmenler WHERE AdSoyad LIKE '%" + textYonetmenAra.Text + "%'";
            fYonetmenPaneli.Controls.Clear();
            conn.Open();
            SqlCommand komut = new SqlCommand(sorgu, conn);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                uListeAraci arac = new uListeAraci();
                arac.labelAdi.Text = reader["AdSoyad"].ToString();
                fYonetmenPaneli.Controls.Add(arac);
            }
            conn.Close();
        }

        private void textYonetmenAra_TextChanged(object sender, EventArgs e)
        {
            yonetmenAra();
        }

        private void labelAksiyon_Click(object sender, EventArgs e)
        {
            if (labelAksiyon.ForeColor == Color.Black)
            {
                labelAksiyon.ForeColor = Color.DarkOrange;
            }
            else
            {
                labelAksiyon.ForeColor = Color.Black;
            }
        }

        private void labelKorku_Click(object sender, EventArgs e)
        {
            if (labelKorku.ForeColor == Color.Black)
            {
                labelKorku.ForeColor = Color.DarkOrange;
            }
            else
            {
                labelKorku.ForeColor = Color.Black;
            }
        }

        private void labelKomedi_Click(object sender, EventArgs e)
        {
            if (labelKomedi.ForeColor == Color.Black)
            {
                labelKomedi.ForeColor = Color.DarkOrange;
            }
            else
            {
                labelKomedi.ForeColor = Color.Black;
            }
        }

        private void labelDrama_Click(object sender, EventArgs e)
        {
            if (labelDrama.ForeColor == Color.Black)
            {
                labelDrama.ForeColor = Color.DarkOrange;
            }
            else
            {
                labelDrama.ForeColor = Color.Black;
            }
        }

        private void labelBIlimKurgu_Click(object sender, EventArgs e)
        {
            if (labelBIlimKurgu.ForeColor == Color.Black)
            {
                labelBIlimKurgu.ForeColor = Color.DarkOrange;
            }
            else
            {
                labelBIlimKurgu.ForeColor = Color.Black;
            }
        }

        private void labelWestern_Click(object sender, EventArgs e)
        {
            if (labelWestern.ForeColor == Color.Black)
            {
                labelWestern.ForeColor = Color.DarkOrange;
            }
            else
            {
                labelWestern.ForeColor = Color.Black;
            }
        }

        private void btnDeneme_Click(object sender, EventArgs e)
        {
            string secilenTurler = ""; // Her tıklamada sıfırlama yapılır

            foreach (Control arac in grBTur.Controls)
            {
                // Sadece Label kontrolü ise ve rengi seçili ise kontrol et
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.DarkOrange)
                    {
                        secilenTurler += " ," + arac.Text; // Seçilen türü ekle
                    }
                }
            }

            // Eğer seçilen türler varsa, mesajda göster
            if (secilenTurler.Length > 2)
            {
                MessageBox.Show($"SEÇİLEN FİLM KATEGORILERI : {secilenTurler.Substring(2)}"); // Başlangıçtaki ", " kısmını kaldırarak göster
            }
            else
            {
                MessageBox.Show("Henüz bir kategori seçilmedi!"); // Hiç kategori seçilmedi mesajı
            }

        }

        private void lblTurkce_Click(object sender, EventArgs e)
        {
            if (lblTurkce.ForeColor == Color.Black)
            {
                lblTurkce.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblTurkce.ForeColor = Color.Black;
            }
        }

        private void lblOzbekce_Click(object sender, EventArgs e)
        {
            if (lblOzbekce.ForeColor == Color.Black)
            {
                lblOzbekce.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblOzbekce.ForeColor = Color.Black;
            }
        }

        private void lblInglızce_Click(object sender, EventArgs e)
        {
            if (lblInglızce.ForeColor == Color.Black)
            {
                lblInglızce.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblInglızce.ForeColor = Color.Black;
            }
        }

        private void lblAltyazı_Click(object sender, EventArgs e)
        {
            if (lblAltyazı.ForeColor == Color.Black)
            {
                lblAltyazı.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblAltyazı.ForeColor = Color.Black;
            }
        }

        private void buttonBicim_Click(object sender, EventArgs e)
        {
            string secilenBicimTurler = ""; // Seçilen türleri tutacak değişken

            foreach (Control arac in gbFilmBicimi.Controls)
            {
                // Sadece Label kontrolü ise ve rengi seçili ise kontrol et
                if (arac is Label && arac.ForeColor == Color.DarkOrange)
                {
                    secilenBicimTurler += " ," + arac.Text; // Seçili türü listeye ekle
                }
            }

            // Eğer seçilen türler varsa, mesajda göster
            if (secilenBicimTurler.Length > 2) // ", " eklenmiş olduğu için > 2 kontrolü
            {
                MessageBox.Show($"SEÇİLEN FILM BİÇİMLERI : {secilenBicimTurler.Substring(2)}"); // Başlangıçtaki ", " kısmını kaldır
            }
            else
            {
                MessageBox.Show("Henüz bir kategori seçilmedi!"); // Hiç kategori seçilmedi mesajı
            }

        }

        private void lblGenelIzleyici_Click(object sender, EventArgs e)
        {
            if (lblGenelIzleyici.ForeColor == Color.Black)
            {
                lblGenelIzleyici.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblGenelIzleyici.ForeColor = Color.Black;
            }
        }

        private void lblOlumsuzOrnek_Click(object sender, EventArgs e)
        {
            if (lblOlumsuzOrnek.ForeColor == Color.Black)
            {
                lblOlumsuzOrnek.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblOlumsuzOrnek.ForeColor = Color.Black;
            }
        }

        private void lblCinsellik_Click(object sender, EventArgs e)
        {
            if (lblCinsellik.ForeColor == Color.Black)
            {
                lblCinsellik.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblCinsellik.ForeColor = Color.Black;
            }
        }

        private void lblKorkuSiddet_Click(object sender, EventArgs e)
        {
            if (lblKorkuSiddet.ForeColor == Color.Black)
            {
                lblKorkuSiddet.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblKorkuSiddet.ForeColor = Color.Black;
            }
        }

        private void lbl18yas_Click(object sender, EventArgs e)
        {
            if (lbl18yas.ForeColor == Color.Black)
            {
                lbl18yas.ForeColor = Color.DarkOrange;
            }
            else
            {
                lbl18yas.ForeColor = Color.Black;
            }
        }

        private void lbl13yas_Click(object sender, EventArgs e)
        {
            if (lbl13yas.ForeColor == Color.Black)
            {
                lbl13yas.ForeColor = Color.DarkOrange;
            }
            else
            {
                lbl13yas.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secilenOzellikTurler = ""; // Seçilen türleri tutacak değişken

            foreach (Control arac in gbFilmOzellikleri.Controls)
            {
                // Sadece Label kontrolü ise ve rengi seçili ise kontrol et
                if (arac is Label && arac.ForeColor == Color.DarkOrange)
                {
                    secilenOzellikTurler += " ," + arac.Text; // Seçili türü listeye ekle
                }
            }

            // Eğer seçilen türler varsa, mesajda göster
            if (secilenOzellikTurler.Length > 2) // ", " eklenmiş olduğu için > 2 kontrolü
            {
                MessageBox.Show($"SEÇİLEN FİLM ÖZELLİKLERİ : {secilenOzellikTurler.Substring(2)}"); // Başlangıçtaki ", " kısmını kaldır
            }
            else
            {
                MessageBox.Show("Henüz bir kategori seçilmedi!"); // Hiç kategori seçilmedi mesajı
            }

        }

        string vTarih = "";
        string durum = "0";
        void vizyonTarihiHesapla()
        {
            vTarih = FilmVizyonTarihi.Value.ToString("dd-MM-yyyy");
            DateTime dVTarih = Convert.ToDateTime(vTarih);
            DateTime bugunTarihi = DateTime.Today;
            TimeSpan tSpan = dVTarih - bugunTarihi;
            if (tSpan.TotalDays < 0)
            {
                MessageBox.Show("GEÇMİŞ TARİHLERE AİT FİLM EKLENMESİ YAPILAMAZ");
                bugununTarihi();
            }
            else if (tSpan.TotalDays == 0)
            {
                durum = "1";
                MessageBox.Show(textFilmAdi.Text.ToUpper() + " FILMI BUGÜN VİZYONDA");
            }
            else
            {
                durum = "0";
                MessageBox.Show(textFilmAdi.Text.ToUpper() + " FILMI" + " " + tSpan.TotalDays.ToString() + " GÜN SONRA VİZYONA GIRECEKTIR");
            }
        }

        private void btnTarihSec_Click_1(object sender, EventArgs e)
        {
            vizyonTarihiHesapla();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToShortDateString();
            lblSaat.Text = DateTime.Now.ToShortTimeString();
        }

        string yonetmen = "";
        string oyuncu = "";
        void secilenYonetmen()
        {
            yonetmen = "";
            string sorgu = "SELECT * FROM TBL_Secilenler WHERE TUR = 'YÖNETMEN'";
            conn.Open();
            SqlCommand command = new SqlCommand(sorgu, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                yonetmen = " ," + reader["KISI"].ToString();
            }
            conn.Close();
        }
        void secilenOyuncu()
        {
            oyuncu = "";
            string sorgu = "SELECT * FROM TBL_Secilenler WHERE TUR = 'OYUNCU'";
            conn.Open();
            SqlCommand command = new SqlCommand(sorgu, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                oyuncu = " ," + reader["KISI"].ToString();
            }
            conn.Close();
        }
        void temizlemeMetodu()
        {
            textFilmAdi.Text = string.Empty;
            textFilmAciklamasi.Text = string.Empty;
            pictureBoxNoPhoto.Image = Image.FromFile("A:\\Icons\\Icons8-Windows-8-City-No-Camera.512.png"); // Fotoğrafı sıfırla
            resimYolu = string.Empty; // Resim yolu sıfırla

            // Yönetmen, oyuncu ve diğer seçimler için de sıfırlama işlemleri yapılabilir
            secilenTurler = string.Empty;
            secilenBicimTurler = string.Empty;
            secilenOzellikTurler = string.Empty;
            yonetmen = string.Empty;
            oyuncu = string.Empty;

            textFilmAdi.Focus();
            verileriSil();
            yListeGetir();
            oListeGetir();
            bugununTarihi();
        }
        private void buttonKayitTamamla_Click(object sender, EventArgs e)
        {
            secilenYonetmen();
            secilenOyuncu();
            kategoriler();
            ozellikler();
            bicimi();

            //Eğer herhangi bir alan boşsa, fonksiyondan çık
            if (!string.IsNullOrWhiteSpace(textFilmAdi.Text) &&
                !string.IsNullOrWhiteSpace(textFilmAciklamasi.Text) &&
                !string.IsNullOrWhiteSpace(yonetmen) &&
                !string.IsNullOrWhiteSpace(oyuncu) &&
                !string.IsNullOrWhiteSpace(resimYolu) &&
                !string.IsNullOrWhiteSpace(vTarih) &&
                !string.IsNullOrWhiteSpace(secilenTurler) &&
                !string.IsNullOrWhiteSpace(secilenBicimTurler) &&
                !string.IsNullOrWhiteSpace(secilenOzellikTurler))
            {
                //insert into deyimini kullanarak verileri veritabanına kaydetme işlemi gerçekleştecegiz
                conn.Open();
                string sorgu = "INSERT INTO TBL_Filmler (ADI,TURU,OZELLIKLERI,BICIMI,YONETMEN,OYUNCU,DETAY,PUAN,AFIS,TARIH,DURUM) VALUES (@adi,@turu,@ozellikleri,@bicimi,@yonetmen,@oyuncu,@detay,@puan,@afis,@tarih,@durum)";
                SqlCommand command = new SqlCommand(sorgu, conn);
                command.Parameters.AddWithValue("@adi", textFilmAdi.Text);
                // Eğer seçilen türler varsa, mesajda göster
                if (secilenTurler.Length > 2)
                {
                    command.Parameters.AddWithValue("@turu", secilenTurler.Substring(2));
                }
                else
                {
                    command.Parameters.AddWithValue("@turu", secilenTurler);
                }
                // Eğer seçilen türler varsa, mesajda göster
                if (secilenOzellikTurler.Length > 2) // ", " eklenmiş olduğu için > 2 kontrolü
                {
                    command.Parameters.AddWithValue("@ozellikleri", secilenOzellikTurler.Substring(2));
                }
                else
                {
                    command.Parameters.AddWithValue("@ozellikleri", secilenOzellikTurler);
                }
                // Eğer seçilen türler varsa, mesajda göster
                if (secilenBicimTurler.Length > 2) // ", " eklenmiş olduğu için > 2 kontrolü
                {
                    command.Parameters.AddWithValue("@bicimi", secilenBicimTurler.Substring(2));
                }
                else
                {
                    command.Parameters.AddWithValue("@bicimi", secilenBicimTurler);
                }
                if (yonetmen.Length > 2) // ", " eklenmiş olduğu için > 2 kontrolü
                {
                    command.Parameters.AddWithValue("@yonetmen", yonetmen.Substring(2));
                }
                else
                {
                    command.Parameters.AddWithValue("@yonetmen", yonetmen);
                }
                if (oyuncu.Length > 2) // ", " eklenmiş olduğu için > 2 kontrolü
                {
                    command.Parameters.AddWithValue("@oyuncu", oyuncu.Substring(2));
                }
                else
                {
                    command.Parameters.AddWithValue("@oyuncu", oyuncu);
                }
                command.Parameters.AddWithValue("@detay", textFilmAciklamasi.Text);
                command.Parameters.AddWithValue("@puan", selectedNumber);
                command.Parameters.AddWithValue("@afis", resimYolu);
                command.Parameters.AddWithValue("@tarih", vTarih);
                command.Parameters.AddWithValue("@durum", durum);
                command.ExecuteNonQuery();
                conn.Close();
                temizlemeMetodu();
                MessageBox.Show("FILM KAYDI BAŞARILI BİR ŞEKİLDE EKLENDİ!");
                
            }
            else
            {
                MessageBox.Show("LÜTFEN İLGİLİ SEÇİMLERİ YAPINIZ!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
      


            string secilenTurler = ""; // Her tıklamada sıfırlama yapılır
            string secilenOzellikTurler = ""; // Seçilen türleri tutacak değişken
            string secilenBicimTurler = ""; // Seçilen türleri tutacak değişken
            void kategoriler()
            {

                foreach (Control arac in grBTur.Controls)
                {
                    // Sadece Label kontrolü ise ve rengi seçili ise kontrol et
                    if (arac is Label)
                    {
                        if (arac.ForeColor == Color.DarkOrange)
                        {
                            secilenTurler += " ," + arac.Text; // Seçilen türü ekle
                        }
                    }
                }

            }
            void ozellikler()
            {
                foreach (Control arac in gbFilmOzellikleri.Controls)
                {
                    // Sadece Label kontrolü ise ve rengi seçili ise kontrol et
                    if (arac is Label && arac.ForeColor == Color.DarkOrange)
                    {
                        secilenOzellikTurler += " ," + arac.Text; // Seçili türü listeye ekle
                    }
                }

            }
            void bicimi()
            {
                foreach (Control arac in gbFilmBicimi.Controls)
                {
                    // Sadece Label kontrolü ise ve rengi seçili ise kontrol et
                    if (arac is Label && arac.ForeColor == Color.DarkOrange)
                    {
                        secilenBicimTurler += " ," + arac.Text; // Seçili türü listeye ekle
                    }
                }
            }

    }
    }
    
    

