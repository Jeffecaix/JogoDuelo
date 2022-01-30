using System;


namespace JogoRPG.src.Entities
{
    class Wizard : Hero
    {
        public Wizard(string Name, string HeroType) : base(Name, HeroType)
        {
            this.Name = Name;
            this.HeroType = HeroType;
            this.HealthPoints = 80;
        }

        public override string Attack()
        {
            Random dano = new Random();
            int powerAttack = dano.Next(1, 15);
            this.LastDamage = powerAttack;
            return this.Name + " atacou com a varinha e causou " + powerAttack + " de dano";
        }

        public string Attack(int force)
        {
            Random dano = new Random();            
            int powerAttack = dano.Next(1, 20) + force;
            this.LastDamage = powerAttack;
            return this.Name + " atacou " + powerAttack + " de dano";
        }
    }
}
