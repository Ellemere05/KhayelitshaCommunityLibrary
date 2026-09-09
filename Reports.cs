using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhayelitshaCommunityLibrary
{
    public partial class Reports : Form
    {

        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResults.MultiSelect = false;
            dgvResults.ReadOnly = true;
            dgvResults.AutoGenerateColumns = true;
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            rbOverdue.Checked = true;
        }

        // REPORT GENERATION

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string query = string.Empty;

            if (rbOverdue.Checked)
            {
                query = @"SELECT L.LoanID AS [Loan #], M.FullName AS [Borrower Name], M.Phone AS [Contact Number],
                BT.Title AS [Book Title], BC.CopyID AS [Copy #], L.LoanDate AS [Loan Date], L.DueDate AS [Due Date],
                DATEDIFF(day, L.DueDate, CAST(GETDATE() AS DATE)) AS [Days Overdue]
                FROM Loan L JOIN Member M ON L.MemberID = M.MemberID JOIN BookCopy BC ON L.CopyID = BC.CopyID
                JOIN BookTitle BT ON BC.TitleID = BT.TitleID WHERE L.ReturnDate IS NULL AND L.DueDate < CAST(GETDATE() AS DATE)
                ORDER BY [Days Overdue] DESC";
            }
            else if (rbPopular.Checked)
            {
                query = @"SELECT TOP 5 BT.TitleID AS [Title #], BT.Title AS [Book Title], BT.Author AS [Author],
                BT.Genre AS [Genre], COUNT(L.LoanID) AS [Times Borrowed] FROM BookTitle BT
                JOIN BookCopy BC ON BT.TitleID = BC.TitleID LEFT JOIN Loan L ON BC.CopyID = L.CopyID
                GROUP BY BT.TitleID, BT.Title, BT.Author, BT.Genre ORDER BY [Times Borrowed] DESC,
                BT.Title ASC";
            }
            else if (rbSummary.Checked)
            {
                query = @"SELECT M.MemberID AS [Member #], M.FullName AS [Member Name], M.Phone AS [Phone],
                M.JoinDate AS [Member Since], COUNT(L.LoanID) AS [Total Borrowed],
                SUM(CASE WHEN L.ReturnDate IS NULL THEN 1 ELSE 0 END) AS [Currently Active Loans]
                FROM Member M LEFT JOIN Loan L ON M.MemberID = L.MemberID GROUP BY M.MemberID, M.FullName, M.Phone, 
                M.JoinDate ORDER BY [Total Borrowed] DESC;";
            }
            else if (rbInventory.Checked)
            {
                query = @"SELECT BC.Status AS [Copy Status], COUNT(BC.CopyID) AS [Total Copies],
                COUNT(DISTINCT BC.TitleID) AS [Distinct Titles] FROM BookCopy BC
                GROUP BY BC.Status ORDER BY [Total Copies] DESC;";
            }

            if (!string.IsNullOrEmpty(query))
            {
                DataTable dtResults = DatabaseHelper.ExecuteQuery(query);
                dgvResults.DataSource = dtResults;

                if (dtResults.Rows.Count == 0)
                {
                    MessageBox.Show("No records found for the selected report.", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
