using System;

namespace LoginLogoutInDiskProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var createAccountDatas = new createAccount();
            var login = new LoginToYourAccount();
            while(true)
            {
                Console.WriteLine("-----------------Select an option:------------------");
                Console.WriteLine("----------------1/ Create Account-------------------");
                Console.WriteLine("-------------------2/ Sign in-----------------------");
                var input = Console.ReadLine();
                var option = int.Parse(input);

                switch(option)
                {
                    case 1:
                        Console.WriteLine("Enter id");
                        var id = Console.ReadLine();

                        Console.WriteLine("Enter Password");
                        var password = Console.ReadLine();

                        Console.WriteLine("Confirm Password");
                        var confirmPassword = Console.ReadLine();

                        if(password.Equals(confirmPassword))
                         {
                             createAccountDatas.storeAccountDetails(id , password);
                         }


                      break;

                    case 2:
                        Console.WriteLine("Enter id");
                        var LoginId = Console.ReadLine();

                        Console.WriteLine("Enter Password");
                        var LoginPassword = Console.ReadLine();
                        
                        login.LoginAndDisplayMessage(LoginId , LoginPassword);
                        break;
                    
                    default :
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
