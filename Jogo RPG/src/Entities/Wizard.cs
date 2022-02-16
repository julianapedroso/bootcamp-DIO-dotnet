namespace Jogo_RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base (Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

         public override string Attack()
        {
            return this.Name + ": lançou magia";
        }

        // Polimorfismo
        public string Attack(int Bonus)
        {
            return this.Name + ": lançou magia com bônus de ataque de " + Bonus;
        }
    }
}