using System;

/*
    簡單工廠模式-目的: 定義一個簡單工廠，傳入不同的參數取得不同的類別物件

    簡單工廠又稱為靜態工廠模式，一般來說同一工廠內所生產的類別會有一個共同的父類別(介面)。

    簡單工廠是一種管理物件創建的模式，隨著輸入的參數不同，簡單工廠會回傳不同的物件，使用者取得物件的時候只要傳入正確的參數，不需要去理解實際產生過程。

    現在設計一個訓練冒險者，Adventure的訓練營TrainingCamp，裡面可以訓練冒險者種類有弓箭手Archer、鬥士Warrior。
    套用道簡單工廠模式中，訓練營就是簡單工廠(Simple Factory)，冒險者則是產品的父類別，弓箭手與鬥士為實體產品(Contrete Product)。
    如果有人要來招募冒險者組隊，只要跟訓練營說明幫我訓練一個冒險者就可以，不用去理解訓練過程。

    要訓練一種新型態的冒險者，牧師Priest，只要在trainAdventurer方法裡新增一個switch case分分支就好。
    不過直接修改TrainingCamp類別的程式碼，違反了開放/封閉原則(OCP)，因此簡單工廠不算是一個健全的設計模式，不過簡單工廠在小型軟體架構很好用。
    因此一班設計模式的教學都會從簡單工廠模式開始，實務上也很常會用到這個簡單的模式。
 */

namespace SimpleFactory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Adventurer memberA = TrainingCamp.trainAdventurer("archer");
            Adventurer memberB = TrainingCamp.trainAdventurer("warrior");

            memberA.getType();
            memberB.getType();
        }
    }
}
