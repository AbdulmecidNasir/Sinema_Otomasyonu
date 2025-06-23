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
namespace SinemaOtomasyonu
{
    public partial class FormSalonAtama : Form
    {
        public FormSalonAtama()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=THEONEDEVELOPER\\MSSQLSERVER01;Initial Catalog=sinemaOtomasyonuDB;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSalonAtama_Load(object sender, EventArgs e)
        {
            filmAdiGetir();
            bugununTarihi();
            salonAdiGetir();
        }
        
        void bugununTarihi()
        {
            FilmVizyonTarihi.Value = DateTime.Today;
            
        }
        void filmAdiGetir()
        {
            string sorgu = "SELECT * FROM TBL_Filmler";
            conn.Open();
            SqlCommand command = new SqlCommand(sorgu, conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string gelenTarih = reader["TARIH"]?.ToString().Trim(); // Veritabanından gelen tarih
                if (string.IsNullOrEmpty(gelenTarih))
                {
                    // Tarih boş veya null ise atla
                    continue;
                }

                DateTime fTarih;

                // Birden fazla formatı kontrol ediyoruz
                if (DateTime.TryParseExact(gelenTarih, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out fTarih) ||
                    DateTime.TryParseExact(gelenTarih, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out fTarih) ||
                    DateTime.TryParse(gelenTarih, out fTarih))
                {
                    DateTime bugun = DateTime.Today;

                    // Bugünden önceki tarihleri ekliyoruz
                    if (fTarih <= bugun)
                    {
                        cbFilmAdi.Items.Add(reader["ADI"].ToString());
                    }
                }
                else
                {
                    // Geçersiz tarih formatını logla
                    Console.WriteLine("Geçersiz tarih formatı: " + gelenTarih);
                }
            }

            conn.Close();
        }


        void salonAdiGetir()
        {
            string sorgu = "SELECT * FROM TBL_Salonlar";
            conn.Open();
            SqlCommand command = new SqlCommand(sorgu, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbSalon.Items.Add(reader["SalonAdi"].ToString());
            }
            conn.Close();
        }

        private void buttonOlustur_Click(object sender, EventArgs e)
        {
            if (buttonOlustur.Text == "TAMAMLA")
            {
                string tarih = FilmVizyonTarihi.Value.ToString("yyyy-MM-dd"); // Veritabanına gönderilecek tarih
                string sorgu = "SELECT DISTINCT Saat FROM TBL_Kontrol WHERE Tarih = @tarih AND SalonAdi = @salonadi";

                try
                {
                    conn.Open(); // Veritabanı bağlantısını açıyoruz

                    SqlCommand command = new SqlCommand(sorgu, conn);

                    // Parametreleri ekliyoruz
                    command.Parameters.AddWithValue("@tarih", tarih); // Tarihi veritabanına uygun formatta gönder
                    command.Parameters.AddWithValue("@salonadi", cbSalon.Text.ToString());

                    SqlDataReader reader = command.ExecuteReader();

                    // Dolu saatleri listeye ekliyoruz
                    while (reader.Read())
                    {
                        cbDoluSaatler.Items.Add(reader["Saat"].ToString());
                    }

                    reader.Close(); // SqlDataReader'ı kapatıyoruz
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    conn.Close(); // Bağlantıyı kapatıyoruz
                }

                seansKontrol();

                // Buton metni ve rengini değiştiriyoruz
                buttonOlustur.Text = "OLUŞTUR";
                buttonOlustur.BackColor = Color.SteelBlue;
            }
            else
            {
                kaydet();
                temizle();
                buttonOlustur.Text = "TAMAMLA";
                buttonOlustur.BackColor = Color.Lime;
            }
        }

        private void SeansSaatler(object sender, EventArgs e)
        {
            foreach(RadioButton item in panelSeans.Controls)
            {
                if(item.Checked)
                {
                    lblSecilen.Text = item.Text.ToString();
                }
            }
        }
        void kaydet()
        {
            string tarih = FilmVizyonTarihi.Value.ToString("dd-MM-yyyy");
            string sorgu = "INSERT INTO TBL_Kontrol (FilmAdi,Tarih,Saat,SalonAdi) VALUES (@filmadi,@tarih,@saat,@salonadi) ";
            conn.Open();
            SqlCommand ekle = new SqlCommand(sorgu, conn);
            ekle.Parameters.AddWithValue("@filmadi",cbFilmAdi.Text);
            ekle.Parameters.AddWithValue("@tarih",tarih);
            ekle.Parameters.AddWithValue("@saat",lblSecilen.Text);
            ekle.Parameters.AddWithValue("@salonadi",cbSalon.Text);
            ekle.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("SALON ATAMA İŞLEMİ GERÇEKLEŞTİRİLDİ!");
        }
        void seansKontrol()
        {
            panelSeans.Controls.Clear();
            for (int i = 10; i <= 22; i++) // Saatler: 10:00 - 22:00
            {
                for (int j = 0; j <= 30; j += 30) // Dakikalar: 00 ve 30
                {
                    RadioButton rnd = new RadioButton
                    {
                        ForeColor = Color.SteelBlue, // Varsayılan renk
                        Width = 150,
                        Height = 40,
                        
                    };
                    rnd.CheckedChanged += new EventHandler(SeansSaatler);
                    // Saat formatını oluştur
                    rnd.Text = j == 0 ? $"{i}:0{j}" : $"{i}:{j}";

                    // Dolu saat kontrolü (kesin eşleşme sağlamak için)
                    bool isDoluSaat = false;
                    foreach (var item in cbDoluSaatler.Items)
                    {
                        string doluSaat = item.ToString().Trim(); // Boşlukları kırp
                        if (doluSaat.Equals(rnd.Text)) // Saat formatı eşleşmesi
                        {
                            isDoluSaat = true;
                            break;
                        }
                    }

                    // Eğer dolu saat bulunmuşsa, rengi değiştir
                    if (isDoluSaat)
                    {
                        rnd.ForeColor = Color.Red;
                    }

                    // RadioButton'u panele ekle
                    panelSeans.Controls.Add(rnd);
                }
            }
        }
        void temizle()
        {
            cbFilmAdi.Items.Clear();
            cbSalon.Items.Clear();
            cbDoluSaatler.Items.Clear();
            lblSecilen.Text = "";
            bugununTarihi();
            filmAdiGetir();
            salonAdiGetir();
            panelSeans.Controls.Clear();
            buttonOlustur.Text = "TAMAMLA";
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
