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
using System.IO;

namespace OkulOtomasyon
{
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            //Öğretmenler Ado.Net ile Bağlantı yapılacak.
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Execute AyarlarOgret", bgl.baglanti());
            da1.Fill(dt1);
            gridControl1.DataSource = dt1;

        }

        //Ado.net lookupedit aracı veri getirme

        void ogretmenListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select OgretmenID,(OgretmenAdı + ' | ' + OgretmenSoyadı) as OgretmenAdSoyad," +
                "OgretmenBrans From Teachers", bgl.baglanti());
            da.Fill(dt);
            TxtOgretAd.Properties.ValueMember = "OgretmenID";
            TxtOgretAd.Properties.DisplayMember = "OgretmenAdSoyad";
            TxtOgretAd.Properties.NullText = "Öğretmen Seçiniz..";
            TxtOgretAd.Properties.DataSource = dt;
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
            ogretmenListesi();
        }

        private void TxtOgrenAdı_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtOgretAd_Properties_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        public string newPath;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtOgretID.Text = dr["AyarlarID"].ToString();
                TxtOgretAd.Text = dr["OgretAdSoyad"].ToString();
                TxtBrans.Text = dr["OgretmenBrans"].ToString();
                MskOgretTC.Text = dr["OgretmenTC"].ToString();
                TxtOgretSifre.Text = dr["OgretSifre"].ToString();
                newPath = "D:\\Mervan\\OkulOtomasyon" + "\\Resimler\\" + dr["OgretmenFoto"].ToString();
                pictureEdit1.Image = Image.FromFile(newPath);

            }
        }
    }
}
