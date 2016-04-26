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

        public Movie(String newtitle, int newpriceCode)
        {
            title = newtitle;
            priceCode = newpriceCode;
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
            return movie;
        }
    }
}
