using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Martin_Fowler
{
    class Rental
    {
        private Movie movie;
        private int daysRented;
        public Rental(Movie newmovie, int newdaysRented)
        {
            movie = newmovie;
            daysRented = newdaysRented;
        }
        public int getDaysRented()
        {
            return daysRented;
        }
        public Movie getMovie()
        {
            return movie;
        }
    }
}
