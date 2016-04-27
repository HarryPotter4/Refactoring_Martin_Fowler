using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Martin_Fowler
{
    class Movie
    {     
        private string title;
        private int priceCode;
        
      
        public Movie(string newtitle, int priceCode)
        {
            this.priceCode = priceCode;
            this.title = newtitle;
        }
        //public void setPriceCode(int arg)
        //{
        //    priceCode = arg;
        //}

        public int getPriceCode()
        {
            return this.priceCode;
        }
        public string getTitle()
        {
            return title;
        }
        
        
    }
}
