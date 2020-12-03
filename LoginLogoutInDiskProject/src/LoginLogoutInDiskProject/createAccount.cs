using System;
using System.IO;

namespace LoginLogoutInDiskProject
{
    public class createAccount
    {
        public void storeAccountDetails(string id , string password)
        {
            var details = new AccountDetails();
            details.Id = id;
            details.password = password;

            string text = details.Id+"\n"+details.password;
           using(var writer = File.AppendText("AccountDetails.txt"))
              {
                  writer.WriteLine(text);
              }
              
           
        }
    }
}