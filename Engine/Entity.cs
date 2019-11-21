using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    // Creating public class 'Entity' to describe players, enemies, etc.
    public class Entity
    {
        public int maxHP;
        public int currentHP;
        public string color;

        // Shared attributes are: 'MaxHP' and 'CurrentHP'
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public string Color { get; set; }

        public Entity(string Color, int CurrentHP, int MaxHP)
        {
            CurrentHP = currentHP;
            MaxHP = maxHP;
            Color = color;
        }
    }
}
