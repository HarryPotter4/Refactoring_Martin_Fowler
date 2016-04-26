using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Martin_Fowler
{
    class Output
    {
        private string result;
        public string Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
            }
        }

        public string printContent()
        {
            Result = "Rental Record for " + this.getName() + "\n";
            Result += "\t" + "Title" + "\t" + "\t" + "Days" + "\t" + "Amount" + "\n";
           
        }

        public void setListOutput(Rental rental, double totalPrice)
        {
            Result += "\t" + rental.getMovie().getTitle() + "\t" + "\t" + rental.getDaysRented() + "\t" + totalPrice.ToString() + "\n";            
        }

        public void setTotalPrice(double totalPrice)
        {
            Result += "Amount owed is " + totalPrice.ToString() + "\n"; 
        }
        public  void setFrequentRenterPoints(int frequentRenterPoints)
        {
            Result += "You earned " + frequentRenterPoints.ToString() + " frequent renter points";
        }



    }
}
