using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // Creating public sub-class 'Loot Item'
    public class LootItem
    {
        // Attributes are: 'Details', 'Drop Percentage', and 'Is Default Item'
        public Item Details { get; set; }
        public int DropPercentage { get; set; }
        public bool IsDefaultItem { get; set; }

        public LootItem(Item details, int dropPercentage, bool isDefaultItem)
        {
            Details = details;
            DropPercentage = dropPercentage;
            IsDefaultItem = isDefaultItem;
        }
    }
}