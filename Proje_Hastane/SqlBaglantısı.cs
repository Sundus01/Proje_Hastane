
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    class SqlBaglantısı
    {
        public SqlConnection Baglanti()
        {
            SqlConnection baglan=new SqlConnection(Data Source = LAPTOP - AK5T9PFP\\SQLEXPRESS; Initial Catalog = HastaneProje; Integrated Security = True);
            baglan.Open();
            return baglan;
        }
    }
}
