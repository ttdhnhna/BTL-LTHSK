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
            else
            {
                try
                {
                    c.ketnoi();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tbl VALUES(@UN,@UD,@UP)", c.cnn);//Can bo xung doan nay
                    cmd.Parameters.AddWithValue("@UN", textBox1.Text);//Ten dang nhap
                    cmd.Parameters.AddWithValue("@UD", textBox3.Text);//Email
                    cmd.Parameters.AddWithValue("@Up", textBox2.Text);//Mat khau
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dang ky tai khoan thanh cong!");
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
