using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe
    {
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;


        //methods

        public void CupPrice() //dont use numbers- come back to this
        {
            Random rnd = new Random();
            int dailyPrice = rnd.Next(1, 5);

            if (dailyPrice <= 2)
            {
                pricePerCup = 1; //tried to use ToString 
            }
            else if (dailyPrice == 3)
            {
                pricePerCup = 2;
            }
            else if (dailyPrice >= 4)
            {
                pricePerCup = 3;
            }

        }

        public void SetRecipe()
        {
            Console.WriteLine("How many lemons would you like to use?");
            amountOfLemons = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("How many sugar cubes would you like to use?");
            amountOfSugarCubes = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("How much ice would you like to use?");
            amountOfIceCubes = Convert.ToInt32(Console.ReadLine());
            

           Console.WriteLine("How much would you like to sell a cup for?");
            pricePerCup = Convert.ToDouble(Console.ReadLine());
         
        }
    }
}
