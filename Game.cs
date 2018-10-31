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

        public List<string> gameRules = new List<string> {  };
        public Day day = new Day();
        public Store store = new Store();
        public Player player = new Player();
        private int playDays = 7;


        // constructor


        // member methods
        
        
        public void StartGame()
        {
            gameRules.Add("As the store owner, you begin with $20.");
            gameRules.Add("Each day you will see the weather, purchase ingredients, set your recipe, and set the daily price.");
            gameRules.Add("Ingredients include, Lemons, Sugar, and Ice.");
            gameRules.Add("Cups are also required to serve, but cannot be changed.");
            gameRules.Add("Weather and price will affect the amount of lemonade sold each day.");
            gameRules.Add("Press ENTER when ready.");
            foreach (string rule in gameRules)
            {
                Console.WriteLine(rule);
            }
            Console.ReadLine();
            SetNumberOfDaysToPlay();
            int SetNumberOfDaysToPlay()
            {
                Console.WriteLine("How many days would you like to play?");
                playDays = int.Parse(Console.ReadLine());
                if (playDays > 30 || playDays < 7)
                {
                    Console.WriteLine("Please choose a number from 7 - 30.");
                    Console.ReadLine();
                    SetNumberOfDaysToPlay();
                }
                else if (playDays <= 30 && playDays >= 7)
                {
                    return playDays;
                }
                else
                {
                    SetNumberOfDaysToPlay();
                }
                return 0;
            }
            RunGame();
        }

        public void RunGame()
        {
            while (day.day < playDays)
            {
                player.SetUp(player, store, day);
                day.NewDay();
            }

        }
    }

}
