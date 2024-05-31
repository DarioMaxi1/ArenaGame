namespace ArenaGame
{
    public class DualDaggers : Weapon
    {
        private const int FlurryChance = 25;
        private const int DodgeChance = 15;

        public DualDaggers() : base("Dual Daggers", 12)
        {
        }

        public override int UseSpecialAbility(int baseAttack)
        {
            if (ThrowDice(FlurryChance))
            {
                return baseAttack / 2;
            }
            else if (ThrowDice(DodgeChance))
            {
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
