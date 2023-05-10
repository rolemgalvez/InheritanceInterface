using HomeworkTwentyFour.Interfaces;
using System;

namespace HomeworkTwentyFour.Models
{
    public class VehicleModel : InventoryItemModel, IPurchasable, IRentable
    {
        public decimal DealerFee { get; set; }

        public void Purchase()
        {
            QuantityStock -= 1;
            Console.WriteLine("Vehicle purchase successful.");
        }

        public void Rent()
        {
            QuantityStock -= 1;
            Console.WriteLine("Vehicle rent successful.");
        }

        public void ReturnRental()
        {
            QuantityStock += 1;
            Console.WriteLine("Vehicle return successful.");
        }
    }
}
