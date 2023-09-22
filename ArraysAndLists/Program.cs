using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var firstArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /*     for (int i = 0; i <= firstArray.Length; i++)
                 {
                     Console.WriteLine(firstArray[i]);
                 }*/

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach (var num in firstArray)
            {
                /* int i = 0; i < firstArray.Length; i++*/
                if (num % 2 == 0)
                {
                    evens.Add(num);
                    Console.WriteLine($"{num} is an even number.");
                }
                else
                {
                    odds.Add(num);
                    Console.WriteLine($"{num} is an odd number.");
                }

                /* Now using foreach or for loops,
                 * display each List of even and odd numbers
                 * Try to be creative in your display
                 */

/*                foreach (var item in evens)
                {
                    Console.WriteLine($"{item} is an even number");
                }

                foreach (var oddNumber in odds)
                {
                    Console.WriteLine($"{oddNumber} is an odd number");
                }
*/

            }

        }
    }
}
