using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Tool : Item
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Tool(int id, string name, string namePlural, int minimumDamage, int maximumDamage) : base(id, name, namePlural)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
    }
}
