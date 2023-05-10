using HomeworkTwentyFour.Interfaces;
using HomeworkTwentyFour.Models;
using System;
using System.Collections.Generic;

namespace HomeworkTwentyFour
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> rentables = new List<IRentable>();
            List<IPurchasable> purchasables = new List<IPurchasable>();

            var vehicle = new VehicleModel { DealerFee = 50, ProductName = "The One", QuantityStock = 10 };
            var book = new BookModel { NumberOfPages = 350, ProductName = "The Unknown Pages", QuantityStock = 100 };
            var excavator = new ExcavatorModel { ProductName = "Dive Hard", QuantityStock = 15 };

            PopulateList(rentables, purchasables, vehicle, book, excavator);
            ProcessTransaction(rentables, purchasables);

            Console.WriteLine();
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }

        private static void ProcessTransaction(List<IRentable> rentables, List<IPurchasable> purchasables)
        {
            Console.Write("Select action (rent/purchase): ");
            string decision = Console.ReadLine().ToLower();

            switch (decision)
            {
                case "rent":
                    RentalProcess(rentables);
                    break;
                case "purchase":
                    PurchaseProcess(purchasables);
                    break;
                default:
                    break;
            }
        }

        private static void PurchaseProcess(List<IPurchasable> purchasables)
        {
            foreach (var item in purchasables)
            {
                Console.WriteLine();
                Console.WriteLine($"Item: {item.ProductName}");
                Console.Write("Purchase this item (yes/no):");
                string answer = Console.ReadLine().ToLower();

                if (answer == "yes")
                {
                    item.Purchase();
                }
            }
        }

        private static void RentalProcess(List<IRentable> rentables)
        {
            foreach (var item in rentables)
            {
                Console.WriteLine();
                Console.WriteLine($"Item: {item.ProductName}");
                Console.Write("Select purpose (rent/return/discard):");
                string answer = Console.ReadLine().ToLower();

                switch (answer)
                {
                    case "rent":
                        item.Rent();
                        break;
                    case "return":
                        item.ReturnRental();
                        break;
                    default:
                        break;
                }
            }
        }

        private static void PopulateList(List<IRentable> rentables, List<IPurchasable> purchasables, VehicleModel vehicle, BookModel book, ExcavatorModel excavator)
        {
            rentables.Add(vehicle);
            rentables.Add(excavator);

            purchasables.Add(book);
            purchasables.Add(vehicle);
        }
    }
}
