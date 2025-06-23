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
    public partial class SalonListesi : UserControl
    {
        public SalonListesi()
        {
            InitializeComponent();
        }

        private void gel(object sender, MouseEventArgs e)
        {
            labelSalonAdi.ForeColor = Color.Red;
            this.BackColor = Color.LawnGreen;
        }

        private void ayril(object sender, EventArgs e)
        {
            labelSalonAdi.ForeColor = Color.Black;
            this.BackColor = Color.White;
        }
    }
}
