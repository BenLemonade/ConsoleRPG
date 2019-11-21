using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Item ItemRequiredToEnter { get; set; }
        public Enemy EnemyLivingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }

        public Location(int id,int sizeX, int sizeY, string name, string description, Item itemRequiredToEnter = null, Enemy enemyLivingHere = null)
        {
            ID = id;
            SizeX = sizeX;
            SizeY = sizeY;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
            EnemyLivingHere = enemyLivingHere;
        }
    }
}