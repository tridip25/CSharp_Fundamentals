using System;

namespace ex_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new circle();
            var square = new square();
            circle.draw();
            square.draw();
        }
    }
}
