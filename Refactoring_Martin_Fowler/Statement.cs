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

        public String statement(Customer customer, List<Rental> rentals)
        {
            double totalPrice = 0;
            int frequentRenterPoints = 0;
                        

            string result = printContent();
        
            foreach (Rental item in rentals)
            {

                double localPrice = 0;
               
                
                //determine amounts for rental line
                thisAmount = amountFor(rental);
                
                // add frequent renter points
                frequentRenterPoints++;
                
                // add bonus for a two day new release rental
                if ((rental.getPriceCode() == Movie.NEW_RELEASE) && rental.getDaysRented() > 1)
                    frequentRenterPoints++;
                
                //show figures for this rental
                result += "\t" + rental.getMovie().getTitle() + "\t" + "\t" + rental.getDaysRented() + "\t" + thisAmount.ToString() + "\n";
                totalPrice += thisAmount;

            }
            //add footer lines
            result += "Amount owed is " + totalPrice.ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString() + " frequent renter points";
            return result;
        }

    }
}
