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
        Inventory inventory;

        //ctor
        public Pitcher()
        {
            Inventory inventory = new Inventory();
        }

        //methods


        public void CurrentPitcher()
        {
            do
            {
                cupsLeftInPitcher--;
            }
            while (cupsLeftInPitcher > 11);
            
                    //if (cupsLeftInPitcher > 0)
            //{

            //    for (int i = 0; i < 11; i++)
            //    {
            //        cupsLeftInPitcher = i;
            //        Console.WriteLine("There are" + cupsLeftInPitcher + "cups left in this pitcher.");
            //    }
            //}
            //else
            //    MakeAPitcher();
            
        }
      
    }

    




}
