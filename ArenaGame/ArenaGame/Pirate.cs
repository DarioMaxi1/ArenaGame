namespace ArenaGame
{
    public class Pirate : Hero
    {
        private const int CannonBlastChance = 25;
        private const int GrogStrength = 15;


        public Pirate(string name) : base(name)
        {
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(CannonBlastChance))
            {
                attack += GetBonusCannonDamage();
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (RollDice(20)) 
            {
                Heal(GrogHealAmount);
            }
            base.TakeDamage(incomingDamage);
        }
        private int GetBonusCannonDamage()
        {
            return Random.Next(10, 20);
        }
    }
}
