﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            label17 = new Label();
            label18 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            label9 = new Label();
            panel1.SuspendLayout();
            ((ISupportInitialize)pictureBox4).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 634);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 324);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 6;
            label3.Text = "Expense";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 227);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 5;
            label2.Text = "Income";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 144);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 4;
            label1.Text = "Dashboard";
            label1.Click += label1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Image = Properties.Resources.business_and_finance;
            pictureBox4.Location = new Point(12, 307);
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
            pictureBox3.Location = new Point(12, 213);
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
            // textBox1
            // 
            textBox1.Location = new Point(251, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 23);
            textBox1.TabIndex = 16;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(251, 300);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 23);
            comboBox1.TabIndex = 19;
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
            // textBox2
            // 
            textBox2.Location = new Point(251, 376);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 94);
            textBox2.TabIndex = 21;
            textBox2.Text = "\r\n";
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
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(347, 508);
            button1.Name = "button1";
            button1.Size = new Size(146, 50);
            button1.TabIndex = 25;
            button1.Text = "LUU";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(583, 508);
            button2.Name = "button2";
            button2.Size = new Size(146, 50);
            button2.TabIndex = 26;
            button2.Text = "HUY";
            button2.UseVisualStyleBackColor = false;
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
            // Incomes
            // 
            ClientSize = new Size(990, 634);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Name = "Incomes";
            Text = "Khoan Thu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)pictureBox4).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }
    }
}
