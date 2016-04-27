using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Martin_Fowler
{
    class Output
    {
        public void welcomePrint()
        {
            Console.WriteLine("Welcome to the Movie Store");
        }

        public void printContent(string name)
        {
            string result = "Rental Record for " + name + "\n";
            result += "\t" + "Title" + "\t" + "\t" + "Days" + "\t" + "Amount";

            Console.WriteLine(result);           
        }

        internal void startStatment()
        {
            Console.Write("Let's get the statement \n");
        }

        public void setListOutput(string movieTitel, int rentedDays, double totalPrice)
        {
            string result = "\t" + movieTitel + "\t" + "\t" + rentedDays + "\t" + totalPrice.ToString();
            Console.WriteLine(result);          
        }

        public void setTotalPrice(double totalPrice)
        {
            string result = "Amount owed is " + totalPrice.ToString() + "\n";
            Console.Write(result);
        }

        public  void setFrequentRenterPoints(int frequentRenterPoints)
        {
            string result = "You earned " + frequentRenterPoints.ToString() + " frequent renter points";
            Console.WriteLine(result);
        }



    }
}