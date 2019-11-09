using System;
namespace SimpleFactory
{
    public interface Adventurer
    {
        String getType();
    }

    public class Archer : Adventurer{
        public String getType(){
            Console.WriteLine("我是弓箭手");
            return typeof(Archer).Name;
        }
    }

    public class Warrior : Adventurer
    {

        public String getType()
        {
            Console.WriteLine("我是鬥士");
            return typeof(Warrior).Name;
        }
    }
}
