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
    public partial class FormBiletSorgula : Form
    {
        public FormBiletSorgula()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=THEONEDEVELOPER\\MSSQLSERVER01;Initial Catalog=sinemaOtomasyonuDB;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            if(txtBiletNo.Text!= "")
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM TBL_Biletler WHERE Bkod = @bkod", conn);
                command.Parameters.AddWithValue("@bkod", txtBiletNo.Text.ToString());
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    FormBiletDetay form = new FormBiletDetay();
                    form.biletNo = txtBiletNo.Text.ToString();
                    txtBiletNo.Text = "";
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("KAYITLI BILET BULANAMADI");
                    conn.Close();
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("LÜTFEN BİLET NUMARASI GİRİNİZ !");
            }


        }
    }
}
