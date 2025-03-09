using System;
using System.Windows.Forms;

namespace Database_Project
{
    public partial class UserMoviePage : Form
    {
        public UserMoviePage()
        {
            InitializeComponent();
        }

        // Exit the application
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Navigate to FilterPage when the Filter button is clicked
        private void filter_Click(object sender, EventArgs e)
        {
            // Check if FilterPage is already open, if not open it
            foreach (Form form in Application.OpenForms)
            {
                if (form is FilterPage)
                {
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }

            FilterPage filterPage = new FilterPage();
            filterPage.Show();
            this.Hide();  // Hide the current page (MMoviePage)
        }

        // Navigate to InsertPage when the Insert button is clicked
        private void insert_Click(object sender, EventArgs e)
        {
            // Check if InsertPage is already open, if not open it
            foreach (Form form in Application.OpenForms)
            {
                if (form is InsertPage)
                {
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }

            InsertPage insertPage = new InsertPage();
            insertPage.Show();
            this.Hide();  // Hide the current page (MMoviePage)
        }

        // Navigate to SearchPage when the Search button is clicked
        private void search_Click(object sender, EventArgs e)
        {
            // Check if SearchPage is already open, if not open it
            foreach (Form form in Application.OpenForms)
            {
                if (form is SearchPage)
                {
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }

            SearchPage searchPage = new SearchPage();
            searchPage.Show();
            this.Hide();  // Hide the current page (MMoviePage)
        }

        private void hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;  // Minimizes the form
        }
    }
}
