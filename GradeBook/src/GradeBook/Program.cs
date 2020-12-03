using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {


            IBook book = new DiskBook("Scott's Grade Book"); //to store in a file make an object of diskbook else if inmemory
                                                            // make inmemory object

                                                
            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);

            // book.AddGrade(7.69);
            // book.AddGrade(8.67);
            // book.AddGrade(8.54);

            var res = book.GetStatistics();

           // book.Name = "mere bere";
            //Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"Average is {res.Average}\nHighest is {res.High} \nLowest is {res.Low}");

            Console.WriteLine($"Letter grade is {res.Letter}");

        }








        private static void EnterGrades(IBook book)
        {
           // book.
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit ");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    // throw; you can rethrow
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }

    }
}