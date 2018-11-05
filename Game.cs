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
        public Day newDay;
        public Store store = new Store();
        public Player player = new Player();
        private int playDays = 7;
        private int dayNumber = 0;
        private string playAgain;


        // constructor


        // member methods
        
        
        public void StartGame()
        {
            gameRules.Add("As the business owner, you begin with $25.");
            gameRules.Add("Each day you will see the weather, purchase ingredients from the store, set your recipe, and set the daily price.");
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
            RunGame(player, store);
            EndGame();
        }

        public void RunGame(Player player, Store store)
        {

            do
            {
                newDay = new Day();
                player.SetUp(player, store, newDay);
                newDay.NewDay(player);
                DisplayDayResults(newDay);
                dayNumber++;
            }
            while (dayNumber < playDays);


        }
        public void DisplayDayResults(Day newDay)
        {
            Console.WriteLine("You sold " + newDay.totalLemonadeSold + " cups of lemonade today.");
            Console.WriteLine("You now have $" + player.currentFunds);
            player.inventory.ViewInventory();
            Console.ReadLine();
        }
        int SetNumberOfDaysToPlay()
        {
            Console.WriteLine("How many days would you like to play?");
            try
            {
                playDays = int.Parse(Console.ReadLine());
            }
            catch
            {
                SetNumberOfDaysToPlay();
            }
            
            if (playDays > 30 || playDays < 7)
            {
                Console.WriteLine("Please choose a number from 7 - 30.");
                Console.ReadLine();
                SetNumberOfDaysToPlay();
            }
            return playDays;
        }
        private void EndGame()
        {
            Console.WriteLine("You sold " + newDay.totalLemonadeSold + " cups of lemonade!");
            Console.WriteLine("You finished with $" + player.currentFunds);
            Console.ReadLine();
            PlayAgain();
        }

        private void PlayAgain()
        {
            Console.WriteLine("Would you like to play again? y or n");
            playAgain = Console.ReadLine();
            if (playAgain == "y")
            {
                StartGame();
            }
            else if (playAgain == "n")
            {
                Console.WriteLine("Thank you for playing!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter a valid input. /'y/' or /'n/'");
                Console.ReadLine();
            }
        }
    }

}
