using System;


namespace ex_method_overloading
{      
    public class File
    {

        public void calculate(double a, double b)
        {
            var k = a * b;
            Console.WriteLine($"Multiplying we get :{k}");
        }

        public void calculate(double a, double b, double c)
        {
            var k = a + b + c;
            Console.WriteLine($"Adding we get :{k}");
        }

    }
}
