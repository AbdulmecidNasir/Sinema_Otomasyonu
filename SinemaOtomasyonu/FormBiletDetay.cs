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
    public partial class FormBiletDetay : Form
    {
        public FormBiletDetay()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=THEONEDEVELOPER\\MSSQLSERVER01;Initial Catalog=sinemaOtomasyonuDB;Integrated Security=True;");

        public string biletNo = "";
        private void FormBiletDetay_Load(object sender, EventArgs e)
        {
            lblBiletNo.Text = biletNo;
            lblBiletNo2.Text = biletNo;
            barkodNoOlustur();
            bilgiGetir();
        }
        public string idNO = "";
        void bilgiGetir()
        {
            string sorgu = "SELECT * FROM TBL_Biletler WHERE Bkod = @bkod";
            conn.Open();
            SqlCommand command = new SqlCommand(sorgu, conn);
            command.Parameters.AddWithValue("@bkod", biletNo);
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                lblFilmAdi.Text = reader["FilmAdi"].ToString();
                lblFilmAdi2.Text = reader["FilmAdi"].ToString();
                lblTelNo.Text = reader["TellNo"].ToString();
                lblAdSoyad.Text = reader["AdSoyad"].ToString();
                lblBIletTuru.Text = reader["Tur"].ToString();
                lblSalonAdi.Text = reader["Salon"].ToString();
                lblSalon2.Text = reader["Salon"].ToString();
                lblTarih2.Text = reader["Tarih"].ToString() + " " + reader["Saat"].ToString();
                lblTarihSaat.Text = reader["Tarih"].ToString() + " " + reader["Saat"].ToString();
                lblIslemTarih.Text = reader["IslemSaati"].ToString();
                lblKoltuklar.Text = reader["KoltukNO"].ToString();
                lblKoltuk2.Text = reader["KoltukNO"].ToString();            
            }
            conn.Close();

        }
        void barkodNoOlustur()
        {
            //kod oluşturma işlemi gerçekleştireceğiz./Random
            Random random = new Random();
            string characters = "12345678998765432112345678";
            string kod = "";
            for (int i = 1; i < 11; i++)
            {
                kod += characters[random.Next(characters.Length)];
            }
            lblBarkod1.Text = kod.ToString();
            lblBarkod2.Text = kod.ToString();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
