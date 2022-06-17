using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulOtomasyon
{
    public partial class FrmKimlik : Form
    {
        public FrmKimlik()
        {
            InitializeComponent();
        }

        public string ad, soyad, tc, cinsiyet, dogTarihi, foto;

        private void FrmKimlik_Load(object sender, EventArgs e)
        {
            LblAd.Text = ad;
            LblSoyad.Text = soyad;
            LblTC.Text = tc;
            LblCinsiyet.Text = cinsiyet;
            LblDogumT.Text = dogTarihi;
            pictureEdit1.Image = Image.FromFile(foto);

        }
    }
}
