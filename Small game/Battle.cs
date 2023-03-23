using System;
using System.Collections.Generic;
using System.Text;

namespace Small_game
{
    public class Battle
    {
       
        bool gameContiues = true;
        public string Battle1(Characters hero, Characters enemy)
        {
            ConsoleKeyInfo input;

            do
            {
                
                int heroAttack = hero.Attacking();
                int goblinattack = enemy.Attacking();
                Console.WriteLine(heroAttack);
                Console.WriteLine(hero.Shout());
                if (heroAttack > enemy.DefensePoints())
                {
                    enemy.DamageHealth(hero.AttackPoints());
                }

                Console.WriteLine(goblinattack);
                Console.WriteLine(enemy.Shout());
                if (goblinattack > hero.DefensePoints())
                {
                    hero.DamageHealth();
                }
                Console.WriteLine();
                //BattleInterface();
                Console.WriteLine($"Hero {hero.HealthStatus()}");
                Console.WriteLine($"Goblin {enemy.HealthStatus()}");
                input = Console.ReadKey();
                if (input.Key.Equals(ConsoleKey.Spacebar)){
                    if (hero.HealthStatus() <= 0)
                    {
                        gameContiues = false;
                    }
                    if (enemy.HealthStatus() <= 0)
                    {
                        gameContiues = false;
                    }
                }
                Console.Clear();

            } while (gameContiues);
            if (hero.HealthStatus() <= 0)
            {
                
                Console.WriteLine("You have died the kingdom shall burn.");
                Console.WriteLine("");
                Console.WriteLine("GAME OVER");
                return "You have died the kingdom shall burn.";
            }
            else if (enemy.HealthStatus() <= 0)
            {
                Console.WriteLine("You are victorious!");
                return "Prey slaughtered!";
            }

            return "";

        }
        public string BattleInterface()
        {
            

            Console.WriteLine("Battle is joined.");
            Console.WriteLine();
            Console.WriteLine("|1: Slash  |");
            Console.WriteLine("|2: Swipe  |");
            Console.WriteLine("|3: Guard  |");
            Console.WriteLine("|4: Grapple|");

            return "";
        }
    }
}
