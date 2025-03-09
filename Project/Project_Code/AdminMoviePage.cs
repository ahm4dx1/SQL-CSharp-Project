using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Project
{
    public partial class AdminMoviePage : Form
    {
        public AdminMoviePage()
        {
            InitializeComponent();
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hide_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;  // Minimizes the form
        }

        private void update_Click_1(object sender, EventArgs e)
        {
            // Check if UpdatePage is already open, if not open it
            foreach (Form form in Application.OpenForms)
            {
                if (form is UpdatePage)
                {
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }

            UpdatePage updatePage = new UpdatePage();
            updatePage.Show();
            this.Hide();  // Hide the current page (MMoviePage)
        }

        private void filter_Click_1(object sender, EventArgs e)
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


        private void insert_Click_1(object sender, EventArgs e)
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

        private void detail_Click(object sender, EventArgs e)
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
    }
}
