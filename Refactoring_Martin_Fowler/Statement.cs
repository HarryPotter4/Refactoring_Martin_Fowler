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
            
                        

            string result = printContent();
        
            foreach (Rental item in rentals)
            {

                double localPrice = 0;


                //determine amounts for rental line
                localPrice = item.getAmount(item, localPrice);

                // add frequent renter points
                frequentRenterPoints++;

                // add bonus for a two day new release rental
                
                
                //show figures for this rental
                result += "\t" + rental.getMovie().getTitle() + "\t" + "\t" + rental.getDaysRented() + "\t" + thisAmount.ToString() + "\n";
                totalPrice += thisAmount;

            }
            //add footer lines
            result += "Amount owed is " + totalPrice.ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString() + " frequent renter points";
            return result;
        }
        public int calcFrequentRenterPoint(List<Rental> rentals)
        {
            int tempRenterPoint = 0;

            foreach (Rental item in rentals)
            {
                tempRenterPoint++;
            
                if ((item.getPriceCode() == Constants.NEW_RELEASE) && item.getDaysRented() > 1)
                    tempRenterPoint++;
            }
        }

    }
}
