using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // Creating public sub-class 'Tool' : 'Item'
    public class Tool : Item
    {
        // Attributes are: 'Min Damage', 'Max Damage'
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public Tool(int id, string name, string namePlural, int minDamage, int maxDamage) : base(id, name, namePlural)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }
    }
}
