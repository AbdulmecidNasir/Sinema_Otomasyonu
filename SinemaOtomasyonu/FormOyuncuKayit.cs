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
    public partial class FormOyuncuKayit : Form
    {
        public FormOyuncuKayit()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=THEONEDEVELOPER\\MSSQLSERVER01;Initial Catalog=sinemaOtomasyonuDB;Integrated Security=True;");

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
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
        public string cinsiyet = "0";
        private void radioButtonErkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "0";
        }

        private void radioButtonKadin_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "1";
        }
        public string bYas = "0";
        void yasHesaplama()
        {
            //Buradan Kullanicidan Dogum Tarihini Alip Yas olarak Ceviriyoruz
            string dogum = dogumTarihSecim.Value.ToString();
            DateTime dogumTarihi = Convert.ToDateTime(dogum);
            DateTime bugun = DateTime.Today;
            int yas = bugun.Year - dogumTarihi.Year;
            bYas = yas.ToString();
        }
        void aracTemizleme()
        {
            textAd.Text = "";
            textSoyad.Text = "";
            textBoxBiyografi.Text = "";
            radioButtonErkek.Checked = true;
            radioButtonKadin.Checked = false;
            labelSayac300.Text = "300";
            cinsiyet = "0";
            bYas = "0";
            pictureBoxNoPhoto.ImageLocation = @"A:\Icons\Icons8-Windows-8-City-No-Camera.512.png";
            textAd.Focus();
        }

        private void textBoxBiyografi_TextChanged(object sender, EventArgs e)
        {
            //Biyografi textBox icindeki 300 karakter imlecini girilen karakter sayisi kadar azaltiyor
            int karakterSayisi = textBoxBiyografi.Text.Length;
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

        private void buttonKayitTamamla_Click(object sender, EventArgs e)
        {
            //Kaydet butona yonetmler ile ilgili verileri veri tabanina kayit edecek
            yasHesaplama();
            if (textAd.Text != "" && textSoyad.Text != "" && textBoxBiyografi.Text != "" && resimYolu != "")
            {
                string adSoyad = textAd.Text.ToString() + " " + textSoyad.Text.ToString();
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO TBL_Oyuncular (AdSoyad,Cinsiyet,Yas,Biyografi,Resim) VALUES (@adsoyad,@cinsiyet,@yas,@biyografi,@resim)", conn);
                command.Parameters.AddWithValue("@adsoyad", adSoyad);
                command.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                command.Parameters.AddWithValue("@yas", bYas);
                command.Parameters.AddWithValue("@biyografi", textBoxBiyografi.Text.ToString());
                command.Parameters.AddWithValue("@resim", resimYolu);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("OYUNCU KAYIT ISLEMI BASARILI BIR SEKILDE GERCEKLESTIRILDI !");
                aracTemizleme();
            }
            else
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI EKSİKSİZ BİR ŞEKİLDE DOLDURUNUZ !", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
