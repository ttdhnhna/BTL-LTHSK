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
        private readonly string str = @"Data Source=desktop-hnrp7g1\mayao;Initial Catalog=EIM;Integrated Security=True;";

        public SqlConnection ketnoi()
        {
            SqlConnection cnn = new SqlConnection(str);
            try
            {
                cnn.Open(); // Mở kết nối trước khi trả về
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
                return null; // Trả về null nếu lỗi
            }
            return cnn;
        }
        public void dongKetNoi(SqlConnection cnn)
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
    }
}
