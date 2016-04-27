using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Martin_Fowler
{
    class Statement
    {
        private Customer customer;
        private Output outputLine;

        public Statement(Customer customer)
        {
            this.customer = customer;
            outputLine = new Output();

            outputLine.welcomePrint();
            outputLine.startStatment();
            statement(customer);

            int frequentRenterPoints = calcFrequentRenterPoints(customer.getRentals());
            outputLine.setFrequentRenterPoints(frequentRenterPoints);

        }

        public void statement(Customer customer)
        {
            double totalPrice = 0;
            outputLine.printContent(customer.getName());
            List<Rental> rentals = customer.getRentals();

            foreach (Rental item in rentals)
            {
                double localPrice = 0;
                                
                localPrice = item.getAmount(item);

                //show figures for this rental
                outputLine.setListOutput(item.getMovieTitle(),item.getDaysRented(), localPrice);
                totalPrice += localPrice;

            }
            //add footer lines
            outputLine.setTotalPrice(totalPrice);            
        }


        public int getFrequentRenterPoints()
        {
            int frequentRenterPoints = calcFrequentRenterPoints(customer.getRentals());
            outputLine.setFrequentRenterPoints(frequentRenterPoints);
            return frequentRenterPoints;
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
