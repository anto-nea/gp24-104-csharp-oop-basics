namespace P4Attack;

public class Player
{
    public int Damage;

    public void Attack(Player target)
    {
        target.Damage += Damage;
    }
}

public class Program
{
    static void Main()
    {
        Player player1 = new Player(); //player instances
        Player player2 = new Player();

        Console.WriteLine("Player 1 attacks Player 2.");
        Console.WriteLine("Player 1 Damage: " + player1.Damage);
        Console.WriteLine("Player 2 Damage: " + player2.Damage);

        // Player 2 attacks Player 1
        player2.Attack(player1);
        Console.WriteLine("Player 2 attacks Player 1.");
        Console.WriteLine("Player 1 Damage: " + player1.Damage);
        Console.WriteLine("Player 2 Damage: " + player2.Damage);

        // Player 1 attacks themselves (player1)
        player1.Attack(player1);
        Console.WriteLine("Player 1 attacks Player 1.");
        Console.WriteLine("Player 1 Damage: " + player1.Damage);
        Console.WriteLine("Player 2 Damage: " + player2.Damage);

        // Assign player1 to a new variable player3
        Player player3 = player1;

        // Player 2 attacks Player 3 (which is a reference to player1)
        player2.Attack(player3);
        Console.WriteLine("Player 2 attacks Player 1.");
        Console.WriteLine("Player 1 Damage: " + player1.Damage);
        Console.WriteLine("Player 2 Damage: " + player2.Damage);
        Console.WriteLine("Player 3 Damage: " + player3.Damage); // Same as player1
    }
}
