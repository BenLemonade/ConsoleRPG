using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // Creating public class 'Location' to describe the different locations/rooms
    public class Location
    {
        // Shared attributes are 'ID', 'Size X', 'Size Y', 'Name', 'Description', 'Item Required to Enter', 'Enemy Living Here', 'Loc. N', 'Loc. E', 'Loc. S', 'Loc. W'
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