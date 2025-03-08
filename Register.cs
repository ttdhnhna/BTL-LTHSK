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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dungchung c = new Dungchung();
            SqlConnection conn = c.ketnoi();

            if (textBox1.Text == "")
            {
                MessageBox.Show("Thieu thong tin ten dang nhap! Can bo sung.");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Thieu mat khau! Can bo sung.");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Khong duoc bo trong nhap lai mat khau! Can bo sung.");
            }
            else if (textBox3.Text=="")
            {
                MessageBox.Show("Thieu thong tin Email! Can bo sung.");
            }
            else if (!textBox2.Text.Equals(textBox4.Text))
            {
                MessageBox.Show("2 mat khau khac nhau, can nhap lai!.");
            }
            try
            {
                string query = "INSERT INTO tbluser(name, email, password) VALUES(@UN, @UE, @UP)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UN", textBox1.Text);
                    cmd.Parameters.AddWithValue("@UE", textBox3.Text);
                    cmd.Parameters.AddWithValue("@UP", textBox2.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đăng ký tài khoản thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại, vui lòng thử lại!");
                    }
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

        private void label2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
