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
    public partial class FormSalonKayit : Form
    {
        public FormSalonKayit()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=THEONEDEVELOPER\\MSSQLSERVER01;Initial Catalog=sinemaOtomasyonuDB;Integrated Security=True;");

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if(textSalonAdi.Text!= "" && comboKoltukSayisi.Text!= "")
            {
                conn.Open();
                SqlCommand kaydet = new SqlCommand("INSERT INTO TBL_Salonlar (SalonAdi,KoltukSayisi) VALUES (@salonAdi,@koltukSayisi) ", conn);
                kaydet.Parameters.AddWithValue("@salonAdi", textSalonAdi.Text);
                kaydet.Parameters.AddWithValue("@koltukSayisi", comboKoltukSayisi.Text);
                kaydet.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("SALON KAYDETME İŞLEMİ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİRİLDİ");
                textSalonAdi.Text = "";
                comboKoltukSayisi.Text = "";
                textSalonAdi.Focus();
                listeGetir();
            }
            else
            {
                MessageBox.Show("LUTFEN BIR DEĞER GİRİNİZ !","WARNING!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        void koltukOlustur()
        {
            for(int i = 1; i <= 200; i++)
            {
                comboKoltukSayisi.Items.Add(i);
            }
        }
        void listeGetir()
        {
            panelSalon.Controls.Clear();
            conn.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBL_Salonlar", conn);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                SalonListesi arac = new SalonListesi();
                arac.labelSalonAdi.Text = reader["SalonAdi"].ToString();
                arac.labelKoltukSayisi.Text = reader["KoltukSayisi"].ToString();
                panelSalon.Controls.Add(arac);
            }
            conn.Close();
        }
        private void FormSalonKayit_Load(object sender, EventArgs e)
        {
            listeGetir();
            koltukOlustur();
        }
    }
}
