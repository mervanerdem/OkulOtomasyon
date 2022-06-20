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
    public partial class FrmMainModule : Form
    {
        public FrmMainModule()
        {
            InitializeComponent();
        }


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        FrmStudent student;
        private void BtnOgrenci_ItemClickbar(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (student == null || student.IsDisposed)
            {
                student = new FrmStudent();
                student.MdiParent = this;
                student.Show();
            }
        }

        FrmVeliler Veli;

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Veli == null || Veli.IsDisposed)
            {
                Veli = new FrmVeliler();
                Veli.MdiParent = this;
                Veli.Show();
            }

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        FrmTeachers frm1;

        private void BtnOgretmen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frm1 == null || frm1.IsDisposed)
            {
                frm1 = new FrmTeachers();
                frm1.MdiParent = this;
                frm1.Show();
            }
            
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        FrmAyarlar ayarlar;
        private void BtnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ayarlar == null || ayarlar.IsDisposed)
            {
                ayarlar = new FrmAyarlar();
                ayarlar.MdiParent = this;
                ayarlar.Show();
            }
        }
    }
}
