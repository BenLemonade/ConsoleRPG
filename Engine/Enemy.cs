using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // Creating public sub-class 'Enemy' : 'Entity'
    public class Enemy : Entity
    {
        // Attributes are: 'ID', 'Name', 'Max Damage', 'Reward EXP', 'Reward Moolah', and 'Loot Item'
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxDamage { get; set; }
        public int RewardEXP { get; set; }
        public int RewardMoolah { get; set; }
        public List<LootItem> LootTable { get; set; }

        public Enemy(string color, int id, string name, int maxDamage, int rewardEXP, int rewardMoolah, int currentHP, int maxHP) : base(color, currentHP, maxHP)
        {
            ID = id;
            Name = name;
            MaxDamage = maxDamage;
            RewardEXP = rewardEXP;
            RewardMoolah = rewardMoolah;
            LootTable = new List<LootItem>();
        }
    }
}