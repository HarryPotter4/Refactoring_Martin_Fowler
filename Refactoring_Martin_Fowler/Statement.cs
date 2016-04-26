using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Martin_Fowler
{
    class Statement
    {
        private Output outputLine;


        public Statement(Output output)
        {
            outputLine = output;
        }

        public String statement(Customer customer, List<Rental> rentals)
        {
            double totalPrice = 0;
            outputLine.printContent();

            foreach (Rental item in rentals)
            {
                double localPrice = 0;

                //determine amounts for rental line
                localPrice = item.getAmount(item);

                //show figures for this rental
                outputLine.setListOutput(item, totalPrice);
                totalPrice += localPrice;

            }
            //add footer lines
            outputLine.setTotalPrice(totalPrice);
            
        }

        


        public int calcFrequentRenterPoints(List<Rental> rentals)
        {
            int tempRenterPoint = 0;

            foreach (Rental item in rentals)
            {
                tempRenterPoint++;

                // add bonus for a two day new release rental
                if ((item.getPriceCode() == Constants.NEW_RELEASE) && item.getDaysRented() > 1)
                    tempRenterPoint++;
            }
            return tempRenterPoint;
        }

    }
}
