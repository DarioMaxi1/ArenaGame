namespace ArenaGame
{
    public class Snow : Hero
    {
        private const int DirewolfSupportChance = 30;
        private const int IcyVeinsCooldown = 3;

        private int icyVeinsTurnsRemaining = 0;

        public Snow(string name) : base(name)
        {
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(DirewolfSupportChance))
            {

                attack += GetDirewolfDamage();
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (CanUseIcyVeins())
            {
                incomingDamage /= 2;
                icyVeinsTurnsRemaining = IcyVeinsCooldown;
            }
            base.TakeDamage(incomingDamage);
        }

        private int GetDirewolfDamage()
        {
            return Random.Next(5, 15);
        }

        private bool CanUseIcyVeins()
        {
            return icyVeinsTurnsRemaining == 0;
        }
    }
}
