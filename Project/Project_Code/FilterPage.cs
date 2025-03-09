using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Database_Project
{
    public partial class FilterPage : Form
    {
        string connectionString = @"Server=localhost;Database=project;Uid=root;Pwd=root";

        public FilterPage()
        {
            InitializeComponent();
        }

        private void filterbutton_Click(object sender, EventArgs e)
        {
            string titleFilter = movietextbox.Text.Trim();
            string genreFilter = genrecombo.SelectedItem?.ToString() ?? "";
            int releaseYear = 0;
            if (int.TryParse(releaseyearcombo.SelectedItem?.ToString(), out int year))
                releaseYear = year;

            decimal ratingFilter = 0;
            // Check if the rating is a ">x" value
            string selectedRating = ratingcombo.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedRating) && selectedRating.StartsWith(">"))
            {
                if (decimal.TryParse(selectedRating.Substring(1), out ratingFilter))
                {
                    // Adjust ratingFilter to be the starting point (e.g., if user selects >9, ratingFilter becomes 9.1)
                    ratingFilter += 0.1m;
                }
            }

            // Fetch and display data based on the provided filters
            FetchAndDisplayMovies(titleFilter, genreFilter, releaseYear, ratingFilter);
        }


        private void FetchAndDisplayMovies(string title, string genre, int releaseYear, decimal rating)
        {
            // Skip if no filters are provided
            if (string.IsNullOrEmpty(title) && string.IsNullOrEmpty(genre) && releaseYear == 0 && rating == 0)
            {
                MessageBox.Show("Please provide at least one filter criteria.", "No Filters", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Base query
                    string query = "SELECT Title, GenreName AS Genre, ReleaseYear, Rating FROM Movies WHERE 1=1";

                    // Add conditions dynamically
                    if (!string.IsNullOrEmpty(title))
                        query += " AND Title LIKE @Title";

                    if (!string.IsNullOrEmpty(genre))
                        query += " AND GenreName = @Genre";

                    if (releaseYear > 0)
                        query += " AND ReleaseYear = @ReleaseYear";

                    if (rating > 0)
                        query += " AND Rating >= @Rating";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters for each condition
                        if (!string.IsNullOrEmpty(title))
                            cmd.Parameters.AddWithValue("@Title", $"%{title}%");

                        if (!string.IsNullOrEmpty(genre))
                            cmd.Parameters.AddWithValue("@Genre", genre);

                        if (releaseYear > 0)
                            cmd.Parameters.AddWithValue("@ReleaseYear", releaseYear);

                        if (rating > 0)
                            cmd.Parameters.AddWithValue("@Rating", rating);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable moviesTable = new DataTable();
                            adapter.Fill(moviesTable);

                            // Bind data to the DataGridView
                            datagrid.DataSource = moviesTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void movietextbox_TextChanged(object sender, EventArgs e)
        {
            // Optionally handle real-time filtering
        }

        private void genrecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle any additional logic for genre selection
        }

        private void releaseyearcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle any additional logic for release year selection
        }

        private void ratingcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle any additional logic for rating selection
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;  // Minimizes the form
        }

        private void back_Click(object sender, EventArgs e)
        {
            // Create an instance of MainPage
            AdminMoviePage adminmoviePage = new AdminMoviePage();

            // Close the current form
            this.Close();

            // Show the MainPage
            adminmoviePage.Show();
        }

        private void FilterPage_Load_1(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Load Genres into genrecombo
                    using (MySqlCommand cmd = new MySqlCommand("SELECT GenreName FROM Genres", conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            genrecombo.Items.Add(reader.GetString("GenreName"));
                        }
                    }

                    // Load Release Years into releaseyearcombo
                    releaseyearcombo.Items.Clear(); // Ensure no duplicates
                    for (int year = DateTime.Now.Year; year >= 1900; year--)
                    {
                        releaseyearcombo.Items.Add(year.ToString());
                    }

                    // Load Ratings into ratingcombo
                    ratingcombo.Items.Clear(); // Ensure no duplicates
                    for (decimal rating = 1; rating <= 10; rating++)
                    {
                        ratingcombo.Items.Add($">{rating}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while populating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
