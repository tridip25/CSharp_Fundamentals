using System;
using System.Collections.Generic;

namespace prog_that_illstrate_clas_obj
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>(){7.69, 8.67 , 8.54 , 6.96 , 8.00 , 6.96 , 8.42};
            var obj = new file2();
            obj.getStatistics(grades);
        }
    }
}
