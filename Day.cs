using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        //variables

        public Weather weather;
        public List<Customer> customers;
        public List<string> daysOfWeek;


        //ctor 
        public Day()
        {
            customers = new List<Customer>();
            weather = new Weather();
            GenerateCustomers();
            Customer dailyCustomers = new Customer(); // this will take you to the MakeChoice() How to connect make choice with the generated customers?
            //print the EOD
            //print running total for week
            



            daysOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        }

        private void GenerateCustomers()
        {
            Random rnd = new Random();
            int amountOfCustomer = 0;
            //TODO finish switch case
            switch (weather.condition)
            {
                case "Sunny":
                    amountOfCustomer = rnd.Next(50, 100);
                    break;

                case "Cloudy":
                    amountOfCustomer = rnd.Next(30, 60);
                    break;

                case "Rainy":
                    amountOfCustomer = rnd.Next(1, 30);
                    break;
            }

            for(int i = 0; i < amountOfCustomer; i++) // this is how you add as many customers as you need a day... hundreds
            {
                customers.Add(new Customer());
            }
        }
        
    }
}
