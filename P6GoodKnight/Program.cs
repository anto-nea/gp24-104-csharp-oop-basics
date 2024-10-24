namespace P6Composition
{ 
// Shield class
public class Shield
    {
        public string Name { get; set; } = "Knight's Shield";
    }

// Sword class
public class Sword
    {
        public string Name { get; set; } = "Sword";
    }
    
// Knight class
public class Knight
    {
        public Shield? Shield { get; set; }
        public Sword? Sword { get; set; }  

        // Get hit method
        private void GetHit(Sword weapon)
        {
            if (Shield != null)
            {
                Console.WriteLine($"{Shield.Name} was pierced by the {weapon.Name}.");
                Shield = null; // Removing shield after it's been pierced
            }
            else
            {
                Console.WriteLine("The Knight has no Shield and is wounded.");
            }
        }

// Method for one knight to attack the other
public void Attack(Knight target)
        {
            if (Sword == null)
            {
                Console.WriteLine("Knight attacks Knight with Bare Hands.");
                if (target.Shield != null)
                {
                    Console.WriteLine($"{target.Shield.Name} fends off the strike.");
                }
                else
                {
                    Console.WriteLine("The Knight is hit.");
                }
            }
            else
            {
                Console.WriteLine($"Knight attacks Knight with a {Sword.Name}.");
                target.GetHit(Sword);
            }
        }
    }

// Main Program
public static class Program 
    { 
        public static void Main(string[] args)
        {
         // Creation of knights
            Knight attacker = new Knight();
            Knight defender = new Knight { Shield = new Shield() }; // Defender has a shield
       // First attack (attacker has no sword)
            attacker.Attack(defender);
        // Equip the attacker with a sword
            attacker.Sword = new Sword();
            Console.WriteLine("Equipping Sword...");
        // Second attack (attacker now has a sword)
            attacker.Attack(defender); 
        // Third attack (attacker attacks again)
            attacker.Attack(defender);
        }
    }
}
