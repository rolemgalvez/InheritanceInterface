using HomeworkTwentyFour.Interfaces;
using System;

namespace HomeworkTwentyFour.Models
{
    public class ExcavatorModel : InventoryItemModel, IRentable
    {
        public void Dig()
        {
            Console.WriteLine("Digging with Excavator!");
        }

        public void Rent()
        {
            QuantityStock -= 1;
            Console.WriteLine("Excavator rent successful.");
        }

        public void ReturnRental()
        {
            QuantityStock += 1;
            Console.WriteLine("Excavator return successful.");
        }
    }
}
