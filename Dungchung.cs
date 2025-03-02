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
        public string str = @"Data Source=desktop-hnrp7g1\mayao, Database=EIM; Trusted_Connection=True;";
        public SqlConnection cnn = new SqlConnection();
        public bool ketnoi()
        {
            try
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
                cnn.ConnectionString = str;
                cnn.Open();
            }
            catch
            {
                MessageBox.Show("Loi ket noi CSDL", "Thong bao");
                return false;
            }
            return true;
        }
    }
}
