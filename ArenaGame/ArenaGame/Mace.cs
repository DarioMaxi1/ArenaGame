namespace ArenaGame
{
    public class Mace : Weapon
    {
        private const int StaggerChance = 30;

        public Mace() : base("Mace", 20)
        {
        }

        public override int UseSpecialAbility(int baseAttack)
        {
            if (ThrowDice(StaggerChance))
            {
                return baseAttack;
            }
            return baseAttack;
        }

        private bool ThrowDice(int chance)
        {
            int dice = Random.Shared.Next(101);
            return dice <= chance;
        }
    }
}
