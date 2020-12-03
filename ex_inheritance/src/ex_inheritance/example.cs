using System;


//Below given example is of inheritance and constructor chaining.......
namespace ex_inheritance
{

    public class example
    {
        //private string name;
        //constructor....
        public example(string name)
        {
            Name = name;
        }

        //getter setter....
        public string Name{get;set;}
    }

    public class example_derived : example
    {
        public example_derived(string name): base(name){
          //  Name = name;
          Console.WriteLine(Name);
        }
    }

}