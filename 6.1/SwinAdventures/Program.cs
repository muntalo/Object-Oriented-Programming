using System;

namespace SwinAdventures
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a player name:");
            string player_name = Console.ReadLine();
            Console.WriteLine("Please enter a player description:");
            string player_desc = Console.ReadLine();
            Player player = new Player(player_name, player_desc);

            Item wood_shield = new Item(new string[] { "shield", "defence" }, "a shield", "a cheap wooden shield...");
            Item wood_sword = new Item(new string[] { "sword", "attack" }, "a sword", "a cheap wooden sword...");
            player.Inventory.Put(wood_shield);
            player.Inventory.Put(wood_sword);

            Bag bag = new Bag(new string[] { "bag", "backpack" }, "a bag", "a bag to hold your items...");
            Item gem = new Item(new string[] { "gem", "shiny" }, "a gem", "an odd looking shiny gem...");
            bag.Inventory.Put(gem);
            player.Inventory.Put(bag);

            while (true)
            {
                Console.WriteLine("Enter command:");
                string read = Console.ReadLine();
                string[] command = read.Split(" ");

                LookCommand look = new LookCommand();
                Console.WriteLine(look.Execute(player, command));
            }
        }
    }
}
