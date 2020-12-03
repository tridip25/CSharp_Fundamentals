using System;
using System.Collections.Generic;

namespace prog_that_illstrate_clas_obj
{
    class file2
    {

        public void getStatistics(List<double> grades)
        {
            var high = double.MinValue;
            var low = double.MaxValue;
            foreach(var grade in grades)
            {
                if(high < grade)
                {
                    high = grade;
                }
                if(low > grade)
                {
                    low = grade;
                }
            }
            Console.WriteLine($"Highest grade is {high} & Lowest grade is {low}");

        }

    }
}