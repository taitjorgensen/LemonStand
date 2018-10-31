﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class Pitcher
    {
        public double price;
        private int lemonsUsed;
        private int sugarUsed;
        private int iceUsed;
        private int cupsPerPitcher = 10;
        public void AdjustInventory(Player player, Inventory inventory, Recipe recipe)
        {

            lemonsUsed = recipe.lemonsPerPitcher;
            sugarUsed = recipe.cupsOfSugarPerPitcher;
            iceUsed = recipe.cubesOfIcePerPitcher;
            inventory.AdjustLemonInventory(lemonsUsed);
            inventory.AdjustSugarInventory(sugarUsed);
            inventory.AdjustIceInventory(iceUsed);
            inventory.ViewInventory();

        }
        public double SetPrice()
        {
            Console.WriteLine("How much will you charge per cup of lemonade?");
            price = double.Parse(Console.ReadLine());
            if (price > 2.00 || price < .30)
            {
                Console.WriteLine("This is out of line with current market conditions. Please set a different price.");
            }
            return price;
        }
    }
}
