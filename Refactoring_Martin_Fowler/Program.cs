using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Martin_Fowler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customer = new List<Customer>();                        
            customer.Add(new Customer("joe"));
            

            
            Statement statement =  new Statement(customer.ElementAt(0));


            Console.ReadLine();
        }
    }
}
