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

    //   sqlbaglantisi bgl = new sqlbaglantisi();
    //
    //   void listele()
    //   {
    //       DataTable dt = new DataTable();
    //       SqlDataAdapter da = new SqlDataAdapter("Select * From Teachers",bgl.baglanti());
    //       da.Fill(dt);
    //       gridControl1.DataSource = dt;
    //   }

        private void FrmTeachers_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'okulDataSet3.Teachers' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.teachersTableAdapter.Fill(this.okulDataSet3.Teachers);

            // listele();
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
    }
}
