namespace P3LevelUp
{ 
    class Program
    {
        static void Main()
        {
            var player = new Player();
            while (true)
            {
                Console.Write("How much experience do you want? (Enter -1 to exit): ");
                if (int.TryParse(Console.ReadLine(), out int expInput) && expInput != -1)
                {
                    player.GrantExperience(expInput);
                    Console.WriteLine(player);
                }
                else break; 
            }
        }
    }
}