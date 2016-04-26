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
        

        

        private double amountFor(Rental rental)
        {
            double thisAmount = 0;
            thisAmount = getAmount(rental, thisAmount);
            return thisAmount;
        }

        
    }
}
