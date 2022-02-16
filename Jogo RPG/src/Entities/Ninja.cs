namespace Jogo_RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType) :
            base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Attack(string Force)
        {
            if (Force == "super")
            {
                return this.Name + ": atacou com a sua espada com super força";
            }
            else
            {
                return this.Name + ": atacou com a sua espada com força normal";
            }
        }
    }
}
