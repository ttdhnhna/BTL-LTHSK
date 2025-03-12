namespace BTL_LTHSK
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Incomes obj = new Incomes();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
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
    }
}
