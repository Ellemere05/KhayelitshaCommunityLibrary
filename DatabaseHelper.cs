using System;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace KhayelitshaCommunityLibrary
{
    public static class DatabaseHelper
    {
        // Reads the connection in App.config
        private static readonly string ConnectionString =
            ConfigurationManager.ConnectionStrings["LibraryDBConn"]?.ConnectionString ?? string.Empty;

        // Returns a new connection
        public static SqlConnection GetConnection()
        {
            if (string.IsNullOrEmpty(ConnectionString))
            {
                MessageBox.Show("Connection string 'LibraryDBConn' not found in App.config.", "Configuration Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return new SqlConnection(ConnectionString);
        }

        // Test the connection
        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    if (conn == null) return false;
                    conn.Open();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Failed to connect to the database.\n\nError: {ex.Message}", "Database Connection Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error:\n{ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Executes SELECT queries and returns for table views
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable table = new DataTable();
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    if (conn == null) return table;

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database query error:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error:\n{ex.Message}", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return table;
        }

        // Executes INSERT, UPDATE and DELETE queries
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    if (conn == null) return 0;
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database execution error:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error:\n{ex.Message}", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rowsAffected;
        }
    }
}