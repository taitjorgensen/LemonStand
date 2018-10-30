using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class Game
    {
        // member variables
        
        private List<string> gameRules = new List<string> { "As the store owner, you begin with $20.", "Each day you will see the weather, purchase ingredients, set your recipe, and set the daily price.", "Ingredients include, Lemons, Sugar, and Ice.", "Cups are also required to serve, but cannot be changed.", "Weather and price will affect the amount of lemonade sold each day.", "Press ENTER when ready." };
        Day day = new Day();
        Store store = new Store();
        Player player = new Player();



        // constructor


        // member methods
        public void StartGame()
        {
            foreach (string rule in gameRules)
            {
                Console.WriteLine(rule);
            }
            Console.ReadLine();
            RunGame();
        }

        public void RunGame()
        {

            //Weather.GetWeather();
            player.SetUp();
            day.NewDay();
            //Store SetRecipe();
            //Store SetPrice();


        }
    }

}
