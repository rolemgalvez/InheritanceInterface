using HomeworkTwentyFour.Interfaces;

namespace HomeworkTwentyFour.Models
{
    public class InventoryItemModel : IInventoryItem
    {
        public string ProductName { get; set; }
        public int QuantityStock { get; set; }
    }
}
