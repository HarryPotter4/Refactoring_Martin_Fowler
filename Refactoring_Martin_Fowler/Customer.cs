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
                                
            String result = "Rental Record for " + this.getName() + "\n";
            result += "\t" + "Title" + "\t" + "\t" + "Days" + "\t" + "Amount" + "\n";
            int index = 0;

            while (index < enum_rental.Count())
            {
                double thisAmount = 0;
                Rental each = (Rental)enum_rental.ElementAt(index);
                //determine amounts for each line
                thisAmount = amountFor(each);
                // add frequent renter points
                frequentRenterPoints++;
                // add bonus for a two day new release rental
                if ((each.getMovie().getPriceCode() == Movie.NEW_RELEASE) && each.getDaysRented() > 1)
                    frequentRenterPoints++;
                //show figures for this rental
                result += "\t" + each.getMovie().getTitle() + "\t" + "\t" + each.getDaysRented() + "\t" + thisAmount.ToString() + "\n";
                totalAmount += thisAmount;

                index++;
            }
            //add footer lines
            result += "Amount owed is " + totalAmount.ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString() + " frequent renter points";
            return result;
        }

        private double amountFor(Rental each)
        {
            double thisAmount = 0;
            switch (each.getMovie().getPriceCode())
            {
                case Movie.REGULAR:
                    thisAmount += 2;
                    if (each.getDaysRented() > 2)
                        thisAmount += (each.getDaysRented() - 2) * 1.5;
                    break;
                case Movie.NEW_RELEASE:
                    thisAmount += each.getDaysRented() * 3;
                    break;
                case Movie.CHILDRENS:
                    thisAmount += 1.5;
                    if (each.getDaysRented() > 3)
                        thisAmount += (each.getDaysRented() - 3) * 1.5;
                    break;
            }
            return thisAmount;
        }

    }
}
