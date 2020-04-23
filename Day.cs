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
        


        //ctor 
        public Day(Random rnd)
        {
            customers = new List<Customer>();
            weather = new Weather(rnd);
            GenerateCustomers();
            Customer dailyCustomers = new Customer(); 
            //print the EOD
            //print running total for week
            
        }
       

        private void GenerateCustomers()
        {
            Random rnd = new Random();
            int amountOfCustomer = 0;
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
        public void SimulateDay(Player player)
        {
            foreach(Customer customer in customers)
            {
                if(player.pitcher.cupsLeftInPitcher == 0)
                {
                    player.pitcher.MakePitcher(player.recipe, player.inventory);
                }
                //Insert a break here if no inventory is left
                
                
                bool decsion = customer.MakeChoice(weather, player.recipe);
                if( decsion == true)
                {
                    player.pitcher.cupsLeftInPitcher--;
                    player.wallet.Money += player.recipe.pricePerCup;
                }
            }
        }

    }
}
