using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Martin_Fowler
{
    class Rental
    {
        
        private int daysRented;
        private int newpriceCode;        
        private Movie movie;
        

        public Rental( int newdaysRented,int priceCode, string movieName)
        {            
            daysRented = newdaysRented;
            newpriceCode = priceCode;
            movie = new Movie(movieName, priceCode);

        }
        public int getMoviePriceCode()
        {
            return movie.getPriceCode();
        }
        public string getMovieTitle()
        {
            return movie.getTitle();
        }



        public int getDaysRented()
        {
            return daysRented;
        }
        public double getAmount(Rental rental)
        {
            double thisAmount = 0.0;
            switch (rental.getPriceCode())
            { 
                case Constants.REGULAR:
                    thisAmount += 2;
                    if (rental.getDaysRented() > 2)
                        thisAmount += (rental.getDaysRented() - 2) * 1.5;
                    break;
                case Constants.NEW_RELEASE:
                    thisAmount += rental.getDaysRented() * 3;
                    break;
                case Constants.CHILDRENS:
                    thisAmount += 1.5;
                    if (rental.getDaysRented() > 3)
                        thisAmount += (rental.getDaysRented() - 3) * 1.5;
                    break;
            }
        
            return thisAmount;
        }
        public int getPriceCode()
        {
            return newpriceCode;
        }
    }
}
