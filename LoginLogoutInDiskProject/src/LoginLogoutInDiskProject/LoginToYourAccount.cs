using System;
using System.IO;

namespace LoginLogoutInDiskProject
{
    class LoginToYourAccount
    {
        public void LoginAndDisplayMessage(string id , string password)
        {
            using(var reader = File.OpenText("AccountDetails.txt"))
            {
              // var line = reader.ReadLine();
               var line = "";
            while(line != null)
               {
    
                    if(line.Equals(id))
                    {
                        if(reader.ReadLine().Equals(password))
                        {
                            Console.WriteLine("Congrats !!! You have successfully logged in");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Credentials!!!!!!!!!!!!!!!!!!");
                        }

                       
                    }

                   line = reader.ReadLine();
    
               }

            }
        }
    }
}