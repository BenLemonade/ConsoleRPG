using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // Creating public static class 'World'
    public static class World
    {
        //List the static variables:
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Enemy> Enemies = new List<Enemy>();
        public static readonly List<Location> Locations = new List<Location>();

        //List item IDs:
        public const int ITEM_ID_YOUR_OWN_FISTS = 1;
        public const int ITEM_ID_RING = 2;
        public const int ITEM_ID_SHOE = 3;
        public const int ITEM_ID_POCKET_BOTTLE_OPENER = 4;
        public const int ITEM_ID_BKK_TICKET = 5;
        public const int ITEM_ID_BOXING_GLOVES = 6;
        public const int ITEM_ID_HEALING_PALINKA = 7;
        public const int ITEM_ID_MOUTH_GUARD = 8;
        public const int ITEM_ID_HELMET = 9;
        public const int ITEM_ID_BOXER_PASS = 10;

        //List monster IDs:
        public const int ENEMY_ID_STREET_SCRUB = 1;
        public const int ENEMY_ID_DRUNK_BRAWLER = 2;
        public const int ENEMY_ID_UNDERGROUND_CHAMP = 3;

        //List location IDs:
        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_STREET = 2;
        public const int LOCATION_ID_UNDERGROUND_ENTRANCE = 3;
        public const int LOCATION_ID_CORNER_SHOP = 4;
        public const int LOCATION_ID_ALCOHOL_CABINET = 5;
        public const int LOCATION_ID_KOCSMA = 6;
        public const int LOCATION_ID_BAR = 7;
        public const int LOCATION_ID_DOOR = 8;
        public const int LOCATION_ID_UNDERGROUND_ROOM = 9;

        static World()
        {
            PopulateItems();
            PopulateEnemies();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Tool(ITEM_ID_YOUR_OWN_FISTS, "Fists", "Fists", 0, 5));
            Items.Add(new Item(ITEM_ID_RING, "Ring", "Rings"));
            Items.Add(new Item(ITEM_ID_SHOE, "Shoe", "Shoes"));
            Items.Add(new Item(ITEM_ID_POCKET_BOTTLE_OPENER, "Pocket Bottle Opener", "Pocket Bottle Openers"));
            Items.Add(new Item(ITEM_ID_BKK_TICKET, "Single-Use BKK Ticket", "Single-Use BKK Tickets"));
            Items.Add(new Tool(ITEM_ID_BOXING_GLOVES, "Glove", "Gloves", 3, 10));
            Items.Add(new Palinka(ITEM_ID_HEALING_PALINKA, "A shot of Healing Palinka", "Mulitple shots of Healing Palinka", 5));
            Items.Add(new Item(ITEM_ID_MOUTH_GUARD, "Spider fang", "Spider fangs"));
            Items.Add(new Item(ITEM_ID_HELMET, "Spider silk", "Spider silks"));
            Items.Add(new Item(ITEM_ID_BOXER_PASS, "Figther pass", "Figther passes"));
        }

        private static void PopulateEnemies()
        {
            Enemy streetScrub = new Enemy("Yellow", ENEMY_ID_STREET_SCRUB, "Regular street chav.", 5, 3, 10, 3, 3);
            streetScrub.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RING), 75, false));
            streetScrub.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SHOE), 75, true));

            Enemy drunkBrawler = new Enemy("Orange", ENEMY_ID_DRUNK_BRAWLER, "This intoxicated, fighting fellow can take quite a few hits.", 5, 3, 10, 3, 3);
            drunkBrawler.LootTable.Add(new LootItem(ItemByID(ITEM_ID_POCKET_BOTTLE_OPENER), 75, false));
            drunkBrawler.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BKK_TICKET), 75, true));

            Enemy undergroundChamp = new Enemy("Red", ENEMY_ID_UNDERGROUND_CHAMP, "The champion of the fighting ring.", 20, 5, 40, 10, 10);
            undergroundChamp.LootTable.Add(new LootItem(ItemByID(ITEM_ID_MOUTH_GUARD), 75, true));
            undergroundChamp.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HELMET), 25, false));

            Enemies.Add(streetScrub);
            Enemies.Add(drunkBrawler);
            Enemies.Add(undergroundChamp);
        }

        private static void PopulateLocations()
        {
            // Create each location
            Location home = new Location(LOCATION_ID_HOME, 5, 3, "Home", "Your house. You really need to clean up the place.");

            Location street = new Location(LOCATION_ID_STREET, 15, 10, "The Block", "Da str33ts. It be real out here.");

            Location cornerShop = new Location(LOCATION_ID_CORNER_SHOP, 7, 5, "ABC Store", "The cashier is extra grumpy today.");

            Location alcoholCabinet = new Location(LOCATION_ID_ALCOHOL_CABINET, 2, 3, "Alcohol Cabinet", "The most precious cabinet in the world.");
            alcoholCabinet.EnemyLivingHere = EnemyByID(ENEMY_ID_STREET_SCRUB);

            Location kocsma = new Location(LOCATION_ID_KOCSMA, 10, 5, "Kocsma", "A standard hole-in-the-wall kocsma.");

            Location bar = new Location(LOCATION_ID_BAR, 2, 3, "The bar", "Looks like the have some Arany Asok on tap, at least..");
            bar.EnemyLivingHere = EnemyByID(ENEMY_ID_DRUNK_BRAWLER);

            Location undergroundEntrance = new Location(LOCATION_ID_UNDERGROUND_ENTRANCE, 2, 2, "Entrance to Club", "I better have what I need.", ItemByID(ITEM_ID_BOXER_PASS));

            Location door = new Location(LOCATION_ID_DOOR, 10, 2, "Crowded Hall", "The hall stinks and the floor is sticky.");

            Location undergroundRoom = new Location(LOCATION_ID_UNDERGROUND_ROOM, 20, 20, "Underground Boxing Ring", "A large room with a boxing square in the middle and seats for spectators.");
            undergroundRoom.EnemyLivingHere = EnemyByID(ENEMY_ID_UNDERGROUND_CHAMP);

            // Link the locations together

            // South-most location is home
            home.LocationToNorth = street;

            street.LocationToNorth = cornerShop;
            street.LocationToSouth = home;
            street.LocationToEast = undergroundEntrance;
            street.LocationToWest = kocsma;

            kocsma.LocationToEast = street;
            kocsma.LocationToWest = bar;

            bar.LocationToEast = kocsma;

            cornerShop.LocationToSouth = street;
            cornerShop.LocationToNorth = alcoholCabinet;

            alcoholCabinet.LocationToSouth = cornerShop;

            undergroundEntrance.LocationToEast = door;
            undergroundEntrance.LocationToWest = street;

            door.LocationToWest = undergroundEntrance;
            door.LocationToEast = undergroundRoom;

            undergroundRoom.LocationToWest = door;

            // Add the locations to the static list
            Locations.Add(home);
            Locations.Add(street);
            Locations.Add(undergroundEntrance);
            Locations.Add(cornerShop);
            Locations.Add(alcoholCabinet);
            Locations.Add(kocsma);
            Locations.Add(bar);
            Locations.Add(door);
            Locations.Add(undergroundRoom);
        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Enemy EnemyByID(int id)
        {
            foreach (Enemy enemy in Enemies)
            {
                if (enemy.ID == id)
                {
                    return enemy;
                }
            }

            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }
    }
}
