using System;

namespace sum_of_no
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 5.6;  // also you can use var keyword, which will automatically choose the data type
                            // var x=3.5; (x is float) , var x=3; (x is integer now)
            double y = 9.8;
            double result = x + y;
            Console.WriteLine(result);
        }
    }
}
