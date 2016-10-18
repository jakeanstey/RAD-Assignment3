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

        public OrderForm(SelectionForm selectionForm, Movie movie)
        {
            InitializeComponent();
            this.movie = movie;
            this.selectionForm = selectionForm;
            initialize();
        }

        private void initialize()
        {
            MovieTitleTextBox.Text = movie.GetName() + " (" + movie.GetYear() + ")";
            MovieGenreTextBox.Text = movie.GetGenre();
            MoviePosterPictureBox.Image = (Image)Resources.ResourceManager.GetObject(movie.GetImagePath());
            Calculate(0);
        }

        private void Calculate(double additionalCosts)
        {
            double cost = movie.GetCost();
            double subtotal = cost + additionalCosts;
            double salesTax = subtotal * 0.13;
            double grandTotal = subtotal + salesTax;
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
            this.Close();
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
    }
}
