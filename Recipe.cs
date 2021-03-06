﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class Recipe
    {
        //Inventory inventory;
        
        public int lemonsPerPitcher = 0;
        public int cupsOfSugarPerPitcher = 0;
        public int cubesOfIcePerPitcher = 0;
        public string recipeBalance;


        private List<string> recipe;



        public void SetRecipe(Player player, Store store, Day newDay)
        {
            SetLemonsPerPitcher();
            SetSugarPerPitcher();
            SetIcePerPitcher();      
            CheckSweetness();
        }

        void SetLemonsPerPitcher()
        {
            Console.WriteLine("Your recipe creates a pitcher that will yeild 10 cups of lemonade.");
            Console.WriteLine("How many lemons will you use per pitcher?");
            try
            {
                lemonsPerPitcher = int.Parse(Console.ReadLine());
            }
            catch
            {
                SetLemonsPerPitcher();
            }
            
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
            try
            {
                cupsOfSugarPerPitcher = int.Parse(Console.ReadLine());
            }
            catch
            {
                SetSugarPerPitcher();
            }
            
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
            Console.WriteLine("How many cubes of ice will you use per pitcher?");
            try
            {
                cubesOfIcePerPitcher = int.Parse(Console.ReadLine());
            }
            catch
            {
                SetIcePerPitcher();
            }
            
        }

        public string CheckSweetness()
        {
            if (lemonsPerPitcher == (cupsOfSugarPerPitcher - 1))
            {
                return recipeBalance = "balanced";
            }
            else if (lemonsPerPitcher <= cupsOfSugarPerPitcher)
            {
                return recipeBalance = "sweet";
            }
            else
            {
                return recipeBalance = "sour";
            }
        }
    }
}
