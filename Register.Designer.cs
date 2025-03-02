using System.Data.SqlClient;

namespace BTL_LTHSK
{
    partial class Register
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
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 394);
            label2.Name = "label2";
            label2.Size = new Size(187, 15);
            label2.TabIndex = 47;
            label2.Text = "Đã có tài khoản? Đăng nhập ở đây";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(69, 335);
            button1.Name = "button1";
            button1.Size = new Size(198, 41);
            button1.TabIndex = 46;
            button1.Text = "DANG KY";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 204);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 44;
            label1.Text = "Mat khau";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(69, 231);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 23);
            textBox2.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 74);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 42;
            label5.Text = "Ten dang nhap";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 23);
            textBox1.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(108, 24);
            label9.Name = "label9";
            label9.Size = new Size(125, 31);
            label9.TabIndex = 41;
            label9.Text = "Dang Ky";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 138);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 48;
            label3.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(69, 168);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 23);
            textBox3.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 268);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 50;
            label4.Text = "Nhap lai mat khau";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(69, 295);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(198, 23);
            textBox4.TabIndex = 51;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(347, 450);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Name = "Register";
            Text = "Dang Ky";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button1;
        private Label label1;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox1;
        private Label label9;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;

        
    }
}