using System;
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
            panel5.BackColor = Color.FromArgb(255, 128, 0);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(label18);
            panel5.Location = new Point(778, 32);
            panel5.Name = "panel5";
            panel5.Size = new Size(171, 78);
            panel5.TabIndex = 15;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(61, 42);
            label17.Name = "label17";
            label17.Size = new Size(51, 15);
            label17.TabIndex = 8;
            label17.Text = "Amount";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(56, 20);
            label18.Name = "label18";
            label18.Size = new Size(61, 15);
            label18.TabIndex = 7;
            label18.Text = "TONG CHI";
            // 
            // Incomes
            // 
            ClientSize = new Size(990, 634);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Name = "Incomes";
            Text = "Them Khoan Thu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)pictureBox4).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }
    }
}
