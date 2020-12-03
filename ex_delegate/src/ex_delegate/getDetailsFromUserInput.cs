using System;

namespace ex_delegate
{
    public class getDetailsFromUserInput
    {
        public customerDetails getUserInputDetails()
        {
        
                customerDetails detail = new customerDetails();

                Console.WriteLine("Enter your Name :");
                var name =  Console.ReadLine();
               
                Console.WriteLine("Enter your Id :");
                var line =  Console.ReadLine();
                var id = int.Parse(line);

                Console.WriteLine("Enter your address :");
                var address =  Console.ReadLine();
              

                detail.Name = name;
                detail.Id = id;
                detail.Address = address;
             
                return detail;
             
        }
    }
}