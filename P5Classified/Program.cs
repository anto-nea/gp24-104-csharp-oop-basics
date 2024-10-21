public class Program
{
public static void Main(string[] args)
    {
    Bread bread = new Bread();
    Banana banana = new Banana();
    Sword sword = new Sword();
    Tree tree = new Tree();
    Sparrow sparrow = new Sparrow();

    Console.WriteLine("Instances created successfully!");
     }
}

// Base Classes
public class HandheldItem { }
public class EdibleItem { }
public class LivingBeing { }

// Weapons
public class Weapon : HandheldItem { }
public class Sword : Weapon { }
public class Axe : Weapon { }
public class Shield : Weapon { }
public class Spear : Weapon { }
public class Pencil : HandheldItem { }  

// Edibles
public class Fruit : EdibleItem { }
public class Bread : EdibleItem { }
public class Banana : Fruit { }
public class Apple : Fruit { }
public class Pear : Fruit { }

// Living Creatures
public class Animal : LivingBeing { }
public class Bird : Animal { }
public class Gorilla : Animal { }
public class Chimpanzee : Animal { }
public class Tree : LivingBeing { }
public class Sparrow : Bird { }
public class Pigeon : Bird { }
public class Hawk : Bird { }
