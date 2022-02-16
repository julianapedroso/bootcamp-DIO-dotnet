namespace Jogo_RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) :
            base(Name, Level, HeroType)
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
            // Regra de negócio do cálculo do bônus => encapsulamento
            if (Bonus > 6)
            {
                return this.Name +
                ": lançou magia com super efetiva de bônus de ataque de " +
                Bonus;
            }
            else
            {
                return this.Name +
                ": lançou magia com bônus simples de ataque de " +
                Bonus;
            }
        }
    }
}
