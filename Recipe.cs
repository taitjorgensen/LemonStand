using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class Recipe
    {
        Inventory inventory;
        public int lemonsPerPitcher = 0;
        public int cupsOfSugarPerPitcher = 0;
        private int cubesOfIcePerPitcher = 0;
        private int cupsPerPitcher = 8;
        private int pitchersMade = 0;
        public int lemonsUsed;
        private int sugarUsed;
        private int iceUsed;


        private List<string> recipe;



        public void SetRecipe()
        {
            SetLemonsPerPitcher();
            SetSugarPerPitcher();
            SetIcePerPitcher();
            void SetLemonsPerPitcher()
            {
                Console.WriteLine("Your recipe creates a pitcher that will yeild 8 cups of lemonade.");
                Console.WriteLine("How many lemons will you use per pitcher?");
                lemonsPerPitcher = int.Parse(Console.ReadLine());
                if (lemonsPerPitcher < 5)
                {
                    Console.WriteLine("You want people to drink lemon water? You need more lemons.");
                    Console.ReadLine();
                    SetLemonsPerPitcher();
                }
                else if (lemonsPerPitcher > 20)
                {
                    Console.WriteLine("Don't over do it with the lemon! You still want to make some money.");
                    Console.ReadLine();
                    SetLemonsPerPitcher();
                }
            }
            void SetSugarPerPitcher()
            {
                Console.WriteLine("How many Cups of Sugar will you use per pitcher?");
                cupsOfSugarPerPitcher = int.Parse(Console.ReadLine());
                if (cupsOfSugarPerPitcher < 2)
                {
                    Console.WriteLine("Are you making sour juice? Your customers will need more sweet than that!");
                    Console.ReadLine();
                    SetSugarPerPitcher();
                }
                else if (cupsOfSugarPerPitcher > 10)
                {
                    Console.WriteLine("WOW! Do you have a deal with the local dentist? Back it down a bit, please.");
                    Console.ReadLine();
                    SetSugarPerPitcher();
                }
            }
            void SetIcePerPitcher()
            {
                Console.WriteLine("How many Cubes of Ice will you use per pitcher?");
                cubesOfIcePerPitcher = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("How many Pitchers will you make?");
            pitchersMade = int.Parse(Console.ReadLine());
            lemonsUsed = lemonsPerPitcher * pitchersMade;
            sugarUsed = cupsOfSugarPerPitcher * pitchersMade;
            iceUsed = cubesOfIcePerPitcher * pitchersMade;
            inventory.AdjustLemonInventory(lemonsUsed);
            inventory.AdjustSugarInventory(sugarUsed);
            inventory.AdjustIceInventory(iceUsed);
            inventory.ViewInventory();

        }
    }
}
