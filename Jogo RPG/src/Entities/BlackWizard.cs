namespace Jogo_RPG.src.Entities
{
    public class BlackWizard : Wizard
    {
        public BlackWizard(string Name, int Level, string HeroType) :
            base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
    }
}