namespace ArenaGame
{
    public class Spear : Weapon
    {
        private const int ImpaleChance = 20;
        private const int RiposteChance = 15;

        public Spear() : base("Spear", 18)
        {
        }

        public override int UseSpecialAbility(int baseAttack)
        {
            if (ThrowDice(ImpaleChance))
            {
                return baseAttack * 1.5f;
            }
            else if (ThrowDice(RiposteChance))
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
