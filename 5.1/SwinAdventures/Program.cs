using System;

namespace SwinAdventures
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player player =  new Player("Muntazar", "player");
            LookCommand look = new LookCommand();
            Console.WriteLine(look.Execute(player, new string[] { "look", "at", "gem", "in", "bag" }));
        }
    }
}
