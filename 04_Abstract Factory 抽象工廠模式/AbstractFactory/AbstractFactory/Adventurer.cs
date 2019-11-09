using System;
namespace AbstractFactory
{
    /*
        冒險者
    */

    public abstract class Adventurer
    {
        protected Weapon weapon;    //武器
        protected Clothes clothes;  //衣服

        /*
            查看冒險者的狀態
        */

        public abstract void display();


        //以下是getter & setter
        public Weapon equipWeapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public Clothes equipClothes
        {
            get { return clothes; }
            set { clothes = value; }
        }
    }


    /*
        工廠介面 - 冒險者訓練營
        以下是一個概念或規範，要訓練什麼，怎麼訓練留給子類別實作
    */

    public interface TrainingCamp
    {
        Adventurer trainAdventurer();
    }

    /*
        實體類別 - 弓箭手訓練營
    */

    public class ArcherTrainingCamp : TrainingCamp
    {
        private static EquipFactory factory = new ArcherEquipFactory();

        public Adventurer trainAdventurer()
        {
            Console.WriteLine("訓練一個弓箭手");
            Archer archer = new Archer();
            //...進行基本訓練
            //...弓箭手訓練課程
            //訓練完成，開始裝備武器
            archer.equipWeapon = factory.produceWeapon();
            archer.equipClothes = factory.produceArmor();
            return archer;
        }
    }

    /*
        實體類別 - 鬥士訓練營
    */

    public class WarriorTrainingCamp : TrainingCamp
    {
        private static EquipFactory factory = new WarriorEquipFactory();

        public Adventurer trainAdventurer()
        {
            Console.WriteLine("訓練一個鬥士");
            Warrior warrior = new Warrior();
            //...進行基本訓練
            //...鬥士訓練課程
            //訓練完成，開始裝備武器
            warrior.equipWeapon = factory.produceWeapon();
            warrior.equipClothes = factory.produceArmor();
            return warrior;
        }
    }

    //弓箭手
    public class Archer : Adventurer
    {
        public override void display()
        {
            Console.WriteLine("我是弓箭手，裝備：");
            weapon.display();
            clothes.display();
        }
    }

    //鬥士
    public class Warrior : Adventurer
    {
        public override void display()
        {
            Console.WriteLine("我是鬥士，裝備：");
            weapon.display();
            clothes.display();
        }
    }

}
