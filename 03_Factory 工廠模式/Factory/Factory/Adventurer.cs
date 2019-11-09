using System;
namespace Factory
{
    public interface Adventurer
    {
        String getType();
    }

    public class Archer : Adventurer
    {
        public String getType()
        {
            Console.WriteLine("弓箭手");
            return typeof(Archer).Name;
        }
    }

    public class Warrior: Adventurer
    {
        public String getType()
        {
            Console.WriteLine("鬥士");
            return typeof(Warrior).Name;
        }
    }
}
