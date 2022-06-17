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
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            //5.Sınıf
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Students Where OgrenciSınıf='5.Sınıf'",bgl.baglanti());
            da1.Fill(dt1);
            GrdCtr5.DataSource = dt1;

            //6.Sınıf
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Students Where OgrenciSınıf='6.Sınıf'", bgl.baglanti());
            da2.Fill(dt2);
            GrdCtr6.DataSource = dt2;

            //7.Sınıf
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Select * From Students Where OgrenciSınıf='7.Sınıf'", bgl.baglanti());
            da3.Fill(dt3);
            GrdCtr7.DataSource = dt3;

            //5.Sınıf
            DataTable dt4= new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Select * From Students Where OgrenciSınıf='8.Sınıf'", bgl.baglanti());
            da4.Fill(dt4);
            GrdCtr8.DataSource = dt4;
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }


        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void GrdCtr6_Click(object sender, EventArgs e)
        {

        }
        public string cinsiyet;


        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert Into Students (OgrenciAdı,OgrenciSoyadı,OgrenciNo,OgrenciTC,OgrenciSınıf,OgrenciDogumT," +
                "OgrenciCinsiyet,OgrenciAdres) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskOgrenciNo.Text);
            komut.Parameters.AddWithValue("@p4", MskTc.Text);
            komut.Parameters.AddWithValue("@p5", CmbxSınıf.Text);
            komut.Parameters.AddWithValue("@p6", dateEdit1.Text);
            if (RdBtnErkek.Checked == true)
            {
                komut.Parameters.AddWithValue("@p7", cinsiyet="E");
            }
            if (RdBtnKadın.Checked == true)
            {
                komut.Parameters.AddWithValue("@p7", cinsiyet = "K");
            }

            komut.Parameters.AddWithValue("@p8", RchAdres.Text);
            komut.Parameters.AddWithValue("@p9", Path.GetFileName(newPath));

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci başarıyla eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                TxtID.Text = dr["OgrenciID"].ToString();
                TxtAd.Text = dr["OgrenciAdı"].ToString();
                TxtSoyad.Text = dr["OgrenciSoyadı"].ToString();
                MskTc.Text = dr["OgrenciTC"].ToString();
                MskOgrenciNo.Text = dr["OgrenciNo"].ToString();
                CmbxSınıf.Text = dr["OgrenciSınıf"].ToString();
                if (dr["OgrenciCinsiyet"].ToString() == "E")
                {
                    RdBtnErkek.Checked = true;
                }
                if (dr["OgrenciCinsiyet"].ToString() == "K")
                {
                    RdBtnKadın.Checked = true;
                }
                RchAdres.Text = dr["OgrenciAdres"].ToString();
                dateEdit1.Text = dr["OgrenciDogumT"].ToString();
                newPath = "D:\\Mervan\\OkulOtomasyon" + "\\Resimler\\" + dr["OgrenciFoto"].ToString();
                PctEditOgrenci.Image = Image.FromFile(newPath);
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                TxtID.Text = dr["OgrenciID"].ToString();
                TxtAd.Text = dr["OgrenciAdı"].ToString();
                TxtSoyad.Text = dr["OgrenciSoyadı"].ToString();
                MskTc.Text = dr["OgrenciTC"].ToString();
                MskOgrenciNo.Text = dr["OgrenciNo"].ToString();
                CmbxSınıf.Text = dr["OgrenciSınıf"].ToString();
                if (dr["OgrenciCinsiyet"].ToString() == "E")
                {
                    RdBtnErkek.Checked = true;
                }
                if (dr["OgrenciCinsiyet"].ToString() == "K")
                {
                    RdBtnKadın.Checked = true;
                }
                RchAdres.Text = dr["OgrenciAdres"].ToString();
                dateEdit1.Text = dr["OgrenciDogumT"].ToString();
                newPath = "D:\\Mervan\\OkulOtomasyon" + "\\Resimler\\" + dr["OgrenciFoto"].ToString();
                PctEditOgrenci.Image = Image.FromFile(newPath);
            }
        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            if (dr != null)
            {
                TxtID.Text = dr["OgrenciID"].ToString();
                TxtAd.Text = dr["OgrenciAdı"].ToString();
                TxtSoyad.Text = dr["OgrenciSoyadı"].ToString();
                MskTc.Text = dr["OgrenciTC"].ToString();
                MskOgrenciNo.Text = dr["OgrenciNo"].ToString();
                CmbxSınıf.Text = dr["OgrenciSınıf"].ToString();
                if (dr["OgrenciCinsiyet"].ToString() == "E")
                {
                    RdBtnErkek.Checked = true;
                }
                if (dr["OgrenciCinsiyet"].ToString() == "K")
                {
                    RdBtnKadın.Checked = true;
                }
                RchAdres.Text = dr["OgrenciAdres"].ToString();
                dateEdit1.Text = dr["OgrenciDogumT"].ToString();
                newPath = "D:\\Mervan\\OkulOtomasyon" + "\\Resimler\\" + dr["OgrenciFoto"].ToString();
                PctEditOgrenci.Image = Image.FromFile(newPath);
            }
        }

        private void gridView4_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            if (dr != null)
            {
                TxtID.Text = dr["OgrenciID"].ToString();
                TxtAd.Text = dr["OgrenciAdı"].ToString();
                TxtSoyad.Text = dr["OgrenciSoyadı"].ToString();
                MskTc.Text = dr["OgrenciTC"].ToString();
                MskOgrenciNo.Text = dr["OgrenciNo"].ToString();
                CmbxSınıf.Text = dr["OgrenciSınıf"].ToString();
                if (dr["OgrenciCinsiyet"].ToString() == "E")
                {
                    RdBtnErkek.Checked = true;
                }
                if (dr["OgrenciCinsiyet"].ToString() == "K")
                {
                    RdBtnKadın.Checked = true;
                }
                RchAdres.Text = dr["OgrenciAdres"].ToString();
                dateEdit1.Text = dr["OgrenciDogumT"].ToString();
                newPath = "D:\\Mervan\\OkulOtomasyon" + "\\Resimler\\" + dr["OgrenciFoto"].ToString();
                PctEditOgrenci.Image = Image.FromFile(newPath);
            }
        }

        public string newPath;
        private void BtnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpeg;*.png;*.jpg;*.nef | Tüm dosyalar | *.*";
            dosya.ShowDialog();

            string filePath = dosya.FileName;
            newPath = "D:\\Mervan\\OkulOtomasyon" + "\\Resimler\\" + Guid.NewGuid().ToString() + ".jpeg";
            File.Copy(filePath, newPath);
            PctEditOgrenci.Image = Image.FromFile(filePath);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Students set " +
                "OgrenciAdı = @p1,OgrenciSoyadı = @p2 ,OgrenciNo = @p3, OgrenciTC = @p4," +
                "OgrenciSınıf = @p5, OgrenciDogumT = @p6, OgrenciCinsiyet = @p7, OgrenciAdres = @p8," +
                "OgrenciFoto = @p9 Where OgrenciID = @p10", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskOgrenciNo.Text);
            komut.Parameters.AddWithValue("@p4", MskTc.Text);
            komut.Parameters.AddWithValue("@p5", CmbxSınıf.Text);
            komut.Parameters.AddWithValue("@p6", dateEdit1.Text);
            if (RdBtnErkek.Checked == true)
            {
                komut.Parameters.AddWithValue("@p7", cinsiyet = "E");
            }
            if (RdBtnKadın.Checked == true)
            {
                komut.Parameters.AddWithValue("@p7", cinsiyet = "K");
            }

            komut.Parameters.AddWithValue("@p8", RchAdres.Text);
            komut.Parameters.AddWithValue("@p9", Path.GetFileName(newPath));
            komut.Parameters.AddWithValue("@p10", TxtID.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Students Where OgrenciID = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("Personel Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        void temizle()
        {
            TxtID.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            MskTc.Text = "";
            MskOgrenciNo.Text = "";
            CmbxSınıf.Text = "";
            dateEdit1.Text = "";
            RchAdres.Text = "";
            RdBtnErkek.Checked = false;
            RdBtnKadın.Checked = false;
            dateEdit1.Text = "";
            PctEditOgrenci.Text = "";
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            FrmKimlik frm = new FrmKimlik();

            if (dr != null)
            {
                frm.ad = dr["OgrenciAdı"].ToString();
                frm.soyad = dr["OgrenciSoyadı"].ToString();
                frm.tc = dr["OgrenciTC"].ToString();
                frm.cinsiyet = dr["OgrenciCinsiyet"].ToString();
                frm.dogTarihi = dr["OgrenciDogumT"].ToString();
                frm.foto = newPath = "D:\\Mervan\\OkulOtomasyon" + "\\Resimler\\" + dr["OgrenciFoto"].ToString();
            }
            frm.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            FrmKimlik frm = new FrmKimlik();

            if (dr != null)
            {
                frm.ad = dr["OgrenciAdı"].ToString();
                frm.soyad = dr["OgrenciSoyadı"].ToString();
                frm.tc = dr["OgrenciTC"].ToString();
                frm.cinsiyet = dr["OgrenciCinsiyet"].ToString();
                frm.dogTarihi = dr["OgrenciDogumT"].ToString();
                frm.foto = newPath = "D:\\Mervan\\OkulOtomasyon" + "\\Resimler\\" + dr["OgrenciFoto"].ToString();
            }
            frm.Show();
        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            FrmKimlik frm = new FrmKimlik();

            if (dr != null)
            {
                frm.ad = dr["OgrenciAdı"].ToString();
                frm.soyad = dr["OgrenciSoyadı"].ToString();
                frm.tc = dr["OgrenciTC"].ToString();
                frm.cinsiyet = dr["OgrenciCinsiyet"].ToString();
                frm.dogTarihi = dr["OgrenciDogumT"].ToString();
                frm.foto = newPath = "D:\\Mervan\\OkulOtomasyon" + "\\Resimler\\" + dr["OgrenciFoto"].ToString();
            }
            frm.Show();
        }

        private void gridView4_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            FrmKimlik frm = new FrmKimlik();

            if (dr != null)
            {
                frm.ad = dr["OgrenciAdı"].ToString();
                frm.soyad = dr["OgrenciSoyadı"].ToString();
                frm.tc = dr["OgrenciTC"].ToString();
                frm.cinsiyet = dr["OgrenciCinsiyet"].ToString();
                frm.dogTarihi = dr["OgrenciDogumT"].ToString();
                frm.foto = newPath = "D:\\Mervan\\OkulOtomasyon" + "\\Resimler\\" + dr["OgrenciFoto"].ToString();
            }
            frm.Show();
        }
    }
}
