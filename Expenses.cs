﻿using System;
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
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dungchung c = new Dungchung();
            SqlConnection conn = c.ketnoi();

            if (conn == null) return;

            if (string.IsNullOrWhiteSpace(Amount.Text))
            {
                MessageBox.Show("Chưa nhập số tiền! Vui lòng bổ sung.");
                return;
            }
            if (string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                MessageBox.Show("Chưa nhập ngày! Vui lòng bổ sung.");
                return;
            }
            if (category.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn danh mục! Vui lòng bổ sung.");
                return;
            }
            if (string.IsNullOrWhiteSpace(description.Text))
            {
                MessageBox.Show("Chưa nhập mô tả! Vui lòng bổ sung.");
                return;
            }
            try
            {
                string query = "INSERT INTO tblexpense(user_id, amount, date, category, description) VALUES(@EU, @EA, @ED, @EC, @EN)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
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

                    if (!decimal.TryParse(Amount.Text, out decimal amount))
                    {
                        MessageBox.Show("Lỗi: Số tiền không hợp lệ.");
                        return;
                    }
                    if (category.SelectedItem == null)
                    {
                        MessageBox.Show("Chưa chọn danh mục! Vui lòng chọn danh mục.");
                        return;
                    }
                    cmd.Parameters.AddWithValue("@EU", userId);
                    cmd.Parameters.AddWithValue("@EA", decimal.Parse(Amount.Text));
                    cmd.Parameters.AddWithValue("@ED", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@EC", category.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EN", description.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm mới khoản chi thành công!");
                        Amount.Clear();
                        dateTimePicker1.Value = DateTime.Now; // Reset ngày về hiện tại
                        category.SelectedIndex = -1; // Đặt lại lựa chọn danh mục
                        description.Clear();
                        Dashboard obj = new Dashboard();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại, vui lòng thử lại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                c.dongKetNoi(conn); // Đảm bảo đóng kết nối
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Amount.Clear();
            dateTimePicker1.Value = DateTime.Now; // Reset ngày về hiện tại
            category.SelectedIndex = -1; // Đặt lại lựa chọn danh mục
            description.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Incomes obj = new Incomes();
            obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }
    }
}
