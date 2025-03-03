using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_LTHSK
{
    internal class Dungchung
    {
        public string str = @"Data Source=desktop-hnrp7g1\mayao;Initial Catalog=EIM;Integrated Security=True;";
        public SqlConnection cnn = new SqlConnection();

        public SqlConnection ketnoi()
        {
            return new SqlConnection(str);
        }
    }

}
