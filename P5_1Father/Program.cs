namespace P5_1Father
{
 public class DarthVader
    {
    public void UseForce() => Console.WriteLine("Darth Vader is using the Force");
    }

 public class Luke : DarthVader
    {
    public void UseLightSaber() => Console.WriteLine("Luke is using his lightsaber");
    }

 public static class Program
    {
    public static void Main() 
       {
        var luke = new Luke();
        luke.UseForce();
        luke.UseLightSaber();
        }
    }
}