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
    public partial class FormOpen : Form
    {
        public FormOpen()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=THEONEDEVELOPER\\MSSQLSERVER01;Initial Catalog=sinemaOtomasyonuDB;Integrated Security=True;");


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            //Veritabanina baglanma islemi sorgulama
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TB_Kullanicilar WHERE KullaniciAdi = @username AND KullaniciSifre = @password",conn);
            command.Parameters.AddWithValue("@username", txtKullaniciAdi.Text);
            command.Parameters.AddWithValue("@password", txtSifre.Text);
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())//Okuma Islemi Basarili ise
            {
                //MessageBox.Show("GIRIS BASARILI", "SUCCESFULL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FormAnaForm frm = new FormAnaForm();
                frm.kisiAdiSoyadi = reader["AdSoyad"].ToString();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("KULLANICI KAYDI BULUNAMADI","WARNING",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            /*
            if(conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Veritabanina Basarili bir Sekilde Baglandi");
            }*/
            conn.Close();
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtKullaniciAdi.Focus();//Imleci Konumlandir

        }
    }
}
