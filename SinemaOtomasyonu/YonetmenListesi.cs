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
    public partial class YonetmenListesi : UserControl
    {
        public YonetmenListesi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=THEONEDEVELOPER\\MSSQLSERVER01;Initial Catalog=sinemaOtomasyonuDB;Integrated Security=True;");

        private void YonetmenListesi_Load(object sender, EventArgs e)
        {
            conn.Open();
            string sorgu = "SELECT * FROM TB_Yonetmenler WHERE ID = @id";
            SqlCommand command = new SqlCommand(sorgu, conn);
            command.Parameters.AddWithValue("@id", labelID.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                lblCinsiyet.Text = reader["Cinsiyet"].ToString();
            }
            conn.Close();
        }

        private void buttonDetay_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sorgu = "SELECT * FROM TB_Yonetmenler WHERE ID = @id";
            SqlCommand command = new SqlCommand(sorgu, conn);
            command.Parameters.AddWithValue("@id", labelID.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("BIYOGRAFI : " + reader["Biyografi"].ToString(), reader["AdSoyad"].ToString());
            }
            conn.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sil = new SqlCommand("DELETE FROM TB_Yonetmenler WHERE ID = @id",conn);
            sil.Parameters.AddWithValue("@id", labelID.Text);
            sil.ExecuteNonQuery();
            conn.Close();
            this.Hide();
            MessageBox.Show(labelAdSoyad.Text + " Kişisine Ait Kayıt Başarılı Bir Şekilde Silinmiştir","WARNING!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Hide();

        }
    }
}
