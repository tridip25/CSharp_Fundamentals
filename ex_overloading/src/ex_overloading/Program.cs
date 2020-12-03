using System;


namespace ex_method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
           var obj = new File();
           obj.calculate(6,7);
           obj.calculate(6,7,8);
        }
    }
}
