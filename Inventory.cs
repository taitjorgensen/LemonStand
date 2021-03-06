﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class Inventory
    {
        //member variables
        
        private int cupsOfSugar = 0;
        private int cubesOfIce = 0;
        private int lemons = 0;
        private int cups = 0;
        public int sugarPurchased = 0;
        public int icePurchased = 0;
        public int lemonsPurchased = 0;
        public int cupsPurchased = 0;
        private double income;
        public int CupsOfSugar
        {
            get => cupsOfSugar;
            set => cupsOfSugar = value;
        }
        public int Lemons
        {
            get => lemons;
            set => lemons = value;
        }
        public int CubesOfIce
        {
            get => cubesOfIce;
            set => cubesOfIce = value;
        }
        public int Cups
        {
            get => cups;
            set => cups = value;
        }

        //constructor


        //member methods
        public double UpdateCurrentFunds(Player player, Store store, Day newDay)
        {
            store.TotalPurchases(player);
            player.currentFunds = (player.currentFunds - store.purchases + income);
            Console.WriteLine("You now have $" + player.currentFunds + ".");
            return player.currentFunds;
        }



        public void PurchaseInventory(Player player, Store store, Day newDay)
        {
            PurchaseLemons();
            PurchaseCupsOfSugar();
            PurchaseCubesOfIce();
            PurchaseCups();
            Console.Clear();
            lemons = lemons + lemonsPurchased;
            cupsOfSugar = cupsOfSugar + sugarPurchased;
            cubesOfIce = cubesOfIce + icePurchased;
            cups = cups + cupsPurchased;
            UpdateCurrentFunds(player, store, newDay);
            ViewInventory();
        }

        int PurchaseLemons()
        {
            Console.WriteLine("Each Lemon costs $0.40.");
            Console.WriteLine("How many Lemons do you want to purchase?");
            try
            {
                lemonsPurchased = int.Parse(Console.ReadLine());
            }
            catch
            {
                PurchaseLemons();
            }

            return lemonsPurchased;
        }
        int PurchaseCupsOfSugar()
        {
            Console.WriteLine("Each Cup of Sugar costs $0.10.");
            Console.WriteLine("How many Cups of Sugar do you want to purchase?");
            try
            {
                sugarPurchased = int.Parse(Console.ReadLine());
            }
            catch
            {
                PurchaseCupsOfSugar();
            }
            return sugarPurchased;
        }
        int PurchaseCubesOfIce()
        {
            Console.WriteLine("Each Cube of Ice costs $0.01.");
            Console.WriteLine("How many Cubes of Ice do you want to purchase?");
            try
            {
                icePurchased = int.Parse(Console.ReadLine());
            }
            catch
            {
                PurchaseCubesOfIce();
            }

            return icePurchased;
        }
        int PurchaseCups()
        {
            Console.WriteLine("Each Cup costs $0.05.");
            Console.WriteLine("How many Cups do you want to purchase?");
            try
            {
                cupsPurchased = int.Parse(Console.ReadLine());
            }
            catch
            {
                PurchaseCups();
            }
            return cupsPurchased;
        }

        public int AdjustInventory(Player player, int lemonsUsed, int sugarUsed, int iceUsed)
        {
            if (((lemons - lemonsUsed) < 0) || ((cupsOfSugar - sugarUsed) < 0) || ((cubesOfIce - iceUsed) < 0))
            {
                Console.WriteLine("You do not have enough inventory to make that much! You'll need to adjust the number of pitchers to make");
                Console.ReadLine();
                player.MakePitchers(player);
            }
            lemons = lemons - lemonsUsed;
            cupsOfSugar = cupsOfSugar - sugarUsed;
            cubesOfIce = cubesOfIce - iceUsed;
            return lemons + cupsOfSugar + cubesOfIce;
        }
        //public int AdjustSugarInventory(Player player, int sugarUsed)
        //{
        //    if ((cupsOfSugar - sugarUsed) < 0)
        //    {
        //        Console.WriteLine("You are out of sugar! You'll need to adjust the number of pitchers to make.");
        //        Console.ReadLine();
        //        player.MakePitchers(player);
        //    }
        //    return cupsOfSugar = cupsOfSugar - sugarUsed;
        //}
        //public int AdjustIceInventory(Player player, int iceUsed)
        //{
        //    if ((cubesOfIce - iceUsed) < 0)
        //    {
        //        Console.WriteLine("You are out of ice! You'll need to adjust the number of pitchers to make.");
        //        Console.ReadLine();
        //        player.MakePitchers(player);
        //    }
        //    return cubesOfIce = cubesOfIce - iceUsed;
        //}
        public int AdjustCupsInventory(int cupsSold)
        {
            return cups = cups - cupsSold;
        }
        public void ViewInventory()
        {
            Console.WriteLine("Current inventory is: ");
            Console.WriteLine("Lemons: " + lemons);
            Console.WriteLine("Cups of Sugar: " + cupsOfSugar);
            Console.WriteLine("Ice cubes: " + cubesOfIce);
            Console.WriteLine("Cups: " + cups);
            Console.ReadLine();

        }

    }
}
