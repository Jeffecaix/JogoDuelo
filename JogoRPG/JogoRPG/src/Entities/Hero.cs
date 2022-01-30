using static System.Console;
using System;


namespace JogoRPG.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, string HeroType)
        {
            this.Name = Name;
            this.HeroType = HeroType;
            
        }

        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public string HeroType { get; set; }
        public int LastDamage { get; set; }
        


        public override string ToString()
        {
            return "Nome: " + this.Name + "\n"
                 + "HP: " + this.HealthPoints + "\n"
                 + "Class: " + this.HeroType;
        }

        public virtual string Attack()
        {
            Random dano = new Random();
            int powerAttack = dano.Next(1, 20);
            this.LastDamage = powerAttack;
            return this.Name + " atacou " + powerAttack + " de dano";
        }

        public void TakeDamage(int danoRecebido)
        {
            this.HealthPoints = this.HealthPoints - danoRecebido;
        }
    }
}
