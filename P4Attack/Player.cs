namespace P4Attack
{
    public class Player
    {
        public int Damage;

// method increment for damage
public void Attack(Player target)
        {
            target.Damage += 1;
        }
    }

    public static class Program
    {
        static void Main()
        {
            Player player1 = new Player(); 
            Player player2 = new Player();
            Player player3 = new Player(); 

            // P1 attacks P2
            player1.Attack(player2);
            Console.WriteLine("Player 1 attacks Player 2.");
            Console.WriteLine($"Player 1 Damage: {player1.Damage}");
            Console.WriteLine($"Player 2 Damage: {player2.Damage}");

            // P2 attacks P1
            player2.Attack(player1);
            Console.WriteLine("Player 2 attacks Player 1.");
            Console.WriteLine($"Player 1 Damage: {player1.Damage}");
            Console.WriteLine($"Player 2 Damage: {player2.Damage}");

            // P1 attacks themselves
            player1.Attack(player1);
            Console.WriteLine("Player 1 attacks Player 1.");
            Console.WriteLine($"Player 1 Damage: {player1.Damage}");
            Console.WriteLine($"Player 2 Damage: {player2.Damage}");

            // P2 attacks P3 
            player2.Attack(player3);
            Console.WriteLine("Player 2 attacks Player 3.");
            Console.WriteLine($"Player 1 Damage: {player1.Damage}");
            Console.WriteLine($"Player 2 Damage: {player2.Damage}");
            Console.WriteLine($"Player 3 Damage: {player3.Damage}");
        }
    }
}
