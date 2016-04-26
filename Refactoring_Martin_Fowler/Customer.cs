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
        private Statement statements;

        public Customer(String newname)
        {
            name = newname;

            outputLine = new Output();
            statements = new Statement(outputLine);
            

            this.addRental(new Rental(1,3));
            this.addRental(new Rental(2,4));

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
            return rental.getAmount(rental);
            
        }

        

        public  int getFrequentRenterPoints()
        {
            frequentRenterPoints = statements.calcFrequentRenterPoints(rentals);
            outputLine.setFrequentRenterPoints(frequentRenterPoints);
            return frequentRenterPoints;
        }



        
    }
}
