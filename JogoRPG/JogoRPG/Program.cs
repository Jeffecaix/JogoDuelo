using JogoRPG.src.Entities;
using System;
using static System.Console;

namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", "Knight");
            Wizard jenica = new Wizard("Jenica", "Wizard");
            Enemy dogKing = new Enemy("King Dog", "Big Boss");
                     
            
            while (arus.HealthPoints >= 0 && dogKing.HealthPoints >= 0)
            {
                WriteLine(" ");
                WriteLine(arus.Attack());
                WriteLine(" ");
                WriteLine(dogKing.Attack());
                WriteLine(" ");
                if (arus.LastDamage == dogKing.LastDamage)
                {
                    WriteLine("Empate na troca de bufete!");
                }
                else if (arus.LastDamage > dogKing.LastDamage)
                {
                    dogKing.TakeDamage(arus.LastDamage - dogKing.LastDamage);
                    WriteLine(dogKing.Name + " perde a luta e sua vida diminiu para HP: " + dogKing.HealthPoints);

                }
                else if (arus.LastDamage < dogKing.LastDamage)
                {
                    arus.TakeDamage(dogKing.LastDamage - arus.LastDamage);
                    WriteLine(arus.Name + " perde a luta e sua vida caiu para HP: " + arus.HealthPoints);

                }

                if (arus.HealthPoints <= 0)
                {
                    WriteLine(" ");
                    WriteLine(arus.Name + " perdeu a luta e voltou para a mamãe!!!");
                }
                else if (dogKing.HealthPoints <= 0)
                {
                    WriteLine(" ");
                    WriteLine(dogKing.Name + " perdeu a luta e voltou para a toca!!!");
                }
            }           


        }
    }
}

