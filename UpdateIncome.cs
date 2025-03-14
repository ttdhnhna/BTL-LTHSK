using Microsoft.VisualBasic;
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
    public partial class UpdateIncome : Form
    {
        private string incomeId;

        public UpdateIncome(string id, string amount, string date, string category, string description)
        {
            InitializeComponent();

            incomeId = id;
            Amount.Text = amount;
            dateTimePicker1.Value = Convert.ToDateTime(date);
            Category.SelectedItem = category;
            Description.Text = description;
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            Dungchung c = new Dungchung();
            using (SqlConnection conn = c.ketnoi())
            {
                string query = "UPDATE tblincome SET amount = @Amount, date = @Date, category = @Category, description = @Description WHERE id = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Amount", Amount.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Category", Category.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Description", Description.Text);
                    cmd.Parameters.AddWithValue("@ID", incomeId);

                    cmd.ExecuteScalar();
                    c.dongKetNoi(conn);
                }
            }
            MessageBox.Show("Cập nhật thành công!");
            IncomeDetail obj = new IncomeDetail();
            obj.Show();
            this.Close();
        }

        private void cancerbutton_Click(object sender, EventArgs e)
        {
            Amount.Clear();
            dateTimePicker1.Value = DateTime.Now;
            Category.SelectedIndex = -1;
            Description.Clear();

            IncomeDetail obj = new IncomeDetail();
            obj.Show();
            this.Hide();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void viewincomes_Click(object sender, EventArgs e)
        {
            IncomeDetail obj = new IncomeDetail();
            obj.Show();
            this.Hide();
        }

        private void viewexpenses_Click(object sender, EventArgs e)
        {
            ExpenseDetail obj = new ExpenseDetail();
            obj.Show();
            this.Hide();
        }

        private void addincome_Click(object sender, EventArgs e)
        {
            Incomes obj = new Incomes();
            obj.Show();
            this.Hide();
        }

        private void addexpense_Click(object sender, EventArgs e)
        {
            Expenses obj = new Expenses();
            obj.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
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
    }
}
