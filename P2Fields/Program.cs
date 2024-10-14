public class Player
{
    public int Gold, Stone, Wood, Level, Experience;
    public bool VipActive, PvpEnabled;
    public string DisplayName, Email;
}

class Program
{
    static void Main()
    {
        var player = new Player
        {
            Gold = 200,
            Stone = 110,
            Wood = 53,
            Level = 12,
            Experience = 123,
            VipActive = true,
            PvpEnabled = false,
            DisplayName = "Marc",
            Email = "marc@zaku.de"
        };

        Console.WriteLine($"Name: {player.DisplayName}, Email: {player.Email}");
        Console.WriteLine($"Gold: {player.Gold}, Stone: {player.Stone}, Wood: {player.Wood}");
        Console.WriteLine($"Level: {player.Level}, Experience: {player.Experience}");
        Console.WriteLine($"VIP Active: {player.VipActive}, PVP Enabled: {player.PvpEnabled}");
    }
}