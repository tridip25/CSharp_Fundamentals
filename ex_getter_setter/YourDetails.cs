using System;
namespace ex_getter_setter
{
    class YourDetails
    {
        private string name;
        private int roll;

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

         public int getRoll()
        {
            return this.roll;
        }
        public void setRoll(int roll)
        {
            this.roll = roll;
        }
    }
}