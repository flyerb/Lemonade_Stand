using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        private Player player;
        private List<Day> days;
        private int currentDay;
        private Store store;
        public Day day;
        public Weather weather;

        //methods
         
        public void RunGame()
        {
            Weather todaysWeather = new Weather();
            todaysWeather.Forecast();
            //printing weather forecast for tomorrow and today
           
            
            //printing how many ingredients/ money we have
            //asking if we want to go to the store
            GoToTheStore(player);
            Day test = new Day();
            
            
            
        }


        //buy ingredients 
        public void GoToTheStore(Player player)
        {
            Console.WriteLine("What would you like to buy?\n Ice Cubes\n Lemons\n Sugar\n Cups\n");

            string userInput = Console.ReadLine();

            if (userInput == "Ice Cubes") 
            {
                store.SellIceCubes(player);
            }
            else if (userInput == "Lemons")
            {
                store.SellLemons(player);
            }
            else if (userInput == "Sugar")
            {
                store.SellSugarCubes(player);
            }
            else if (userInput == "Cups")
            {
                store.SellCups(player);
            }

        }
    

    }
}
