using System;
using System.Collections.Generic;

namespace ex_delegate
{
    public class addCustomerDetails
    {
        public delegate int GetCountDelegate(object sender, EventArgs args);
        List<customerDetails> details = new List<customerDetails>();


         public event  GetCountDelegate deleCount;
       
        public void addDetails(customerDetails detail)
        {
            
            details.Add(new customerDetails(){Name = detail.Name , Id = detail.Id , Address = detail.Address});
            deleCount(this,new EventArgs());
        }

        public void diplayDetail()
        {
            Console.WriteLine("The details provided are as follows: ");
            foreach(var detail in details)
            {
                Console.WriteLine(detail.Name + "  " +detail.Id + "  " + detail.Address);
            }
        }
    }
}