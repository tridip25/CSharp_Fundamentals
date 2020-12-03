using System;

namespace ex_delegate
{
    class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
            
            var userDetail = new getDetailsFromUserInput();
            var addDetail = new addCustomerDetails();

            addDetail.deleCount += displayAndCount;

            Console.WriteLine("Enter how many details you would like to enter: ");
            var input =  Console.ReadLine();
            var total = int.Parse(input);

            for(var i=0; i < total;i++)
            {
                var detail = userDetail.getUserInputDetails();
                addDetail.addDetails(detail);
            }

            addDetail.diplayDetail();

            var sender = "";
            EventArgs p1 = new EventArgs();
            int p= displayAndCount(sender, p1);
            Console.WriteLine($"Total details entered : {p}");
            
        }

        static public int displayAndCount(object sender, EventArgs args)
        {
            count += 1;
            Console.WriteLine("Details has been added");
            return count;
        }

    }
}
