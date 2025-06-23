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
    public partial class uListeAraci : UserControl
    {
        public uListeAraci()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=THEONEDEVELOPER\\MSSQLSERVER01;Initial Catalog=sinemaOtomasyonuDB;Integrated Security=True;");

        private void labelAdi_MouseMove(object sender, MouseEventArgs e)
        {
            labelAdi.Font = new Font(labelAdi.Font.FontFamily, 12, FontStyle.Underline);
        }

        private void labelAdi_MouseLeave(object sender, EventArgs e)
        {
            labelAdi.Font = new Font(labelAdi.Font.FontFamily, 12,FontStyle.Bold);
        }

        private void uListeAraci_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TBL_Secilenler WHERE KISI = @kisi AND TUR = @tur",conn);
            command.Parameters.AddWithValue("@kisi", labelAdi.Text);
            command.Parameters.AddWithValue("@tur", "YÖNETMEN");
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                labelAdi.ForeColor = Color.DarkOrange;
                pbUlisteFoto.ImageLocation = @"A:\Icons\1564534_customer_man_user_account_profile_icon.png";
            }
            else
            {

                labelAdi.ForeColor = Color.Black;
                pbUlisteFoto.ImageLocation = @"A:\Icons\1564534_customer_man_user_account_profile_icon.png";
            }
            conn.Close();
 
        }

        private void labelAdi_Click(object sender, EventArgs e)
        {
            if (labelAdi.ForeColor == Color.Black)
            {
                labelAdi.ForeColor = Color.DarkOrange;
                pbUlisteFoto.ImageLocation = @"A:\Icons\1564534_customer_man_user_account_profile_icon.png";
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO TBL_Secilenler (KISI,TUR) VALUES (@kisi,@tur)", conn);
                command.Parameters.AddWithValue("@kisi", labelAdi.Text);
                command.Parameters.AddWithValue("@tur","YÖNETMEN");
                command.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                labelAdi.ForeColor = Color.Black;
                pbUlisteFoto.ImageLocation = @"A:\Icons\1564534_customer_man_user_account_profile_icon.png";
                conn.Open();
                SqlCommand command = new SqlCommand("DELETE FROM TBL_Secilenler WHERE KISI = @kisi AND TUR = @tur", conn);
                command.Parameters.AddWithValue("@kisi", labelAdi.Text);
                command.Parameters.AddWithValue("@tur", "YÖNETMEN");
                command.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
