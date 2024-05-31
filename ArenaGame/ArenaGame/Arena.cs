using ArenaGame;

public class Arena
{
    public Hero FirstHero { get; private set; }
    public Hero SecondHero { get; private set; }

    public Arena(Hero hero1, Hero hero2)
    {
        FirstHero = hero1;
        SecondHero = hero2;
    }

    public Hero DetermineVictor()
    {
        Hero activeHero = ChooseStartingHero();
        Hero opponent = GetOpponent(activeHero);

        while (true)
        {
            int damage = activeHero.Attack();
            opponent.TakeDamage(damage);

            if (opponent.IsFallen) return activeHero;

            SwapHeroes(activeHero, opponent);
        }
    }

    private Hero ChooseStartingHero()
    {
        return Random.Shared.Next(2) == 0 ? FirstHero : SecondHero;
    }

    private Hero GetOpponent(Hero currentHero)
    {
        return currentHero == FirstHero ? SecondHero : FirstHero;
    }

    private void SwapHeroes(Hero hero1, Hero hero2)
    {
        Hero temp = hero1;
        hero1 = hero2;
        hero2 = temp;
    }
}
