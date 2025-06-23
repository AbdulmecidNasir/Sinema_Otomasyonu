using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class FilmListesi : UserControl
    {
        public FilmListesi()
        {
            InitializeComponent();
        }

        private void buttonFilm_Click(object sender, EventArgs e)
        {
            FormFilmDetay form = new FormFilmDetay();
            form.idNO = lblIdNo.Text;
            form.ShowDialog();
        }
    }
}
