namespace EventsTest
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        private static void OnEnemyBossDied(object sender, EventArgs eventArgs, Melee unit)
        {
            unit.health = 999;
            Console.WriteLine(4);
        }

        static void Main()
        {
            List<Enemy> enemies = new List<Enemy>();

            Boss boss = new Boss();
            Melee melee = new Melee();

            enemies.Add(new Melee());
            enemies.Add(new Boss());
            enemies.Add(new Melee());

            

            foreach (var enemy in enemies)
            {
                Console.WriteLine(enemy.GetType().Name + " " + enemy.health);
            }

            boss.BossDied += new Boss.AddHealth(OnEnemyBossDied);

            Console.WriteLine(melee.health);
            
        }        
    }
}