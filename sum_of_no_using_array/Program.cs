using System;

namespace sum_of_no_using_array
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new []{12.7, 10.3, 6.11, 4.1};
            var result = 0.0;
            foreach(var number in numbers)
            {
                result+= number;
            }
            Console.WriteLine("Sum of the numbers in the array is: "+result);
        }
    }
}
