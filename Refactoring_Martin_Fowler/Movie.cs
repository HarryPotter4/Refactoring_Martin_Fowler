using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Martin_Fowler
{
    class Movie
    {
        

        private String title;
        private int priceCode;
        private Rental rental;

        public Movie(String newtitle, int newpriceCode, int newdaysRented)
        {
            title = newtitle;
            priceCode = newpriceCode;

            rental = new Rental(newdaysRented);
        }
        public int getPriceCode()
        {
            return priceCode;
        }
        public void setPriceCode(int arg)
        {
            priceCode = arg;
        }
        public String getTitle()
        {
            return title;
        }



        public Movie getMovie()
        {
            return this;
        }
    }
}
