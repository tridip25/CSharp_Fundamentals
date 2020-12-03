using System;

namespace ex_polymorphism
{
    public abstract class poly
    {
        public abstract void draw();
    }

    public class circle : poly
    {
        public override void draw()
        {
            Console.WriteLine("Drawing a circle !!!");
        }
    }

    public class square : poly
    {
        public override void draw()
        {
            Console.WriteLine("Drawing a square !!!");
        }
    }
}