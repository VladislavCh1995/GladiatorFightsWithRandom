using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorFightsWithRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            float heroHealth = rand.Next(90, 100);
            int heroDamage = rand.Next(10, 20);
            float heroArmor = rand.Next(55, 65);
            float enemyHealth = rand.Next(80, 150);
            int enemyDamage = rand.Next(30, 45);
            float enemyArmor = rand.Next(0, 10);

            Console.WriteLine("Герой - " + heroHealth + " хп, " + heroDamage + " макс. урон, " + heroArmor + " брони.");
            Console.WriteLine("Противник - " + enemyHealth + " хп, " + enemyDamage + " макс. урон, " + enemyArmor + " брони.");

            while (heroHealth > 0 && enemyHealth > 0)
            {
                heroHealth -= rand.Next(0, enemyDamage) - (Convert.ToSingle(enemyDamage) * ( (heroArmor / 100) / ((heroArmor/100) + 1)));
                enemyHealth -= rand.Next(0, heroDamage) - (Convert.ToSingle(heroDamage) * ((enemyArmor / 100) / ((enemyArmor / 100) + 1)));
                Console.WriteLine($"Герой имеет : {heroHealth} хп.");
                Console.WriteLine($"Враг имеет : {enemyHealth} хп.");
            }

            if (heroHealth <= 0 && enemyHealth <= 0)
            {
                Console.WriteLine("Ничья, оба мертвы! =/");
            }
            else if (heroHealth <= 0)
            {
                Console.WriteLine("Враг победил! =(");
            }
            else
            {
                Console.WriteLine("Победил герой! =)");
            }
        }
    }
}
