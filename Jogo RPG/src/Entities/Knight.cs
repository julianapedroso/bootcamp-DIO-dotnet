namespace Jogo_RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType) :
            base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
    }
}