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
        public Inventory inventory;
        public string priceVariable;

        public Recipe()
        {
            Inventory inventory = new Inventory();
        }

        //methods

        public void CupPrice()
        {

            if (pricePerCup <= 2)
            {
                priceVariable = "cheap";
            }
            else if (pricePerCup == 3)
            {

                priceVariable = "marketValue";
            }
            else
            {

                priceVariable = "tooHigh";
            }
            

        }

        public void SetRecipe()
        {
            Console.WriteLine("How many lemons would you like to use for a pitcher?");
            amountOfLemons = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many sugar cubes would you like to use for a pitcher?");
            amountOfSugarCubes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How much ice would you like to use for a pitcher?");
            amountOfIceCubes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How much would you like to sell a cup for?");
            pricePerCup = Convert.ToDouble(Console.ReadLine());
            
        }
    }
}
