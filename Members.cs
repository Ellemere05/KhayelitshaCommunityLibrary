using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhayelitshaCommunityLibrary
{
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
        }

        private void Members_Load(object sender, EventArgs e)
        {
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.MultiSelect = false;
            dgvMembers.ReadOnly = true;

            LoadMembers();
        }

        private void LoadMembers(string searchFilter = "")
        {
            string query = "SELECT MemberID, FullName, Address, Phone, JoinDate FROM Member";
            SqlParameter[] parameters = null;

            if (!string.IsNullOrWhiteSpace(searchFilter))
            {
                query += " WHERE FullName LIKE @search OR Phone LIKE @search OR MemberID LIKE @search";
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@search", "%" + searchFilter.Trim() + "%")
                };
            }

            query += " ORDER BY MemberID DESC";

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            dgvMembers.DataSource = dt;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter the address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter the phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^0\d{9}$"))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.", "Validation Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            txtMemberID.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            dtpDateJoined.Value = DateTime.Now;

            txtName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) { return; }

            string query = "INSERT INTO Member (FullName, Address, Phone, JoinDate)" +
                "VALUES (@FullName, @Address, @Phone, @JoinDate)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FullName", txtName.Text.Trim()),
                new SqlParameter("@Address", txtAddress.Text.Trim()),
                new SqlParameter("@Phone", txtPhone.Text.Trim()),
                new SqlParameter("@JoinDate", dtpDateJoined.Value)
            };

            int rows = DatabaseHelper.ExecuteNonQuery(query, parameters);
            if (rows > 0)
            {
                MessageBox.Show("Member added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadMembers();
            }
            else
            {
                MessageBox.Show("Failed to add member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMemberID.Text))
            {
                MessageBox.Show("Please select a member to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) { return; }

            string query = "UPDATE Member SET FullName = @FullName, Address = @Address, Phone = @Phone, JoinDate = @JoinDate " +
                "WHERE MemberID = @MemberID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MemberID", txtMemberID.Text.Trim()),
                new SqlParameter("@FullName", txtName.Text.Trim()),
                new SqlParameter("@Address", txtAddress.Text.Trim()),
                new SqlParameter("@Phone", txtPhone.Text.Trim()),
                new SqlParameter("@JoinDate", dtpDateJoined.Value)
            };

            int rows = DatabaseHelper.ExecuteNonQuery(query, parameters);
            if (rows > 0)
            {
                MessageBox.Show("Member updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadMembers();
            }
            else
            {
                MessageBox.Show("Failed to update member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMemberID.Text))
            {
                MessageBox.Show("Please select a member to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int memberId = Convert.ToInt32(txtMemberID.Text);

            string checkLoanQuery = "SELECT COUNT(*) FROM Loan WHERE MemberID = @MemberID";
            SqlParameter[] checkParamaters = { new SqlParameter("@MemberID", memberId) };
            DataTable dtLoans = DatabaseHelper.ExecuteQuery(checkLoanQuery, checkParamaters);

            if (dtLoans.Rows.Count > 0 && Convert.ToInt32(dtLoans.Rows[0][0]) > 0)
            {
                MessageBox.Show("Cannot delete member. There are active loans associated with this member.", "Delete Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete {txtName.Text.Trim()} (ID: {memberId})?", 
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM Member WHERE MemberID = @MemberID";
                SqlParameter[] deleteParameters = { new SqlParameter("@MemberID", memberId) };

                int rows = DatabaseHelper.ExecuteNonQuery(deleteQuery, deleteParameters);
                if (rows > 0)
                {
                    MessageBox.Show("Member deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                    LoadMembers();
                }
                else
                {
                    MessageBox.Show("Failed to delete member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMembers.Rows[e.RowIndex];
                txtMemberID.Text = row.Cells["MemberID"].Value.ToString();
                txtName.Text = row.Cells["FullName"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();

                if (DateTime.TryParse(row.Cells["JoinDate"].Value.ToString(), out DateTime joinDate))
                {
                    dtpDateJoined.Value = joinDate;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadMembers(txtSearch.Text.Trim());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
