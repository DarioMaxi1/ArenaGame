namespace ArenaGame
{
    public abstract class Weapon
    {

        private string name;
        private int attackBoost;
        public string Name { get; protected set; }
        public int AttackBoost { get; protected set; }

        public Weapon(string name, int attackBoost)
        {
            this.name = name;
            this.attackBoost = attackBoost;
        }

        public abstract int UseSpecialAbility(int baseAttack);

    }
}
