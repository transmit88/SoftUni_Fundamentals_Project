using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balans = 0;

            while (input != "Start")
            {
                double coin = double.Parse(input);

                if (coin == 0.1 ||
                    coin == 0.2 ||
                    coin == 0.5 ||
                    coin == 1 ||
                    coin == 2 )
                {
                    balans += coin;
                }

                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                double productPrice = 0;

                switch (input)
                {
                    case "Nuts":
                        productPrice = 2.0;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                
                if (balans >= productPrice && productPrice > 0)
                {
                    string productToLoler = input.ToLower();
                    Console.WriteLine($"Purchased {productToLoler}");
                    balans -= productPrice;
                }

                else if (productPrice > 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {balans:F}");
        }
    }
}
