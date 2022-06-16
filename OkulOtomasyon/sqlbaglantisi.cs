using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OkulOtomasyon
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = Okul; Integrated Security = True");
            baglan.Open();
            return baglan;
        }
    }
}
