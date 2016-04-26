using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Martin_Fowler
{
    class Customer
    {
        private String name;
        

        private List<Rental> rentals = new List<Rental>();

        public Customer(String newname)
        {
            name = newname;

            this.addRental(new Rental(1));
            this.addRental(new Rental(2));

        }

        public void addRental(Rental arg)
        {            
            rentals.Add(arg);
        }

        public Customer getRentals()
        {
            return this;
        }

        public String getName()
        {
            return name;
        }
        

        private string printContent()
        {
            String result = "Rental Record for " + this.getName() + "\n";
            result += "\t" + "Title" + "\t" + "\t" + "Days" + "\t" + "Amount" + "\n";
            return result;
        }

        private double amountFor(Rental rental)
        {
            double thisAmount = 0;
            thisAmount = getAmount(rental, thisAmount);
            return thisAmount;
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
