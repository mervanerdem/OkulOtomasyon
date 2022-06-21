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
            ogrencilistesi();
        }




        sqlbaglantisi bgl = new sqlbaglantisi(); //Ado.Net
        OkulEntities db = new OkulEntities();//Entityframework


        void stuListele() //Öğrenci listele
        {
            gridControl2.DataSource = db.AyarlarOgren();
        }

        //Entity Framwork ile LookUpEdit Veri getirme
        void ogrencilistesi()
        {
            var k = from data in db.Students
                    select new
                    {
                        OgrID = data.OgrenciID,
                        OgrAdSoyad = data.OgrenciAdı + " " + data.OgrenciSoyadı,
                        OgrSinif = data.OgrenciSınıf,
                        OgrTC = data.OgrenciTC,
                    };
            TxtOgrenAdı.Properties.ValueMember = "OgrID";
            TxtOgrenAdı.Properties.DisplayMember = "OgrAdSoyad";
            TxtOgrenAdı.Properties.NullText = "Öğrenci Seçiniz..";
            TxtOgrenAdı.Properties.DataSource = k.ToList();
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


        //Entityframework ile isim seçildikten sonra verilerin çekilmesi
        private void TxtOgrenAdı_Properties_EditValueChanged(object sender, EventArgs e)
        {
            
            using (OkulEntities db = new OkulEntities())
            {
                Students sorgu = db.Students.Find(TxtOgrenAdı.ItemIndex + 1);
                TxtOgrenID.Text = sorgu.OgrenciID.ToString();
                TxtOgrenSınıf.Text = sorgu.OgrenciSınıf;
                MskOgrenTc.Text = sorgu.OgrenciTC.ToString();
                newPath = "D:\\Mervan\\OkulOtomasyon" + "\\Resimler\\" + sorgu.OgrenciFoto.ToString();
                PctOgrenci.Image = Image.FromFile(newPath);

            }
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

        //Entityframework ile isim seçildikten sonra verilerin çekilmesi

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
            TxtOgrenAdı.Properties.NullText = "Öğrenci Seçiniz...";
            TxtOgrenID.Text = "";
            TxtOgrenSifre.Text = "";
            TxtOgrenSınıf.Text = "";
            MskOgrenTc.Text = "";
            
            
        }
        

        private void BtnTemizleOgret_Click(object sender, EventArgs e)
        {
            temizle();
        }


        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            TxtOgrenID.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle,"AyarOgrenID").ToString();
            TxtOgrenAdı.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OgrenciAdSoyad").ToString();
            TxtOgrenSınıf.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OgrenciSınıf").ToString();
            MskOgrenTc.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OgrenciTC").ToString();
            TxtOgrenSifre.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OgrenSifre").ToString();
            string uzanti = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OgrenciFoto").ToString();
            newPath = "D:\\Mervan\\OkulOtomasyon" + "\\Resimler\\" + uzanti;
            PctOgrenci.Image = Image.FromFile(newPath);
        }

        private void BtnOgrenKaydet_Click(object sender, EventArgs e)
        {
            StudentSet komut = new StudentSet();
            komut.AyarOgrenID = Convert.ToInt32(TxtOgrenID.Text);
            komut.OgrenSifre = TxtOgrenSifre.Text;
            db.StudentSet.Add(komut);
            db.SaveChanges();
            MessageBox.Show("Şifre Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stuListele();
            temizle();

        }

        private void BtnGuncelleOgrenci_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "AyarOgrenID"));
            var item = db.StudentSet.FirstOrDefault(x => x.AyarOgrenID == id);
            item.OgrenSifre = TxtOgrenSifre.Text;
            db.SaveChanges();
            MessageBox.Show("Şifre Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stuListele();
            temizle();
        }

        private void BtnTemizleOgren_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
