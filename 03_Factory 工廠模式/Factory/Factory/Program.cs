using System;

/*
    簡單工廠模式因為只有一個工廠，要新增產品要直接修改工廠類別的程式碼(如工廠本來只生產:鬥士、弓箭手，要新增牧師要修改工廠類別)
    因此破壞了開放/封閉原則，在工廠模式中，我們將工廠(Factory)提升至一個抽象的概念，也就是說現在的工廠是一個介面(Interface)
    工廠介面只會規範實體工廠的類別(Concrete Factory)應該返回哪種產品，實際上要如何製作產品則交給實體工廠時實作。

    現在訓練營已經被提升為一種概念，訓練各種冒險者的過程應該是不一樣的，不能像以前這樣一個訓練營訓練出所有種類的冒險者。
    例如培養近身格鬥的鬥士與躲遠遠放冷箭的弓箭手應該是不同的訓練過程。
    
    新手現在建立了兩座訓練營，弓箭手訓練營、鬥士訓練營，如此一來想要修改弓箭手的訓練流程，修改弓箭手訓練營的程式碼即可。
    不用擔心影響鬥士訓練營的運作，而要新增冒險者的類別，如劍士，只要新增劍士訓練營，完全不會修改到抽象訓練營與現有的實體訓練營。
*/

namespace Factory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========工廠模式測試========");

            //訓練營冒險者
            //先用弓箭手訓練營訓練弓箭手
            TrainingCamp trainingCamp = new ArcherTrainingCamp();
            Adventurer memberA = trainingCamp.trainAdventurer();

            //用鬥士訓練營訓練鬥士
            trainingCamp = new WarriorTrainingCamp();
            Adventurer memberB = trainingCamp.trainAdventurer();

            //確認是否為訓練營訓練出想要的冒險者
            Console.WriteLine(System.Object.Equals(memberA.getType(), "Archer"));
            Console.WriteLine(System.Object.Equals(memberB.getType(), "Warrior");
        }
    }
}
