using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTHSK
{
    public partial class IncomeDetail : Form
    {
        public IncomeDetail()
        {
            InitializeComponent();
            DisplayIncomes();
        }

        private void IncomeDetail_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }
        private void label2_Click_1(object sender, EventArgs e)
        {
            Incomes obj = new Incomes();
            obj.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Expenses obj = new Expenses();
            obj.Show();
            this.Hide();
        }
        private void label19_Click(object sender, EventArgs e)
        {
            ExpenseDetail obj = new ExpenseDetail();
            obj.Show();
            this.Hide();
        }
        private void DisplayIncomes()
        {
            Dungchung c = new Dungchung();
            SqlConnection conn = c.ketnoi();

            try
            {
                int userId = -1;
                string getUserIdQuery = "SELECT iduser FROM tbluser WHERE name = @UserName";

                using (SqlCommand getUserIdCmd = new SqlCommand(getUserIdQuery, conn))
                {
                    getUserIdCmd.Parameters.AddWithValue("@UserName", Login.User);
                    object result = getUserIdCmd.ExecuteScalar();

                    if (result != null)
                    {
                        userId = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: Không tìm thấy ID người dùng.");
                        return;
                    }
                }

                string query = "SELECT amount, date, category, description FROM tblincome WHERE user_id = @UserId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                c.dongKetNoi(conn);
            }
        }
    }
}
