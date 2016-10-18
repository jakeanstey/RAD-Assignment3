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

        private void UpdateMovie()
        {
            MovieTitleTextBox.Text = movie.GetName() + " (" + movie.GetYear() + ")";
            MovieGenreTextBox.Text = movie.GetGenre();
            MoviePosterPictureBox.Image = (Image)Resources.ResourceManager.GetObject(movie.GetImagePath());
            Calculate(0);
        }

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

        private void CloseApplication()
        {
            Application.Exit();
        }

        private void ExitMenuSelection_Click(object sender, EventArgs e)
        {
            CloseApplication();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            CloseApplication();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            selectionForm.Show();
            this.Hide();
        }

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

        public void SetMovie(Movie movie)
        {
            this.movie = movie;
            UpdateMovie();
        }

        private void Stream()
        {
            StreamForm streamForm = new StreamForm(MovieTitleTextBox.Text, grandTotal);
            streamForm.Show();
            this.Close();
        }

        private void StreamMenuSelection_Click(object sender, EventArgs e)
        {
            Stream();
        }

        private void StreamButton_Click(object sender, EventArgs e)
        {
            Stream();
        }
    }
}
