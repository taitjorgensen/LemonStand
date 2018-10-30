using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class Store
    {
        //member variables
        Inventory inventory;
        public int lemonsPerPitcher = 0;
        public int cupsOfSugarPerPitcher = 0;
        private int cubesOfIcePerPitcher = 0;
        private int cupsPerPitcher = 8;
        private int pitchersMade = 0;
        public int lemonsUsed;
        private int sugarUsed;
        private int iceUsed;
        public double price;

        private List<string> recipe;


        //constructor


        // member methods
        private void SetRecipe()
        {
            Console.WriteLine("Your recipe creates a pitcher that will yeild 8 cups of lemonade.");
            Console.WriteLine("How many lemons will you use per pitcher?");
            lemonsPerPitcher = int.Parse(Console.ReadLine());
            
            Console.WriteLine("How many Cups of Sugar will you use per pitcher?");
            cupsOfSugarPerPitcher = int.Parse(Console.ReadLine());
            
            Console.WriteLine("How many Cubes of Ice will you use per pitcher?");
            cubesOfIcePerPitcher = int.Parse(Console.ReadLine());
            
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
