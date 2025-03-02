namespace BTL_LTHSK
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label9 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(91, 32);
            label9.Name = "label9";
            label9.Size = new Size(160, 31);
            label9.TabIndex = 30;
            label9.Text = "Dang Nhap";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 100);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 32;
            label5.Text = "Ten dang nhap";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 23);
            textBox1.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 170);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 34;
            label1.Text = "Mat khau";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(70, 197);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 23);
            textBox2.TabIndex = 35;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(70, 247);
            button1.Name = "button1";
            button1.Size = new Size(198, 41);
            button1.TabIndex = 39;
            button1.Text = "DANG NHAP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 306);
            label2.Name = "label2";
            label2.Size = new Size(186, 15);
            label2.TabIndex = 40;
            label2.Text = "Chưa có tài khoản? Đăng ký ở đây";
            label2.Click += label2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(347, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Name = "Login";
            Text = "Dang Nhap";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label5;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Button button1;
        private Label label2;
    }
}