using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Martin_Fowler
{
    class Statement
    {
        


        public Statement()
        {
                
        }

        public String statement(Customer customer, Rental rentals)
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
                        

            string result = printContent();
            int index = 0;

            foreach ( Rental item in rentals) { 
                double thisAmount = 0;
                Rental rental = (Rental)enum_rental.ElementAt(index);
                //determine amounts for rental line
                thisAmount = amountFor(rental);
                // add frequent renter points
                frequentRenterPoints++;
                // add bonus for a two day new release rental
                if ((rental.getPriceCode() == Movie.NEW_RELEASE) && rental.getDaysRented() > 1)
                    frequentRenterPoints++;
                //show figures for this rental
                result += "\t" + rental.getMovie().getTitle() + "\t" + "\t" + rental.getDaysRented() + "\t" + thisAmount.ToString() + "\n";
                totalAmount += thisAmount;

            }
            //add footer lines
            result += "Amount owed is " + totalAmount.ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString() + " frequent renter points";
            return result;
        }

    }
}
