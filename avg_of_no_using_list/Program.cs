using System;
using System.Collections.Generic;
namespace avg_of_no_using_list
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>(){7.69, 8.67, 8.54, 6.96, 8.00, 7.54, 6.96, 8.42};
            var sum=0.0;
            int count=0;
            foreach(var grade in grades)
            {
                sum+=grade;
                count++;
            }
            var avg=sum / count;
            Console.WriteLine($"Average of the grades is:{avg:N2}");

            // 'grades.Count' gives you the list size ......
        }
    }
}
