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

        //methods
         
        public void RunGame()
        {
            Day test = new Day();
            
            GoToTheStore(player);
            
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
