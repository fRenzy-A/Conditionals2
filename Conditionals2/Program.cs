using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals2
{
    internal class Program
    {
        static int health = 0;
        
        static void Main(string[] args)
        {
            while (true)
            {
                int switchWeapon = Convert.ToInt32(Console.ReadLine());
                
                ShowHUD(switchWeapon);

            }

           
            

            Console.WriteLine("Conditionals 2");
            Console.WriteLine();

            
            //TakeDamage(150);
            Heal(10);
            Console.WriteLine("Health : " + health);
            
        }
        // THERES AN '&&' FOR 'AND' LOGIC LETS GOOOOO
        static void Heal(int heal)
        {
            Console.WriteLine("Player healed +" + heal);
            health = health + heal;
            if (health >= 100)
            {
                Console.WriteLine("Health full");
                health = 100;
            }
        }
        static void TakeDamage(int damage)
        {
            Console.WriteLine("Player takes " + damage + " damage");
            health = health - damage;

            if (health <= 0)
            {
                health = 0;
            }
        }

        static void ShowHUD(int weapon)
        {
            string gun;
            if (weapon == 1)
            {
                gun = "Pistol";
                Console.WriteLine("Health: " + health);
                Console.WriteLine("Weapon: " + gun);
            }
            else if (weapon == 2)
            {
                gun = "Rifle";
                Console.WriteLine("Health: " + health);
                Console.WriteLine("Weapon: " + gun);
            }
            else
            {
                gun = "Unequipped";
                Console.WriteLine("Health: " + health);
                Console.WriteLine("Weapon: " + gun);
            }
        }
        
        
    }
}
