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

        public void CupPrice()
        {
            Random rnd = new Random();
            int dailyPrice = rnd.Next(1, 5);

            if(dailyPrice <= 2)
            {
                pricePerCup = 1; //tried to use ToString 
            }
            else if(dailyPrice == 3)
            {
                pricePerCup = 2;
            }
            else if (dailyPrice >= 4)
            {
                pricePerCup = 3;
            }

        }
    }
}
