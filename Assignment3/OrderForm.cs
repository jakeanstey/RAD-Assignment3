using Assignment3.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class OrderForm : Form
    {
        private Movie movie;
        private SelectionForm selectionForm;
        private double cost, subtotal, salesTax, grandTotal;

        public OrderForm(SelectionForm selectionForm)
        {
            InitializeComponent();
            this.selectionForm = selectionForm;
        }

        /// <summary>
        /// updates the order form from the movie referenced.
        /// </summary>
        private void UpdateMovie()
        {
            MovieTitleTextBox.Text = movie.GetName() + " (" + movie.GetYear() + ")";
            MovieGenreTextBox.Text = movie.GetGenre();
            MoviePosterPictureBox.Image = (Image)Resources.ResourceManager.GetObject(movie.GetImagePath());
            Calculate(0);
        }

        /// <summary>
        /// Calculates totals based on provided requirements.
        /// </summary>
        /// <param name="additionalCosts"></param>
        private void Calculate(double additionalCosts)
        {
            cost = movie.GetCost();
            subtotal = cost + additionalCosts;
            salesTax = subtotal * 0.13;
            grandTotal = subtotal + salesTax;
            CostTextBox.Text = "$" + cost.ToString("0.##");
            SubtotalTextBox.Text = "$" + subtotal.ToString("0.##");
            SalesTaxTextBox.Text = "$" + salesTax.ToString("0.##");
            GrandTotalTextBox.Text = "$" + grandTotal.ToString("0.##");
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Goes back to the previous form, keeping these details alive just in case.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            selectionForm.Show();
            this.Hide();
        }

        /// <summary>
        /// handles the optional DVD purchase.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(DVDCheckBox.Checked == true)
            {
                Calculate(10.00);
                DVDPriceLabel.Visible = true;
                DVDPriceTextBox.Visible = true;
                DVDPriceTextBox.Text = "$" + 10.00;
            }else
            {
                Calculate(0);
                DVDPriceLabel.Visible = false;
                DVDPriceTextBox.Visible = false;
            }
        }

        /// <summary>
        /// Sets the move of the current form.
        /// </summary>
        /// <param name="movie"></param>
        public void SetMovie(Movie movie)
        {
            this.movie = movie;
            UpdateMovie();
        }

        /// <summary>
        /// End of application -- movie now streaming.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamButton_Click(object sender, EventArgs e)
        {
            StreamForm streamForm = new StreamForm(MovieTitleTextBox.Text, grandTotal);
            streamForm.Show();
            this.Close();
        }
    }
}
