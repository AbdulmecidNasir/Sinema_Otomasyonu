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
    public partial class FormAnaForm : Form
    {
        public FormAnaForm()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string kisiAdiSoyadi = "";

        private void button2_Click(object sender, EventArgs e)
        {
            FormYonetmenKayit formy = new FormYonetmenKayit();
            formy.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormYonetmenListesi forml = new FormYonetmenListesi();
            forml.ShowDialog();
        }

        private void btnOyuncuKayitEkrani_Click(object sender, EventArgs e)
        {
            FormOyuncuKayit frm = new FormOyuncuKayit();
            frm.ShowDialog();
        }

        private void btnOyuncuListeEkrani_Click(object sender, EventArgs e)
        {
            FormOyuncuListesi formoyun = new FormOyuncuListesi();
            formoyun.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormSalonKayit forms = new FormSalonKayit();
            forms.ShowDialog();
        }

        private void buttonFilmKayitEkrani_Click(object sender, EventArgs e)
        {
            FormFilmKayit formm = new FormFilmKayit();
            formm.ShowDialog();
        }

        private void buttonFilmListeEkrani_Click(object sender, EventArgs e)
        {
            FormFilmListe forfilm = new FormFilmListe();
            forfilm.ShowDialog();
        }

        private void btnBiletOlusturmaEkrani_Click(object sender, EventArgs e)
        {
            FormBiletOlustur formb = new FormBiletOlustur();
            formb.ShowDialog();
        }

        private void btnBiletSorgulaEkrani_Click_1(object sender, EventArgs e)
        {
            FormBiletSorgula form = new FormBiletSorgula();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormSalonAtama form = new FormSalonAtama();
            form.ShowDialog();
        }
    }
}
