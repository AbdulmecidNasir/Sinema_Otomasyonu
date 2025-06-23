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
    public partial class FormFilmDetay : Form
    {

        public FormFilmDetay()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=THEONEDEVELOPER\\MSSQLSERVER01;Initial Catalog=sinemaOtomasyonuDB;Integrated Security=True;");

        public string idNO = "";
        private void FormFilmDetay_Load(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM TBL_Filmler WHERE ID = @id";
            conn.Open();
            SqlCommand command = new SqlCommand(sorgu, conn);
            command.Parameters.AddWithValue("@id", idNO);
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                pictureBoxNoPhoto.ImageLocation = reader["AFIS"].ToString();
                lblFilmBicimi.Text = reader["BICIMI"].ToString();
                lblFilmKategori.Text = reader["TURU"].ToString();
                lblFilmOzellikleri.Text = reader["OZELLIKLERI"].ToString();
                lblYonetmen.Text = reader["YONETMEN"].ToString();
                lblOyuncular.Text = reader["OYUNCU"].ToString();
                lblFilmVizyonTarihi.Text = reader["TARIH"].ToString();
                lblFilmPuani.Text = reader["PUAN"].ToString();
                lblFilmAciklamasi.Text = reader["DETAY"].ToString();
                lblFilmAdi.Text = reader["ADI"].ToString().ToUpper();
                lblFilmDurumu.Text = reader["DURUM"].ToString();
            }
            conn.Close();
            if(lblFilmDurumu.Text == "0")
            {
                lblFilmDurumu.Text = "FILM VIZYONDA";
            }
            else
            {
                lblFilmDurumu.Text = "FILM VIZYONA GIRMEDI";
            }
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
