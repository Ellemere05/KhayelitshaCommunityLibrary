namespace KhayelitshaCommunityLibrary
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DatabaseHelper.TestConnection();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Members membersForm = new Members())
            {
                membersForm.ShowDialog();
            }
            this.Show();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Books booksForm = new Books())
            {
                booksForm.ShowDialog();
            }
            this.Show();
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Loans loansForm = new Loans())
            {
                loansForm.ShowDialog();
            }
            this.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Reports reportsForm = new Reports())
            {
                reportsForm.ShowDialog();
            }
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the library system?", "Exit Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
