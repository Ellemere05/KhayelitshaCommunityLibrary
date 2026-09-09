using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhayelitshaCommunityLibrary
{
    public partial class Books : Form
    {
        private int selectedTitleId = -1;
        private int selectedCopyId = -1;

        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            ConfigureGrid(dgvTitles);
            ConfigureGrid(dgvCopies);

            if (cmbGenre.Items.Count == 0)
            {
                cmbGenre.Items.AddRange(new object[]
                {
                    "Fiction",
                    "Non-Fiction",
                    "Science Fiction",
                    "Biography",
                    "History",
                    "Children's",
                    "Mystery",
                    "Romance",
                    "Fantasy",
                    "Horror",
                    "Biography",
                    "Classic",
                    "Comedy",
                    "Adventure",
                    "Dystopian",
                    "Tragedy"
                });
            }

            if (cmbStatus.Items.Count == 0)
            {
                cmbStatus.Items.AddRange(new object[]
                {
                    "Available",
                    "On Loan",
                    "Lost",
                    "Damaged"
                });
            }

            numYear.Maximum = DateTime.Now.Year;
            numYear.Value = 2000;

            RefreshAll();
        }

        private void ConfigureGrid(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RefreshAll()
        {
            LoadTitles();
            LoadCopies();
            PopulateTitleDropdown();
        }

        // BOOK TITLE METHODS

        private void LoadTitles(string searchFilter = "")
        {
            string query = "SELECT TitleId, Title, Author, ISBN, Genre, PublicationYear FROM BookTitle";
            SqlParameter[] parameters = null;

            if (!string.IsNullOrWhiteSpace(searchFilter))
            {
                query += " WHERE Title LIKE @Search OR Author LIKE @Search OR ISBN LIKE @Search";
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@Search", "%" + searchFilter.Trim() + "%")
                };
            }

            query += " ORDER BY TitleID DESC";
            dgvTitles.DataSource = DatabaseHelper.ExecuteQuery(query, parameters);
        }

        private bool ValidateTitleInput()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Please enter an author.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAuthor.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("Please enter an ISBN.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtISBN.Focus();
                return false;
            }
            if (cmbGenre.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a genre.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGenre.Focus();
                return false;
            }
            return true;
        }

        private void ClearTitleInputs()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtISBN.Clear();
            cmbGenre.SelectedIndex = -1;
            numYear.Value = 2000;
            selectedTitleId = -1;
            txtTitle.Focus();
        }

        private void btnAddTitle_Click(object sender, EventArgs e)
        {
            if (!ValidateTitleInput()) return;

            string checkIsbn = "SELECT COUNT(*) FROM BookTitle WHERE ISBN = @ISBN";
            SqlParameter[] checkParams = new SqlParameter[] { new SqlParameter("@ISBN", txtISBN.Text.Trim()) };
            DataTable dt = DatabaseHelper.ExecuteQuery(checkIsbn, checkParams);

            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                MessageBox.Show("A book with this ISBN already exists.", "Duplicate ISBN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO BookTitle (Title, Author, ISBN, Genre, PublicationYear) " +
                "VALUES (@Title, @Author, @ISBN, @Genre, @PublicationYear)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Title", txtTitle.Text.Trim()),
                new SqlParameter("@Author", txtAuthor.Text.Trim()),
                new SqlParameter("@ISBN", txtISBN.Text.Trim()),
                new SqlParameter("@Genre", cmbGenre.SelectedItem.ToString()),
                new SqlParameter("@PublicationYear", (int)numYear.Value)
            };

            int rows = DatabaseHelper.ExecuteNonQuery(query, parameters);
            if (rows > 0)
            {
                MessageBox.Show("Book title added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTitleInputs();
                LoadTitles();

            }
            else
            {
                MessageBox.Show("Failed to add book title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateTitle_Click(object sender, EventArgs e)
        {
            if (selectedTitleId == -1)
            {
                MessageBox.Show("Please select a title to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateTitleInput()) return;

            string query = "UPDATE BookTitle SET Title = @Title, Author = @Author, ISBN = @ISBN, Genre = @Genre, " +
                "PublicationYear = @PublicationYear WHERE TitleId = @TitleId";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Title", txtTitle.Text.Trim()),
                new SqlParameter("@Author", txtAuthor.Text.Trim()),
                new SqlParameter("@ISBN", txtISBN.Text.Trim()),
                new SqlParameter("@Genre", cmbGenre.SelectedItem.ToString()),
                new SqlParameter("@PublicationYear", (int)numYear.Value),
                new SqlParameter("@TitleId", selectedTitleId)
            };

            int rows = DatabaseHelper.ExecuteNonQuery(query, parameters);
            if (rows > 0)
            {
                MessageBox.Show("Book title updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTitleInputs();
                RefreshAll();
            }
            else
            {
                MessageBox.Show("Failed to update book title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTitles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTitles.Rows[e.RowIndex];
                selectedTitleId = Convert.ToInt32(row.Cells["TitleId"].Value);
                txtTitle.Text = row.Cells["Title"].Value?.ToString();
                txtAuthor.Text = row.Cells["Author"].Value?.ToString();
                txtISBN.Text = row.Cells["ISBN"].Value?.ToString();
                cmbGenre.SelectedItem = row.Cells["Genre"].Value?.ToString();

                if (int.TryParse(row.Cells["PublicationYear"].Value?.ToString(), out int year))
                {
                    if (year >= numYear.Minimum && year <= numYear.Maximum)
                    {
                        numYear.Value = year;
                    }
                }
            }
        }

        private void btnSearchTitle_Click(object sender, EventArgs e)
        {
            LoadTitles(txtSearchTitle.Text.Trim());
        }

        private void btnClearTitle_Click(object sender, EventArgs e)
        {
            ClearTitleInputs();
            txtSearchTitle.Clear();
            LoadTitles();
        }

        // BOOK COPY METHODS

        private void PopulateTitleDropdown()
        {
            string query = "SELECT TitleId, Title FROM BookTitle ORDER BY Title ASC";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            cmbTitle.DataSource = dt;
            cmbTitle.DisplayMember = "Title";
            cmbTitle.ValueMember = "TitleId";
            cmbTitle.SelectedIndex = -1;
        }

        private void LoadCopies()
        {
            string query = @"SELECT BC.CopyID, BT.TitleID, BT.Title AS [Book Title], BC.Status FROM BookCopy BC" +
                " JOIN BookTitle BT ON BC.TitleID = BT.TitleID ORDER BY BC.CopyID DESC";
            dgvCopies.DataSource = DatabaseHelper.ExecuteQuery(query);
        }

        private void btnAddCopies_Click(object sender, EventArgs e)
        {
            if (cmbTitle.SelectedValue == null)
            {
                MessageBox.Show("Please select a book title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO BookCopy (TitleID, Status) VALUES (@TitleID, @Status)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TitleID", Convert.ToInt32(cmbTitle.SelectedValue)),
                new SqlParameter("@Status", cmbStatus.SelectedItem.ToString())
            };

            int rows = DatabaseHelper.ExecuteNonQuery(query, parameters);
            if (rows > 0)
            {
                MessageBox.Show("Book copy added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedCopyId = -1;
                cmbTitle.SelectedIndex = -1;
                cmbStatus.SelectedIndex = -1;
                LoadCopies();
            }
        }

        private void btnUpdateCopies_Click(object sender, EventArgs e)
        {
            if (selectedCopyId == -1)
            {
                MessageBox.Show("Please select a copy to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE BookCopy SET Status = @Status WHERE CopyID = @CopyID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Status", cmbStatus.SelectedItem.ToString()),
                new SqlParameter("@CopyID", selectedCopyId)
            };

            int rows = DatabaseHelper.ExecuteNonQuery(query, parameters);
            if (rows > 0)
            {
                MessageBox.Show("Book copy updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedCopyId = -1;
                cmbStatus.SelectedIndex = -1;
                cmbTitle.SelectedIndex = -1;
                LoadCopies();
            }
        }

        private void dgvCopies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCopies.Rows[e.RowIndex];
                selectedCopyId = Convert.ToInt32(row.Cells["CopyID"].Value);
                cmbTitle.SelectedValue = Convert.ToInt32(row.Cells["TitleID"].Value);
                cmbStatus.SelectedItem = row.Cells["Status"].Value?.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
