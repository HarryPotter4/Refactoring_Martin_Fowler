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
        private Output outputLine;
        
        private List<Rental> rentals = new List<Rental>();
        

        public Customer(String newname)
        {
            name = newname;
            outputLine = new Output();

            this.addRental(new Rental(10, 1,"movie1"));
            this.addRental(new Rental(5 , 2,"movie2"));
        }

        public void addRental(Rental arg)
        {            
            rentals.Add(arg);
        }

        public List<Rental> getRentals()
        {
            return rentals;
        }

        public String getName()
        {
            return name;
        }

        private double amountFor(Rental rental)
        {
            return rental.getAmount(rental);
            
        }
    }
}
