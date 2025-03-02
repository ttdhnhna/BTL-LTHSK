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

        private void button1_Click(object sender, EventArgs e)
        {
            Dungchung c = new Dungchung();
            c.ketnoi();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM tbluser WHERE name = '"+textBox1.Text+"' AND password = '"+textBox2.Text+"'", c.cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Dashboard obj = new Dashboard();
                obj.Show();
                this.Hide();
                c.cnn.Close();
            }
            else
            {
                MessageBox.Show("Sai ten dang nhap hoac mat khau!");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
