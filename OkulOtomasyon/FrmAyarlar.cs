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

            //Ogrenciler Entity Framework ile yapılacak.


        }


        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
