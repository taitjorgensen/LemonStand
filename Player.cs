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

        public void SetUp(Player player, Store store, Day day)
        {
            inventory.PurchaseInventory(player, store, day);
            recipe.SetRecipe(player, store, day);
            day.weather.GetWeatherForecast();
            Console.WriteLine("How many Pitchers will you make?");
            pitchersMade = int.Parse(Console.ReadLine());
            for (int i = 0; i < pitchersMade; i++)
            {
                Pitcher pitcher = new Pitcher();
                pitcher.AdjustInventory(player, inventory, recipe);
            }
            inventory.ViewInventory();
            SetPrice();

        }
        public double SetPrice()
        {
            Console.WriteLine("How much will you charge per cup of lemonade?");
            price = double.Parse(Console.ReadLine());
            if (price > 2.00 || price < .30)
            {
                Console.WriteLine("This is out of line with current market conditions. Please set a different price.");
                SetPrice();
            }
            return price;
        }

    }
}
