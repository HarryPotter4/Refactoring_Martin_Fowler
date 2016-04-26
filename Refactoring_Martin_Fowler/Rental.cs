using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Martin_Fowler
{
    class Rental
    {
        
        private int daysRented;

        public Rental( int newdaysRented)
        {
            
            daysRented = newdaysRented;
        }
        public int getDaysRented()
        {
            return daysRented;
        }
        
    }
}
