using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputMoney = Console.ReadLine();

            double moneyInserted = 0;
            while (inputMoney != "Start")
            {
                double money = double.Parse(inputMoney);
                if (money == 0.1 || money == 0.2 || money == 0.5 || money == 1 || money == 2)
                {
                    moneyInserted += money;
                }
                else
                {
                    //moneyInserted -= money;
                    Console.WriteLine($"Cannot accept {money}");
                }

                inputMoney = Console.ReadLine();

            }

            string product = Console.ReadLine();

            double priceProducts = 0;
            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        priceProducts = 2;
                        break;
                    case "Water":
                        priceProducts = 0.7;
                        break;
                    case "Crisps":
                        priceProducts = 1.5;
                        break;
                    case "Soda":
                        priceProducts = 0.8;
                        break;
                    case "Coke":
                        priceProducts = 1;
                        break;
                    default:
                        Console.WriteLine($"Invalid product");
                        break;
                }


                if (product == "Nuts" || product == "Water" || product == "Crisps" || product == "Soda" || product == "Coke")
                {
                    moneyInserted -= priceProducts;
                    if (moneyInserted < 0)
                    {
                        Console.WriteLine($"Sorry, not enough money");
                        moneyInserted += priceProducts;
                    }
                    else
                    {
                        product = product.ToLower();
                        Console.WriteLine($"Purchased {product}");
                    }
                }
                


               







                product = Console.ReadLine();
            }
            if (product == "End")
            {
                Console.WriteLine($"Change: {moneyInserted:f2}");
            }
        }
    }
}
