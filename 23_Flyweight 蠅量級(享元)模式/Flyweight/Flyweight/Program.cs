using System;

/*
    蠅量級(享元)模式 Flyweight
    目的: 大量物件共享一些共同性質，降低系統的負荷

    一個蠅量級類別包含了內部屬性，也就是所有物件都共用的性。
    另外也有外部性質，這是隨著需求可以變換的性質。

    現在我們有個假日花園系統，每個人都可以來認養一棵。
    不過為了省錢，同一個樹我們只栽種一棵。
    當擁有者來的時候，我們只是要將掛牌上的擁有者名字替換掉，實際上提供的是同一棵樹。

    如果同時有兩個擁有者來的時候怎麼辦？抱歉，我們假日花園採預約。
    每棵樹種一次只開放一個擁有者來參觀。
*/

namespace Flyweight
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========蠅量級模式-測試========");
            Tree rose = TreeManager.getTree("玫瑰");
            rose.setOwner("Rose");
            rose.display();
            Console.WriteLine("Jacky來買一朵玫瑰話");
            Tree jRose = TreeManager.getTree("玫瑰");
            jRose.setOwner("Jacky");
            jRose.display();

            Console.WriteLine();
            Tree hinoki = TreeManager.getTree("臺灣紅檜");
            hinoki.setOwner("林務局");
            hinoki.display();
        }
    }
}
