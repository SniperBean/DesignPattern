using System;

/*
    抽象工廠模式 Abstract Factory

    有了冒險者之後，他們還需要各種裝備才能出門探險，夾如冒險者需要武器、頭盔、上衣、褲子、鞋子5種裝備。
    村裡又有4種不同職業的冒險者，這樣就需要建立20種工廠類別來生產裝備，而每增加一個冒險者類別就需要增加5種實體工廠類別。
    如果使用工廠模式來管理生產的裝備，實體工廠類別就會變得非常多，這時候有點經驗的程式設計師就會意識到程式碼會因此變得雜亂不易維護。

    這種情況下，工廠模式不能解決我們的問題，抽象工廠可以。
    改變一下工廠的定義，首先工廠仍是一個抽象介面，但是工廠介面現在的規範不是工廠現在生產的不是一種產品，而是產生一個冒險者類別一系列的裝備。
    也就是說一間工廠現在要生產武器、頭盔、上衣、褲子、鞋子，(Concrete Factory)，如鬥士裝備就會生產一系列的鬥士裝備(Concrete Product)，這就是抽象工廠模式。
*/

namespace AbstractFactory
{
    /*
        工廠模式與抽象工廠模式比較
        ・工廠模式: 工廠模式注重的是如何生產一個物件，例如弓箭手訓練營只要負責如何生產出弓箭手。
        ・抽象工廠模式: 抽象工廠模式注重在產品的抽象關係，向武器與衣服本身是扯不上關係的兩種物品，但這兩種物品同屬於冒險者的裝備，因此有了這層抽象關係。
    */
    class MainClass
    {
        public static void Main(string[] args)
        {
            EquipFactory equipFactory;
            Console.WriteLine("==========抽象工廠模式測試==========");

            //幫弓箭手生產裝備
            equipFactory = new ArcherEquipFactory();
            Clothes archerLeather = equipFactory.produceArmor();
            Weapon archerBow = equipFactory.produceWeapon();

            //幫鬥士生產裝備
            equipFactory = new WarriorEquipFactory();
            Clothes armor = equipFactory.produceArmor();
            Weapon longSword = equipFactory.produceWeapon();

            //訓練營
            TrainingCamp camp; 

            //弓箭手訓練營
            camp = new ArcherTrainingCamp();
            //訓練弓箭手
            Adventurer archer= camp.trainAdventurer();
            //鬥士訓練營
            camp = new WarriorTrainingCamp();
            //訓練鬥士
            Adventurer warrior = camp.trainAdventurer();

            archer.display();
            warrior.display();

        }
    }
}
