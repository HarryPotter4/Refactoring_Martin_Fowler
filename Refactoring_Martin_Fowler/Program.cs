﻿using System;
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
            Movie m1 = new Movie("movie1", 1);
            Movie m2 = new Movie("movie2", 2);
            Rental r1 = new Rental(m1, 10);
            Rental r2 = new Rental(m2, 5);
            Customer c1 = new Customer("joe");
            c1.addRental(r1); c1.addRental(r2);
            Console.WriteLine("Let's get the Statement");
            result = c1.statement();
            Console.Write(result);

            Console.ReadLine();
        }
    }
}
