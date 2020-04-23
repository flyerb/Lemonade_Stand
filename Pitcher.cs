using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Pitcher
    {
        //variables
        public int cupsLeftInPitcher;
      

        //ctor
        public Pitcher()
        {
            cupsLeftInPitcher = 0;
        }

        //methods


        public void MakePitcher(Recipe recipe, Inventory inventory)
        {
            if (recipe.amountOfLemons <= inventory.lemons.Count)
            {
                inventory.lemons.RemoveRange(0, recipe.amountOfLemons);

            }
            if (recipe.amountOfSugarCubes <= inventory.sugarCubes.Count)
            {
                inventory.sugarCubes.RemoveRange(0, recipe.amountOfSugarCubes);

            }
            if (recipe.amountOfIceCubes <= inventory.iceCubes.Count)
            {
                inventory.iceCubes.RemoveRange(0, recipe.amountOfIceCubes);
                cupsLeftInPitcher = 10;

            }
            else
                Console.WriteLine("You need to got to the store for supplies.");
        }
        
    }

    




}
