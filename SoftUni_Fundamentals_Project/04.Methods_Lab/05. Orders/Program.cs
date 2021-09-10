using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double productQuantity = double.Parse(Console.ReadLine());

            PrintResult(product, productQuantity);

        }

        private static void PrintResult(string product, double productQuantity)
        {
            double totalPrice = 0;

            if (product == "coffee")
            {
                totalPrice = productQuantity * 1.50;
            }

            else if (product == "water")
            {
                totalPrice = productQuantity * 1.00;
            }

            else if (product == "coke")
            {
                totalPrice = productQuantity * 1.40;
            }

            else if (product == "snacks")
            {
                totalPrice = productQuantity * 2.00;
            }

            Console.WriteLine($"{totalPrice:F2}");
        }


//        using System;

//namespace _05._Orders
//    {
//        class Program
//        {
//            static void Main(string[] args)
//            {
//                string product = Console.ReadLine();
//                double productPrice = double.Parse(Console.ReadLine());

//                FinalPrice(product, productPrice);
//            }

//            private static void FinalPrice(string product, double productPrice)
//            {
//                double result = 0;
//                switch (product)
//                {
//                    case "coffee":
//                        result = productPrice * 1.50;
//                        break;
//                    case "water":
//                        result = productPrice * 1.00;
//                        break;
//                    case "coke":
//                        result = productPrice * 1.40;
//                        break;
//                    case "snacks":
//                        result = productPrice * 2.00;
//                        break;
//                    default:
//                        break;
//                }
//                Console.WriteLine($"{result:F2}");
//            }
//        }
//    }

}
}
