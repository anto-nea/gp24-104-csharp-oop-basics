public class P5Classified
{
    public static void Main(string[] args)
    {
// array of items
Item[] items = {
                new Bread(),
                new Banana(),
                new Apple(),
                new Pear(),
                new Sword(),
                new Axe(),
                new Pencil(),
                new Shield(),
                new Spear(),
                new Tree(),
                new Gorilla(),
                new Chimpanzee(),
                new Sparrow(),
                new Pigeon(),
                new Hawk()
                };

while (true) 
    {
     Console.WriteLine("Enter the name of an item or press '1' to exit: ");
     string userInput = Console.ReadLine().ToLower();

       if (userInput == "1")
         {
          Console.WriteLine("Sad to see you go. Toodeloo!");
       break; 
         }

var foundItem = items.FirstOrDefault(item => item.Name.ToLower() == userInput);
// display error message
       if (foundItem != null)
         {
          Console.WriteLine($"Output: {foundItem.Describe()}");
         }
       else
         {
          Console.WriteLine($"Output: Item '{userInput}' not found.");
         }
         
    } 
    }
}

public class Item
{
    public string Name { get; set; }
    public virtual string Describe() => $"{Name} is an item.";
}

// Edible Items
public class EdibleItem : Item
{ 
    public virtual bool CanBeEaten => true; 
}

public class Bread : EdibleItem
{
    public Bread() { Name = "Bread"; }
    public override string Describe() => $"{Name} is edible and has 1427 kJ.";
}

public class Fruit : EdibleItem
{
    public int Vitamins { get; set; } 
}

public class Banana : Fruit
{
    public Banana() { Name = "Banana"; Vitamins = 120; }
    public override string Describe() => $"{Name} is a fruit, has {Vitamins} vitamins and loads of nutrients.";
}

public class Apple : Fruit
{
    public Apple() { Name = "Apple"; Vitamins = 95; }
    public override string Describe() => $"{Name} is a fruit, has {Vitamins} vitamins and is hella versatile.";
}

public class Pear : Fruit
{
    public Pear() { Name = "Pear"; Vitamins = 80; }
    public override string Describe() => $"{Name} is a fruit and has {Vitamins} vitamins.";
}

// Handheld Items
public class HandheldItem : Item { }

public class Weapon : HandheldItem
{
    public virtual int Damage { get; set; }
}

public class Sword : Weapon
{
    public Sword() { Name = "Sword"; Damage = 50; }
    public override string Describe() => $"{Name} is a weapon and yields {Damage} damage.";
}

public class Axe : Weapon
{
    public Axe() { Name = "Axe"; Damage = 60; }
    public override string Describe() => $"{Name} is a weapon and yields {Damage} damage.";
}

public class Shield : Weapon
{
    public Shield() { Name = "Shield"; Damage = 0; } // Shield does not deal damage
    public override string Describe() => $"{Name} is a weapon and provides protection.";
}

public class Spear : Weapon
{
    public Spear() { Name = "Spear"; Damage = 40; }
    public override string Describe() => $"{Name} is a weapon and yields {Damage} damage.";
}

public class Pencil : HandheldItem
{
    public Pencil() { Name = "Pencil"; }
    public override string Describe() => $"{Name} is a tool used for writing.";
}

// Living Beings
public class LivingBeing : Item
{
    public virtual bool IsAlive => true; // All living beings are alive
}

public class Animal : LivingBeing { }

public class Mammal : Animal { }

public class Gorilla : Mammal
{
    public Gorilla() { Name = "Gorilla"; }
    public override string Describe() => $"{Name} is a mammal and shares 98% of its DNA with us hoomans.";
}

public class Chimpanzee : Mammal
{
    public Chimpanzee() { Name = "Chimpanzee"; }
    public override string Describe() => $"{Name} is a mammal and is known for its loud yapping.";
}

public class Bird : Animal
{
    public bool CanFly { get; set; } = true;
}

public class Sparrow : Bird
{
    public Sparrow() { Name = "Sparrow"; }
    public override string Describe() => $"{Name} is a bird and can fly: {CanFly}.";
}

public class Pigeon : Bird
{
    public Pigeon() { Name = "Pigeon"; }
    public override string Describe() => $"{Name} is a bird and can fly: {CanFly}.";
}

public class Hawk : Bird
{
    public Hawk() { Name = "Hawk"; }
    public override string Describe() => $"{Name} is a bird and can fly: {CanFly}.";
}

// Additional Class
public class Tree : LivingBeing
{
    public Tree() { Name = "Tree"; }
    public override string Describe() => $"{Name} is a living being that provides oxygen.";
}
