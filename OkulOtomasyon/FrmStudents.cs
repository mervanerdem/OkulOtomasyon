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
    }
}
