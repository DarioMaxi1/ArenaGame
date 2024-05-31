namespace ArenaGame
{
    public class Stark : Hero
    {
        private const int WinterFuryChance = 15;
        private const int IntimidationChance = 25;
        private int fearTurnsRemaining = 0;

        public Stark(string name) : base(name)
        {
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(WinterFuryChance))
            {
                attack *= 2;
                ApplyFear();
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(IntimidationChance))
            {
                if (fearTurnsRemaining == 0)
                {
                    incomingDamage /= 2;
                }
            }
            base.TakeDamage(incomingDamage);
        }

        private void ApplyFear()
        {

            fearTurnsRemaining = 2;
        }
    }
}
