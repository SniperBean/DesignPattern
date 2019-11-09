using System;
namespace Factory
{
    public interface TrainingCamp
    {
        /*
            明確介面宣告上不允許 public 關鍵字。 在此情況下，請從明確介面宣告移除 public 關鍵字。
            介面方法上不允許 static 和 public 修飾詞。
            區域函式上不允許 static 修飾詞。
        */
        Adventurer trainAdventurer();
    }

    public class ArcherTrainingCamp : TrainingCamp
    {
        public Adventurer trainAdventurer()
        {
            Console.WriteLine("訓練一個弓箭手");
            return new Archer();
        }
    }

    public class WarriorTrainingCamp : TrainingCamp
    {
        public Adventurer trainAdventurer()
        {
            Console.WriteLine("訓練一個鬥士");
            return new Warrior();
        }
    }


}
