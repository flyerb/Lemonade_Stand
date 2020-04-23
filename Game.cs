using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        //variables

        private Player player;
        public List<Day> days;
        private int currentDay;
        private Store store;
        public Day day;
        public Weather weather;
        Random rnd;

        //ctor
        public Game()
        {
            player = new Player();
            rnd = new Random();
            days = new List<Day>();
            store = new Store();
            DaysOfTheWeek();
            
            
        }

        //methods
        public void RunGame()
        {
            foreach (Day day in days)
            {
                Menu(day);
            }
        }

        public void Menu(Day day)
        {

            Console.WriteLine("Please select what you would like to do.\n1) Go to Store\n2) Check Inventory\n3) Set Recipe\n4) Start Day\n5) Check Forecast\n 6) Exit Game");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    GoToTheStore();
                    break;
                case "2":
                    player.inventory.DisplayInventory();
                    break;
                case "3":
                    player.recipe.SetRecipe();
                    break;
                case "4":
                    day.SimulateDay(player);
                  
                    break;
                case "5":
                    Forecast();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Menu(day);
                    break;
            }
        }

        public void DaysOfTheWeek()
        {
            for(int i= 0; i <7; i++)
            {
                days.Add(new Day(rnd));
            }
        }

        

        public void Forecast()
        {
            foreach (Day day in days)
            {
                Console.WriteLine("The forecast for this day is " + day.weather.temperature + " " + day.weather.condition);
            }
        }

        
        public void GoToTheStore()
        {
            Console.WriteLine("What would you like to buy?\n Ice Cubes\n Lemons\n Sugar\n Cups\n Leave Store");

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
            else if (userInput == "Leave Store")
            {
                  
            }
            else
            {
                GoToTheStore();
            }
        }
    

    }
}
