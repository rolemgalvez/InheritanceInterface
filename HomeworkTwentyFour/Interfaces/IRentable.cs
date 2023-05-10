using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkTwentyFour.Interfaces
{
    interface IRentable : IInventoryItem
    {
        void Rent();
        void ReturnRental();
    }
}
