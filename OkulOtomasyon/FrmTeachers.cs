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

        private void FrmTeachers_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'okulDataSet3.Teachers' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.teachersTableAdapter.Fill(this.okulDataSet3.Teachers);

            Listele();
            ilekle();
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
            SqlCommand komut = new SqlCommand("Select * From ilceler Where sehir=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Cmbxil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbxilce.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();

        }
    }
}
