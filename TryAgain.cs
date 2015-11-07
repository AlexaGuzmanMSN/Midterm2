﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using movieLibrary;

namespace midterm_again1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Movie Rental Input System");
                Console.WriteLine("How many customer rentals are you going to be entering?");
                int customerInputs = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= customerInputs; i++)
                {
                    MovieRental rental = new MovieRental();
                    rental.MovieInput();
                }
                Console.WriteLine("How many returns will be entered?");
                int customerReturns = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= customerReturns; i++)
                {
                    MovieRental rental = new MovieRental();
                    rental.ReturnedMovies();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}