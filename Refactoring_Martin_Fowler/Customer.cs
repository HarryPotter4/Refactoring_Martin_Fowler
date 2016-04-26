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
        }

        public void addRental(Rental arg)
        {            
            rentals.Add(arg);
        }

        public String getName()
        {
            return name;
        }


        public String statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;

            IEnumerable<Rental> enum_rental = rentals;

            string result = printContent();
            int index = 0;

            while (index < enum_rental.Count())
            {
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

                index++;
            }
            //add footer lines
            result += "Amount owed is " + totalAmount.ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString() + " frequent renter points";
            return result;
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
            switch (rental.getMovie().getPriceCode())
            {
                case Movie.REGULAR:
                    thisAmount += 2;
                    if (rental.getDaysRented() > 2)
                        thisAmount += (rental.getDaysRented() - 2) * 1.5;
                    break;
                case Movie.NEW_RELEASE:
                    thisAmount += rental.getDaysRented() * 3;
                    break;
                case Movie.CHILDRENS:
                    thisAmount += 1.5;
                    if (rental.getDaysRented() > 3)
                        thisAmount += (rental.getDaysRented() - 3) * 1.5;
                    break;
            }

            return thisAmount;
        }
    }
}
