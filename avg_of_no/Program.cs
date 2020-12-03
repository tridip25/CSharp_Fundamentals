using System;

namespace avg_of_no
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers= new double[3];
            numbers[0] = 4.4;
            numbers[1] = 7.5;
            numbers[2] = 3.5;
            var sum = numbers[0] + numbers[1] + numbers[2];
            var avg = sum / 3;
            Console.WriteLine("Average is: "+avg);
        }
    }
}
