using System;

namespace my_doubt_clr
{
    class Program
    {
        static void Main(string[] args)
        {
            Program2 k = new Program2();
            var m = k.getName();
            Console.WriteLine(m.Name);

        }
    }
}
