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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        public static string User;
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!");
                return;
            }

            Dungchung c = new Dungchung();
            c.ketnoi();
            if (c.ketnoi()==null)
            {
                return;
            }
            string query = "SELECT COUNT(*) FROM tbluser WHERE name = @username AND password = @password";

            using (SqlCommand cmd = new SqlCommand(query, c.cnn))
            {
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text); 

                int count = (int)cmd.ExecuteScalar();

                if (count == 1)
                {
                    User = textBox1.Text;
                    Dashboard obj = new Dashboard();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }

            c.cnn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
