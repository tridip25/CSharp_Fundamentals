using System;

namespace ex_getter_setter
{
    class Program
    {
        static void Main(string[] args)
        {
           var details = new YourDetails();
           details.setName("Tridip Sharma");
           details.setRoll(126);
           var name = details.getName();
           var roll = details.getRoll();

            Console.WriteLine($"Name : {name}\nRoll : {roll}");
        }
    }
}
