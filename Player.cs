using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class Player
    {
        public Recipe recipe = new Recipe();
        public Inventory inventory = new Inventory();
        public double price = 0;
        public int pitchersMade = 0;
        public List<Pitcher> pitchers;
        public double currentFunds = 20;

        public void SetUp(Player player, Store store, Day newDay)
        {
            newDay.weather.GetWeatherForecast();
            inventory.PurchaseInventory(player, store, newDay);
            recipe.SetRecipe(player, store, newDay);            
            pitchers = MakePitchers(player);
            inventory.ViewInventory();
            SetPrice();

        }
        public double SetPrice()
        {
            Console.WriteLine("How much will you charge per cup of lemonade?");
            try
            {
                price = double.Parse(Console.ReadLine());
            }
            catch
            {
                SetPrice();
            }
            
            if (price > 2.00 || price < .30)
            {
                Console.WriteLine("This is out of line with current market conditions. Please set a different price.");
                SetPrice();
            }
            return price;
        }
        public List<Pitcher> MakePitchers(Player player)
        {
            Console.WriteLine("How many Pitchers will you make?");
            try
            {
                pitchersMade = int.Parse(Console.ReadLine());
            }
            catch
            {
                MakePitchers(player);
            }
            
            List<Pitcher> dailyPitchers = new List<Pitcher>();
            for (int i = 0; i < pitchersMade; i++)
            {
                Pitcher pitcher = new Pitcher();
                pitcher.AdjustInventory(player, inventory, recipe);
                dailyPitchers.Add(pitcher);
            }
            return dailyPitchers;
        }

    }
}
