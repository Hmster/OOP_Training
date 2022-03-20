using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Random random = new Random();

            p1.SetHealth(100);
            p1.SetMaxHealth(0);
            p1.SetName("p1");

            p2.SetHealth(100);
            p2.SetMaxHealth(30);
            p2.SetName("p2");

            while (p1.Health > 0 && p2.Health > 0)
            {
                Output.HealthPrint(p1, p2);
                Console.ReadKey();

                Output.DamagePrint(p1.Hit(random.Next(10, 30)), p1);
                Output.DamagePrint(p2.Hit(random.Next(10,40)), p2);

                Console.ReadKey();
                Console.Clear();

                if (p1.Health != 0 && p2.Health != 0)
                {
                    int c = random.Next(1, 100);
                    if (p1.Health < 40 && c % 2 == 0)
                    {
                        Output.HealthPrint(p1, p2);
                        Output.HealPrint(p1.Heal(random.Next(10, 25)), p1);
                        Console.ReadKey();
                        Console.Clear();
                    }

                    c = random.Next(1, 100);
                    if (p2.Health < 40 && c % 2 == 0)
                    {
                        Output.HealthPrint(p1, p2);
                        Output.HealPrint(p2.Heal(random.Next(5, 10)), p2);
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                if (p1.Health == 0)
                    Output.VictoryPrint(p2);
                else if (p2.Health == 0)
                    Output.VictoryPrint(p1);
            }
            Console.ReadKey();
        }
    }
}
