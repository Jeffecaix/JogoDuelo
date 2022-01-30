using System;


namespace JogoRPG.src.Entities
{
    class Knight : Hero
    {
        public Knight(string Name, string HeroType) : base(Name, HeroType)
        {
            this.Name = Name;
            this.HeroType = HeroType;
            this.HealthPoints = 25;
        }

        public override string Attack()
        {
            Random dano = new Random();
            int powerAttack = dano.Next(1, 20);
            this.LastDamage = powerAttack;
            return this.Name + " atacou com sua faquinha de pão e causou " + powerAttack + " de dano";
        }
    }
}
