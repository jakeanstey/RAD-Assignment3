using Assignment3.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class SelectionForm : Form
    {
        private List<Movie> Movies = new List<Movie>();
        private OrderForm orderForm;

        public SelectionForm()
        {
            InitializeComponent();
            Initialize();
            orderForm = new OrderForm(this);
        }

        private void Initialize()
        {
            Movie BlairWitch = new Assignment3.Movie("Blair Witch", "Horror", 2016, "Adam Winguard", 2.99, "blairWitch");
            Movie Furious7 = new Assignment3.Movie("Furious 7", "Action", 2015, "James Wan", 1.99, "furious7");
            Movie GoodNeighbor = new Assignment3.Movie("The Good Neighbor", "Suspense", 2016, "Kasra Farahani", 1.49, "goodNeighbor");
            Movie DontBreathe = new Assignment3.Movie("Don't Breathe", "Horror", 2016, "Fede Alvarez", 1.99, "dontBreathe");
            Movie JoeDirt = new Assignment3.Movie("Joe Dirt", "Comedy", 2001, "Dennie Gordon", 0.99, "joeDirt");
            Movie SuperTroopers = new Assignment3.Movie("Super Troopers", "Comedy", 2001, "Jay Chandrasekhar", 0.99, "superTroopers");
            Movie SuicideSquad = new Assignment3.Movie("Suicide Squad", "Action", 2016, "David Ayer", 2.99, "suicideSquad");
            Movie ElectionYear = new Assignment3.Movie("The Purge: Election Year", "Horror", 2016, "James DeMonaco", 1.49, "electionYear");
            Movie GraveEncounters = new Assignment3.Movie("Grave Encounters", "Horror", 2011, "The Vicious Brothers", 0.99, "graveEncounters");
            Movie LightsOut = new Assignment3.Movie("Lights Out", "Horror", 2016, "David F. Sandberg", 2.99, "lightsOut");

            Movies.Add(BlairWitch);
            Movies.Add(Furious7);
            Movies.Add(GoodNeighbor);
            Movies.Add(DontBreathe);
            Movies.Add(JoeDirt);
            Movies.Add(SuperTroopers);
            Movies.Add(SuicideSquad);
            Movies.Add(ElectionYear);
            Movies.Add(GraveEncounters);
            Movies.Add(LightsOut);

            for(int index = 0; index < Movies.Count; index++)
            {
                MovieComboBox.Items.Insert(index, Movies.ElementAt(index).GetName());
            }
        }

        /// <summary>
        /// Finds the movie by index of the List of movies.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private Movie GetMovieByName(String Name)
        {
            //Fallback movie set
            Movie ReturnMovie = Movies.ElementAt(0);

            foreach(Movie movie in Movies)
            {
                if(movie.GetName().Equals(Name))
                {
                    ReturnMovie = movie;
                }
            }
            
            return ReturnMovie;
        }

        /// <summary>
        /// Handle updating the movie poster preview and information about the movie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String SelectedMovieName = MovieComboBox.SelectedItem.ToString();
            Debug.Write(SelectedMovieName);
            Movie SelectedMovie = GetMovieByName(SelectedMovieName);

            MovieTitleTextBox.Text = SelectedMovie.GetName() + " (" + SelectedMovie.GetYear() + ")";
            MovieGenreTextBox.Text = SelectedMovie.GetGenre();
            MoviePriceTextBox.Text = "$" + SelectedMovie.GetCost();

            MoviePosterPictureBox.Image = (Image)Resources.ResourceManager.GetObject(SelectedMovie.GetImagePath());

            NextButton.Enabled = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            orderForm.SetMovie(GetMovieByName(MovieComboBox.SelectedItem.ToString()));
            orderForm.Show();
            this.Hide();
        }
    }
}
