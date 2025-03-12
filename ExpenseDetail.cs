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
    public partial class ExpenseDetail : Form
    {
        public ExpenseDetail()
        {
            InitializeComponent();
            DisplayExpenses();
            AddFunctionColumn();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            IncomeDetail obj = new IncomeDetail();
            obj.Show();
            this.Hide();
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

        private void AddFunctionColumn()
        {
            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            edit.Name = "Edit";
            edit.HeaderText = "Chỉnh sửa";
            edit.Text = "Sửa";
            edit.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(edit);

            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            delete.Name = "Delete";
            delete.HeaderText = "Xóa";
            delete.Text = "Xóa";
            delete.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(delete);
        }

        private void DisplayExpenses()
        {
            Dungchung c = new Dungchung();
            SqlConnection conn = c.ketnoi();

            try
            {
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

                string query = "SELECT amount, date, category, description FROM tblexpense WHERE user_id = @UserId";

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
                {

                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DeleteExpense(id);
                }
            }
        }

        private void DeleteExpense(string id)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khoản thu này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Dungchung c = new Dungchung();
                using (SqlConnection conn = c.ketnoi())
                {
                    string query = "DELETE FROM tblincome WHERE id = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteScalar();
                        c.dongKetNoi(conn);
                    }
                }
                MessageBox.Show("Xóa thành công!");
                DisplayExpenses();
            }
        }
    }
}
