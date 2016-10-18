using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Movie
    {
        private String Title, Genre, Director, ImagePath;
        private int Year;
        private double Cost;

        public Movie(String Title, String Genre, int Year, String Director, double Cost, String ImagePath)
        {
            this.Title = Title;
            this.Genre = Genre;
            this.Year = Year;
            this.Director = Director;
            this.Cost = Cost;
            this.ImagePath = ImagePath;
        }

        /// <summary>
        /// Returns the movie title.
        /// </summary>
        /// <returns></returns>
        public String GetName()
        {
            return Title;
        }

        public String GetGenre()
        {
            return Genre;
        }

        public int GetYear()
        {
            return Year;
        }

        public String GetDirector()
        {
            return Director;
        }

        public String GetImagePath()
        {
            return ImagePath;
        }

        public double GetCost()
        {
            return Cost;
        }

        override
        public String ToString()
        {
            return Title + " (" + Year + ")\nDirected by: " + Director + "\nGenre: " + Genre;
        }
    }
}
