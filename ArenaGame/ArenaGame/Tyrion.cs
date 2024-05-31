namespace ArenaGame
{
    public class Tyrion : Hero
    {
        private const int ShieldBlockChance = 30;
        private const int CounterAttackChance = 15;

        public Tyrion(string name) : base(name)
        {
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(CounterAttackChance))
            {
                attack += 40;
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(ShieldBlockChance))
            {
                incomingDamage /= 2;
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
