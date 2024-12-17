using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    class sqlbaglantisi //sınıfımın adı
    {

        public SqlConnection baglanti() //baglanti methodumun adı
        {
            SqlConnection baglan = new SqlConnection("server=LAPTOP-O1DRK0LF;database=HastaneProje;integrated security=true;trustServerCertificate=true"); // baglan, sql connectiondan sınıfından türettiğim benim adresimi tutan nesnedir.
            baglan.Open(); // Open methoddur.
            return baglan; //return de geriye dönen değerimi tutar.
        }
    }
}
