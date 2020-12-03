using System;
using System.Collections.Generic;
namespace highest_and_lowest_no_in_a_list
{
    class CalculateResult
    {
      
        public void getMax(List<double> grades)
        {
            var max = double.MinValue; 
            foreach(var grade in grades){
                if( max < grade)
                {
                    max = grade;
                }
            }
            Console.WriteLine("Maximum value: "+max);
        }

          public void getMin(List<double> grades)
        {
            var min = double.MaxValue; 
            foreach(var grade in grades){
                if( min > grade)
                {
                    min = grade;
                }
            }
            Console.WriteLine("Minimum value: "+min);
        }


    }


}