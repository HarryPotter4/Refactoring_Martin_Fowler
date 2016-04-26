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

        public Rental( int newdaysRented)
        {            
            daysRented = newdaysRented;
        }
        public int getDaysRented()
        {
            return daysRented;
        }
        private static double getAmount(Rental rental, double thisAmount)
        {
            switch (movie.getPriceCode())
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
    }
}
