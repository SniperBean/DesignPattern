using System;
namespace SimpleFactory
{
    public class TrainingCamp
    {
        public TrainingCamp()
        {
            //TrainingCamp trainingCamp = new TrainingCamp();
        }

        public static Adventurer trainAdventurer(String type)
        {
            switch(type)
            {
                case "archer":{
                        Console.WriteLine("我是一名弓箭手");
                        return new Archer();
                    }
                case "warrior":{
                        Console.WriteLine("我是一名鬥士");
                        return new Warrior();
                    }
                default: return null; 
            }
        }
    }
}
