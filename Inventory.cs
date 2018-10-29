using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class Inventory
    {
        //member variables
        Store store;
        private int cupsOfSugar = 0;
        private int cubesOfIce = 0;
        private int lemons = 0;
        private int cups = 0;
        private int sugarPurchased = 0;
        private int icePurchased = 0;
        private int lemonsPurchased = 0;
        private int cupsPurchased = 0;
        private double costOfSugar;
        private double costOfIce;
        private double costOfLemons;
        private double costOfCups;
        private double currentFunds = 20.00;
        private double purchases;
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
        private double UpdateCurrentFunds()
        {
            TotalPurchases();
            currentFunds = (currentFunds - purchases + income);
            Console.WriteLine("You now have $" + currentFunds + ".");
            return currentFunds;
        }
        private void DetermineCosts()
        {
            DetermineCostOfCups();
            DetermineCostOfIce();
            DetermineCostOfLemons();
            DetermineCostOfSugar();
            double DetermineCostOfCups()
            {
                return costOfCups = (cupsPurchased * .05);
            }
            double DetermineCostOfIce()
            {
                return costOfIce = (icePurchased * .01);
            }
            double DetermineCostOfLemons()
            {
                return costOfLemons = (lemonsPurchased * .40);
            }
            double DetermineCostOfSugar()
            {
                return costOfSugar = (sugarPurchased * .10);
            }
        }
        private double TotalPurchases()
        {
            DetermineCosts();
            return purchases = (costOfCups + costOfIce + costOfLemons + costOfSugar);
        }


        public void PurchaseInventory()
        {
            PurchaseCupsOfSugar();
            PurchaseCubesOfIce();
            PurchaseLemons();
            PurchaseCups();
            int PurchaseCupsOfSugar()
            {
                Console.WriteLine("Each Cup of Sugar costs $0.10.");
                Console.WriteLine("How many Cups of Sugar do you want to purchase?");
                sugarPurchased = int.Parse(Console.ReadLine());
                return sugarPurchased;
            }
            int PurchaseCubesOfIce()
            {
                Console.WriteLine("Each Cube of Ice costs $0.01.");
                Console.WriteLine("How many Cubes of Ice do you want to purchase?");
                icePurchased = int.Parse(Console.ReadLine());      
                return icePurchased;
            }
            int PurchaseLemons()
            {
                Console.WriteLine("Each Lemon costs $0.40.");
                Console.WriteLine("How many Lemons do you want to purchase?");
                lemonsPurchased = int.Parse(Console.ReadLine());
                return lemonsPurchased;
            }
            int PurchaseCups()
            {
                Console.WriteLine("Each Cup costs $0.05.");
                Console.WriteLine("How many Cups do you want to purchase?");
                cupsPurchased = int.Parse(Console.ReadLine());
                return cupsPurchased;
            }
            lemons = lemons + lemonsPurchased;
            cupsOfSugar = cupsOfSugar + sugarPurchased;
            cubesOfIce = cubesOfIce + icePurchased;
            cups = cups + cupsPurchased;
            UpdateCurrentFunds();
            ViewInventory();
        }

        public int AdjustLemonInventory(int lemonsUsed)
        {
            return lemons = lemons - lemonsUsed;
        }
        public int AdjustSugarInventory(int sugarUsed)
        {
            return cupsOfSugar = cupsOfSugar - sugarUsed;
        }
        public int AdjustIceInventory(int iceUsed)
        {
            return cubesOfIce = cubesOfIce - iceUsed;
        }
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
