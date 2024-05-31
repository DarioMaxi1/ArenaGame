namespace ArenaGame
{
    public class King : Hero
    {
        private const int ParryChance = 20;
        private const int RiposteChance = 15;


        public King(string name) : base(name)
        {

        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (RollDice(RiposteChance))
            {
                attack *= RiposteDamageMultiplier;
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (RollDice(ParryChance))
            {
                incomingDamage /= 2;
            }
            base.TakeDamage(incomingDamage);
        }


    }
}
