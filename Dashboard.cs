using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;

namespace BTL_LTHSK
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            getBalance();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Incomes obj = new Incomes();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Expenses obj = new Expenses();
            obj.Show();
            this.Hide();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            IncomeDetail obj = new IncomeDetail();
            obj.Show();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            ExpenseDetail obj = new ExpenseDetail();
            obj.Show();
            this.Hide();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login.User = "";
                Login obj = new Login();
                obj.Show();
                this.Close();
            }
        }

        private void getBalance()
        {
            Dungchung c = new Dungchung();
            SqlConnection conn = c.ketnoi();

            int userId = -1;
            string getUserIdQuery = "SELECT id FROM tbluser WHERE name = @UserName";

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

            string getBalanceQuery = "SELECT total_balance FROM tblbalance WHERE user_id = @IU";

            using (SqlCommand cmd = new SqlCommand(getBalanceQuery, conn))
            {
                cmd.Parameters.AddWithValue("@IU", userId);
                object balanceResult = cmd.ExecuteScalar();
                if (balanceResult != null)
                {
                    total_balance.Text = balanceResult.ToString() + " VNĐ";
                }
                else
                {
                    total_balance.Text = "0 VNĐ";
                }
            }
        }
    }
}
