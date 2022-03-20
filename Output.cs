using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Training
{
    internal class Output
    {
        internal static void HealthPrint(Player p1, Player p2)
        {
            Console.WriteLine($"{p1.Name} maxHP: {p1.MaxHealth}\t{p2.Name} maxHP: {p2.MaxHealth}\n{p1.Name} HP:    {p1.Health}\t{p2.Name} HP:    {p2.Health}\n");
        }

        internal static void DamagePrint(int damage, Player player)
        {
            if (player.Name == "p1")
                Console.WriteLine($"p2 hit {player.Name} to: {damage}");
            else if (player.Name == "p2")
                Console.WriteLine($"p1 hit {player.Name} to: {damage}");
        }

        internal static void HealPrint(int heal, Player player)
        {
            Console.WriteLine($"{player.Name} healing: {heal}");
        }

        internal static void VictoryPrint(Player player)
        {
            Console.WriteLine($"{player.Name} win!");
        }
    }

    
}
