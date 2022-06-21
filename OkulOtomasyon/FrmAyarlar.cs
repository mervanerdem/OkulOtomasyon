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

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
            ogretmenListesi();
            temizle();
            stuListele();
        }




        sqlbaglantisi bgl = new sqlbaglantisi(); //Ado.Net
        OkulEntities db = new OkulEntities();//Entityframework

        void stuListele()
        {
            gridControl2.DataSource = db.AyarlarOgren();
        }

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



        private void TxtOgrenAdı_Properties_EditValueChanged(object sender, EventArgs e)
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

        private void TxtOgretAd_Properties_EditValueChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Teachers Where OgretmenID = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtOgretAd.ItemIndex +8); //Database ID 8 den başladığından dolayı
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                //kontrol edilecek..
                TxtOgretID.Text = dr["OgretmenID"].ToString();
                TxtBrans.Text = dr["OgretmenBrans"].ToString();
                MskOgretTC.Text = dr["OgretmenTC"].ToString();
                newPath = "D:\\Mervan\\OkulOtomasyon" + "\\Resimler\\" + dr["OgretmenFoto"].ToString();
                pictureEdit1.Image = Image.FromFile(newPath);
            }
            bgl.baglanti().Close();

        }

        //Öğretmen kaydet tuşu
        private void BtnKaydetOgret_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert Into Ayarlar(AyarlarID,OgretSifre) Values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtOgretID.Text);
            komut.Parameters.AddWithValue("@p2", TxtOgretSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("Şifre oluşturuldu.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            temizle();
        }


        //Öğretmen Şifre Güncelleme
        private void BtnGuncelleOgret_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Ayarlar Set OgretSifre = @p1 Where AyarlarID = @p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtOgretSifre.Text);
            komut.Parameters.AddWithValue("@p2", TxtOgretID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şifre Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();

        }

        //Temizle

        void temizle()
        {
            TxtOgretAd.Properties.NullText = "Öğretmen Seçiniz..";
            TxtOgretID.Text = "";
            TxtOgretSifre.Text = "";
            MskOgretTC.Text = "";
            pictureEdit1.Text = "";
            TxtBrans.Text = "";
            
        }

        private void BtnTemizleOgret_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
