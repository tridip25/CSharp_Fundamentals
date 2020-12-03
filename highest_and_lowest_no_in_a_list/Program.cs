using System;
using System.Collections.Generic;
namespace highest_and_lowest_no_in_a_list
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new CalculateResult();
            var grades = new List<double>(){7.69, 8.67, 8.54, 6.96 , 8.00 , 7.54 , 6.96 , 8.42};
            obj.getMax(grades);
            obj.getMin(grades);

        }
    }
}
