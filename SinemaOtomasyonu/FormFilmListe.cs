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
    public partial class FormFilmListe : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=THEONEDEVELOPER\\MSSQLSERVER01;Initial Catalog=sinemaOtomasyonuDB;Integrated Security=True;");

        public FormFilmListe()
        {
            InitializeComponent();
        }
        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFilmListe_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            string sorgu = "SELECT * FROM TBL_Filmler ORDER BY ADI ASC";
            conn.Open();
            SqlCommand command = new SqlCommand(sorgu, conn);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                //verileri getir
                FilmListesi arac = new FilmListesi();
                arac.lblFilmAdi.Text = reader["ADI"].ToString().ToUpper();
                arac.pictureBoxNoPhoto.ImageLocation = reader["AFIS"].ToString();
                arac.lblIdNo.Text = reader["ID"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            conn.Close();
        }

        private void txtAramaYap_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            conn.Open();
            SqlCommand ara = new SqlCommand("SELECT * FROM TBL_Filmler WHERE ADI LIKE '%" + txtAramaYap.Text + "%'", conn);
            SqlDataReader reader = ara.ExecuteReader();
            while (reader.Read())
            {
                //verileri getir
                FilmListesi arac = new FilmListesi();
                arac.lblFilmAdi.Text = reader["ADI"].ToString().ToUpper();
                arac.pictureBoxNoPhoto.ImageLocation = reader["AFIS"].ToString();
                arac.lblIdNo.Text = reader["ID"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            conn.Close();
        }
    }
}
