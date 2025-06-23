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
    public partial class FormYonetmenListesi : Form
    {
        public FormYonetmenListesi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=THEONEDEVELOPER\\MSSQLSERVER01;Initial Catalog=sinemaOtomasyonuDB;Integrated Security=True;");

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormYonetmenListesi_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            conn.Open();
            string sorgu = "SELECT * FROM TB_Yonetmenler";
            SqlCommand command = new SqlCommand(sorgu,conn);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                YonetmenListesi arac = new YonetmenListesi();
                arac.labelID.Text = reader["ID"].ToString();
                arac.labelAdSoyad.Text = reader["AdSoyad"].ToString();
                arac.pbResimDetay.ImageLocation = reader["Resim"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            conn.Close();
        }

        private void txtAramaYap_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            conn.Open();
            SqlCommand ara = new SqlCommand("SELECT * FROM TB_Yonetmenler WHERE AdSoyad LIKE '%" + txtAramaYap.Text + "%'", conn);
            SqlDataReader reader = ara.ExecuteReader();
            while(reader.Read())
            {
                YonetmenListesi arac = new YonetmenListesi();
                arac.labelID.Text = reader["ID"].ToString();
                arac.labelAdSoyad.Text = reader["AdSoyad"].ToString();
                arac.pbResimDetay.ImageLocation = reader["Resim"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            conn.Close();
        }
            
        
    }
}
