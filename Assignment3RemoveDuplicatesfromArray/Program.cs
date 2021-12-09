using System;
using System.Linq;

namespace Assignment3RemoveDuplicatesfromArray
{
    class Program
    {  
        static void Main(string[] args)
        {
            int[] array = {1, 2, 2, 3, 3, 4, 1, 2, 5 };

            // function to remove the duplicates
            int[] distinct = array.Distinct().ToArray();

            Console.WriteLine("The array without duplicates is: " + String.Join(",", distinct));
        }
    }
}
