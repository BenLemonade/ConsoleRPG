using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Engine
{
    // Creating public class 'Player' : 'Entity'
    public class Player : Entity
    {
        // Attributes are: 'Moolah', 'EXP', 'LVL', and 'Inventory'
        public int Moolah { get; set; }
        public int EXP { get; set; }
        public int LVL { get; set; }
        public List<InventoryItem> Inventory { get; set; }

        public Player(string color, int currentHP, int maxHP, int moolah, int exp, int lvl) : base(color, currentHP, maxHP)
        {
            Moolah = moolah;
            EXP = exp;
            LVL = lvl;

            Inventory = new List<InventoryItem>();
        }
    }
}
