namespace P3LevelUp
{
public class Player
    { 
     public int Level, Experience;

     public void GrantExperience(int exp)
        {
            Experience += exp;
            Level += Experience / 100;
            Experience %= 100;
        }
     public override string ToString() => $"{Level} Level and {Experience} Experience";
    }
}