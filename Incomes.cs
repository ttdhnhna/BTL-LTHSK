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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace BTL_LTHSK
{
    public partial class Incomes : Form
    {
        public Incomes()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Incomes));
            panel5 = new Panel();
            label17 = new Label();
            label18 = new Label();
            Amount = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            category = new ComboBox();
            label7 = new Label();
            description = new TextBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            savebutton = new Button();
            cancerbutton = new Button();
            label9 = new Label();
            panel1 = new Panel();
            label23 = new Label();
            pictureBox9 = new PictureBox();
            label19 = new Label();
            label20 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((ISupportInitialize)pictureBox9).BeginInit();
            ((ISupportInitialize)pictureBox7).BeginInit();
            ((ISupportInitialize)pictureBox8).BeginInit();
            ((ISupportInitialize)pictureBox4).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 255, 192);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(label18);
            panel5.Location = new Point(583, 166);
            panel5.Name = "panel5";
            panel5.Size = new Size(254, 145);
            panel5.TabIndex = 15;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(102, 75);
            label17.Name = "label17";
            label17.Size = new Size(51, 15);
            label17.TabIndex = 8;
            label17.Text = "Amount";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(97, 53);
            label18.Name = "label18";
            label18.Size = new Size(64, 15);
            label18.TabIndex = 7;
            label18.Text = "TONG THU";
            // 
            // Amount
            // 
            Amount.Location = new Point(251, 166);
            Amount.Name = "Amount";
            Amount.Size = new Size(198, 23);
            Amount.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(251, 24);
            label4.Name = "label4";
            label4.Size = new Size(287, 20);
            label4.TabIndex = 17;
            label4.Text = "He thong quan ly tai chinh ca nhan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(251, 139);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 7;
            label5.Text = "So tien";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(251, 277);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 18;
            label6.Text = "The loai";
            // 
            // category
            // 
            category.FormattingEnabled = true;
            category.Items.AddRange(new object[] { "Luong", "Thuong", "Qua tang", "Khac" });
            category.Location = new Point(251, 300);
            category.Name = "category";
            category.Size = new Size(198, 23);
            category.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(251, 349);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 20;
            label7.Text = "Ghi chu";
            // 
            // description
            // 
            description.Location = new Point(251, 376);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(198, 94);
            description.TabIndex = 21;
            description.Text = "\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(251, 202);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 22;
            label8.Text = "Ngay";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(251, 229);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(198, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // savebutton
            // 
            savebutton.BackColor = Color.Lime;
            savebutton.Location = new Point(347, 508);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(146, 50);
            savebutton.TabIndex = 25;
            savebutton.Text = "LUU";
            savebutton.UseVisualStyleBackColor = false;
            savebutton.Click += savebutton_Click;
            // 
            // cancerbutton
            // 
            cancerbutton.BackColor = Color.Red;
            cancerbutton.Location = new Point(583, 508);
            cancerbutton.Name = "cancerbutton";
            cancerbutton.Size = new Size(146, 50);
            cancerbutton.TabIndex = 26;
            cancerbutton.Text = "HUY";
            cancerbutton.UseVisualStyleBackColor = false;
            cancerbutton.Click += cancerbutton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(476, 72);
            label9.Name = "label9";
            label9.Size = new Size(140, 20);
            label9.TabIndex = 27;
            label9.Text = "Them Khoan thu";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(pictureBox9);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 635);
            panel1.TabIndex = 28;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(96, 588);
            label23.Name = "label23";
            label23.Size = new Size(61, 15);
            label23.TabIndex = 12;
            label23.Text = "Đăng xuất";
            label23.Click += label23_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.White;
            pictureBox9.BorderStyle = BorderStyle.FixedSingle;
            pictureBox9.Image = Properties.Resources.business_and_finance;
            pictureBox9.Location = new Point(12, 571);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(76, 50);
            pictureBox9.TabIndex = 11;
            pictureBox9.TabStop = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(96, 317);
            label19.Name = "label19";
            label19.Size = new Size(86, 15);
            label19.TabIndex = 10;
            label19.Text = "Xem khoan chi";
            label19.Click += label19_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(94, 228);
            label20.Name = "label20";
            label20.Size = new Size(88, 15);
            label20.TabIndex = 9;
            label20.Text = "Xem khoan thu";
            label20.Click += label20_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.White;
            pictureBox7.BorderStyle = BorderStyle.FixedSingle;
            pictureBox7.Image = Properties.Resources.business_and_finance;
            pictureBox7.Location = new Point(12, 300);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(76, 50);
            pictureBox7.TabIndex = 8;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.White;
            pictureBox8.BorderStyle = BorderStyle.FixedSingle;
            pictureBox8.Image = Properties.Resources.wallet;
            pictureBox8.Location = new Point(12, 214);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(76, 50);
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 500);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 6;
            label3.Text = "Them khoan chi";
            label3.Click += label3_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 403);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 5;
            label2.Text = "Them khoan thu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 144);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "Trang chu";
            label1.Click += label1_Click_1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Image = Properties.Resources.business_and_finance;
            pictureBox4.Location = new Point(12, 483);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(76, 50);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = Properties.Resources.wallet;
            pictureBox3.Location = new Point(12, 389);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(76, 50);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 127);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 50);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.manager;
            pictureBox1.Location = new Point(43, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 71);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Incomes
            // 
            ClientSize = new Size(990, 634);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(cancerbutton);
            Controls.Add(savebutton);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(description);
            Controls.Add(category);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Amount);
            Controls.Add(panel5);
            Name = "Incomes";
            Text = "Khoan Thu";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)pictureBox9).EndInit();
            ((ISupportInitialize)pictureBox7).EndInit();
            ((ISupportInitialize)pictureBox8).EndInit();
            ((ISupportInitialize)pictureBox4).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void savebutton_Click(object sender, EventArgs e)
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

                string query = "INSERT INTO tblincome(user_id, amount, date, category, description) VALUES(@IU, @IA, @ID, @IC, @IN)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
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
                    cmd.Parameters.AddWithValue("@IU", userId);
                    cmd.Parameters.AddWithValue("@IA", decimal.Parse(Amount.Text));
                    cmd.Parameters.AddWithValue("@ID", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@IC", category.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@IN", description.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm mới khoản thu thành công!");
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

        private void cancerbutton_Click(object sender, EventArgs e)
        {
            Amount.Clear();
            dateTimePicker1.Value = DateTime.Now; // Reset ngày về hiện tại
            category.SelectedIndex = -1; // Đặt lại lựa chọn danh mục
            description.Clear();
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

        private void label1_Click_1(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
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
    }
}
