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

namespace OkulOtomasyon
{
    public partial class FrmTeachers : Form
    {
        public FrmTeachers()
        {
            InitializeComponent();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl11_Click(object sender, EventArgs e)
        {

        }

        readonly sqlbaglantisi bgl = new sqlbaglantisi(); // sql bağlantısı için bgl değişkeni atandı.
    
       void Listele()   //Verilerin grid control ünitesine lisitelenmesi
       {
           DataTable dt = new DataTable(); // data table oluşturuldu
           SqlDataAdapter da = new SqlDataAdapter("Select * From Teachers",bgl.baglanti()); // Query sorgusu yapıldı.
           da.Fill(dt); //table çekilen veriler ile dolduruluyor.
           gridControl1.DataSource = dt;    // gridControl aracına yasıtıldı veriler.
       }
        
        void ilekle()   //Kayıt yaparken Combobox'a veri çağırma
        {
            SqlCommand komut = new SqlCommand("Select * From iller;", bgl.baglanti()); //verilerin sql bağlantısından çekilmesi
            SqlDataReader dr = komut.ExecuteReader(); // verilerin okunması
            while (dr.Read())    // combobox sekmesi açıksa
            {
                
                Cmbxil.Properties.Items.Add(dr[1]); //databasedeki 2.sütundaki verileri(id,il) gösterme
            }
            bgl.baglanti().Close();

        }

        void bransGetir()
        {
            SqlCommand komut = new SqlCommand("Select * From Brans;", bgl.baglanti()); //verilerin sql bağlantısından çekilmesi
            SqlDataReader dr = komut.ExecuteReader(); // verilerin okunması
            while (dr.Read())    // combobox sekmesi açıksa
            {

                CmbxBrans.Properties.Items.Add(dr[1]); //databasedeki 2.sütundaki verileri(id,brans) gösterme
            }
            bgl.baglanti().Close();

        }

        private void FrmTeachers_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'okulDataSet3.Teachers' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.teachersTableAdapter.Fill(this.okulDataSet3.Teachers);

            Listele();  //Teachers tablosunu listele
            ilekle();   //illeri combobox'a ekle
            bransGetir();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void Cmbxilce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cmbxil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmbxilce.Properties.Items.Clear();  //il değiştirilince ilçeyi temizle
            Cmbxilce.Text = ""; //ilçe text'ini null yap
            SqlCommand komut = new SqlCommand("Select * From ilceler Where sehir=@p1", bgl.baglanti()); //sehirler sutununa göre yani illere göre ilçe tablosundan çek
            komut.Parameters.AddWithValue("@p1", Cmbxil.SelectedIndex + 1); //parametre 1 e seçilen ili ekle
            SqlDataReader dr = komut.ExecuteReader();   //Tablodan okumayı yap
            while (dr.Read())   //okuma olduğu sürece while dönsün
            {
                Cmbxilce.Properties.Items.Add(dr[1]);   //ilçe tablosundaki 2.sütunu getir(2.sutun ilçe isimleri)
            }
            bgl.baglanti().Close(); //database bağlantısını kapat

        }

        private void BtnKaydet_Click(object sender, EventArgs e)    //kaydet butonu işlevi
        {
            SqlCommand komut = new SqlCommand("Insert into Teachers " +
                "(OgretmenAdı,OgretmenSoyadı,OgretmenTC,OgretmenTelNo,OgretmenMail,OgretmenIL,OgretmenIlce,OgretmenAdres,OgretmenBrans) " +
                "Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",bgl.baglanti()); //sqle veri kaydet
            //veri parametrelerini ekle
            komut.Parameters.AddWithValue("@p1",TxtAd.Text); 
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTc.Text);
            komut.Parameters.AddWithValue("@p4", MskTel.Text);
            komut.Parameters.AddWithValue("@p5", TxtMail.Text);
            komut.Parameters.AddWithValue("@p6", Cmbxil.Text);
            komut.Parameters.AddWithValue("@p7", Cmbxilce.Text);
            komut.Parameters.AddWithValue("@p8", RchAdres.Text);
            komut.Parameters.AddWithValue("@p9", CmbxBrans.Text);

            komut.ExecuteNonQuery();    //dataset güncelleme
            bgl.baglanti().Close();

            MessageBox.Show("Personel Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); //işlem sonucunda kullanıcı bilgi ekranı
            Listele();  //güncellenen tabloyu göster

        }
    }
}
