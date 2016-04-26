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
            String result;
            Console.WriteLine("Welcome to the Movie Store");

            List<Movie> movie = new List<Movie>();
            List<Customer> customer = new List<Customer>();

            movie.Add(new Movie("movie1", 1,10));
            movie.Add(new Movie("movie2", 2,5));
            
            customer.Add(new Customer("joe"));
            
            customer.ElementAt(1).addRental(rental.ElementAt(1));
            customer.ElementAt(1).addRental(rental.ElementAt(2));

            Console.WriteLine("Let's get the Statement");
            result = customer.ElementAt(1).statement();
            Console.Write(result);

            Console.ReadLine();
        }
    }
}
