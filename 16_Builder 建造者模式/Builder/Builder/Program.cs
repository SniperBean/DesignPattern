using System;

/*
    建造者模式 Builder
    目的: 將一個由各種組件組合的複雜產品建造過程封裝

    建造者模式其實就像再隔了一層指揮者(Director)的抽象工廠類別，像我們以下範例。
    一個機器人(Product)由外型(Form)、動力(Power)、武器(Weapon)所組成。
    GundamBuilder就像抽象工廠的實體，可以生產出一個機器人所有的組件。
    與抽象工廠類別不同的是，在建造者模式中我們會用一個指揮者來控制小物件如何組裝成一個大物件的順序。
*/

namespace Builder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========建造者模式測試========");
            Director director = new Director(new GundamBuilder());
            IRobot robot = director.builderRobot();
            robot.display();
        }
    }
}
