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
    public partial class FrmVeliler : Form
    {
        public FrmVeliler()
        {
            InitializeComponent();
        }

        OkulEntities db = new OkulEntities();

        void listele()
        {
            //ilk yöntem student bağlantısını gizlemek için 
            //gridControl1.DataSource = db.Veliler.ToList();  //entity framework listeleme
            //gridView1.Columns[6].Visible = false; 

            //ikinci yöntem (Query yazarak)
            var query = from item in db.Veliler
                        select new { item.VeliID, item.VeliAnne, item.VeliBaba, item.VeliTel1, item.VeliTel2, item.VeliMail };
            gridControl1.DataSource = query.ToList();
        }

        private void FrmVeliler_Load(object sender, EventArgs e)
        {
            
            listele();
            temizle();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Veliler veli = new Veliler();
            veli.VeliAnne = TxtAnne.Text;
            veli.VeliBaba = TxtBaba.Text;
            veli.VeliTel1 = MskTel1.Text;
            veli.VeliTel2 = MskTel2.Text;
            veli.VeliMail = TxtMail.Text;

            db.Veliler.Add(veli);
            db.SaveChanges();
            listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"VeliID").ToString();
            TxtAnne.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VeliAnne").ToString();
            TxtBaba.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VeliBaba").ToString();
            TxtMail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VeliMail").ToString();
            MskTel1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VeliTel1").ToString();
            MskTel2.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VeliTel2").ToString();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VeliID").ToString());
            var item = db.Veliler.Find(id);
            item.VeliAnne = TxtAnne.Text;
            item.VeliBaba = TxtBaba.Text;
            item.VeliTel1 = MskTel1.Text;
            item.VeliTel2 = MskTel2.Text;
            item.VeliMail = TxtMail.Text;

            db.SaveChanges();
            MessageBox.Show("Veli Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VeliID").ToString());
            var item = db.Veliler.Find(id);
            db.Veliler.Remove(item);

            db.SaveChanges();
            MessageBox.Show("Veli Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }

        void temizle()
        {
            TxtID.Text = "";
            TxtAnne.Text = "";
            TxtBaba.Text = "";
            TxtMail.Text = "";
            MskTel1.Text = "";
            MskTel2.Text = "";

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
