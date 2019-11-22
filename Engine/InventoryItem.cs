using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // Creating public class 'InventoryItem'
    public class InventoryItem
    {
        // Attributes are: 'Details', and 'Quantity'
        public Item Details { get; set; }
        public int Quantity { get; set; }

        public InventoryItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}