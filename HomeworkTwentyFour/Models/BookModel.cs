using HomeworkTwentyFour.Interfaces;
using System;

namespace HomeworkTwentyFour.Models
{
    public class BookModel : InventoryItemModel, IPurchasable
    {
        public int NumberOfPages { get; set; }

        public void Purchase()
        {
            QuantityStock -= 1;
            Console.WriteLine("Book purchase successful.");
        }
    }
}
