namespace ArenaGame
{
    public class Hero
    {
        public string Name { get; private set; }

        public int Vitality { get; private set; } 

        public int Might { get; private set; } 

        protected int BaseVitality { get; private set; } 

        public bool IsFallen { get { return Vitality <= 0; } } 

        public Weapon EquippedGear { get; private set; } 

        public Hero(string name)
        {
            Name = name;
            Vitality = 550; 
            BaseVitality = Vitality;
            Might = 150; 
        }

        public virtual int Attack()
        {
            int baseAttack = (Might * Random.Shared.Next(80, 121)) / 100;
            if (EquippedGear != null)
            {
                baseAttack += EquippedGear.AttackBoost;
                baseAttack = EquippedGear.UseSpecialAbility(baseAttack);
            }
            return baseAttack;
        }

        public void EquipGear(Weapon weapon) 
        {
            EquippedGear = weapon;
        }

        public virtual void TakeDamage(int incomingDamage)
        {
            if (incomingDamage < 0) return;
            Vitality -= incomingDamage;
        }

        protected bool ThrowDice(int chance) 
        {
            int dice = Random.Shared.Next(101);
            return dice <= chance;
        }

        protected void Heal(int value) 
        {
            Vitality += value;
            if (Vitality > BaseVitality) Vitality = BaseVitality;
        }
    }
}
