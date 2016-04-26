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
        
        public Movie(String newtitle)
        {
            title = newtitle;                               
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
