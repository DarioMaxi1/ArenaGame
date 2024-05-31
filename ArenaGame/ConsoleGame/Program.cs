using ArenaGame;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of fights: ");
            int rounds = Int32.Parse(Console.ReadLine());
            int oneWins = 0, twoWins = 0;

            for (int i = 0; i < rounds; i++)
            {
                Hero one = new King("King Slayer");
                Hero two = new Snow("Jon Snow");

                one.EquipWeapon(new Mace());
                two.EquipWeapon(new Spear());

                Console.WriteLine($"Arena fight between: {one.Name} and {two.Name}");
                Arena arena = new Arena(one, two);
                Hero winner = arena.DetermineVictor();
                Console.WriteLine($"Winner is: {winner.Name}");
                if (winner == one) oneWins++; else twoWins++;
            }
            Console.WriteLine();
            Console.WriteLine($"One has {oneWins} wins.");
            Console.WriteLine($"Two has {twoWins} wins.");

            Console.ReadLine();
        }
    }
}
