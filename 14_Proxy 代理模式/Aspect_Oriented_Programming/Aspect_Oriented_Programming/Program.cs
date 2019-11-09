using System;

/*
    代理模式的實際應用 - AOP
    AOP全名為Aspect-Oriented Programming，翻譯為"面向物件導向程式設計"，從字面看不出是什麼意思。
    簡單的說所謂的AOP就是在一段程式碼執行前中後插入其他想要執行的程式。

    為什麼不直接插入要執行的程式碼，直接寫進程式碼裡就好？
    假設插入這個程式碼跟我們原本的業務邏輯沒有關係，因此我們希望不要修改原本的業務邏輯，也能達到同樣的效果，這就是AOP的核心概念。

    下面有一個戰鬥管理類別FightManager，doFight這個方法會管理玩家與怪物的每一場戰鬥。
    一開始這個方法只是單純管理玩家與怪物的戰鬥，接下來我們希望在戰鬥開始前標註時間，因此我們加上時間紀錄的程式碼。
    可以發現這段程式碼只是單純的記錄時間，與doFight原本的程式碼關係不大，這時候就可以用代理模式達到這種效果。
*/

namespace Aspect_Oriented_Programming
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========代理模式(AOP)測試========");

            Console.WriteLine("---沒用代理模式");
            FightManager fm = new FightManager();
            fm.doFight("煞氣A豆子");
            Console.WriteLine();

            Console.WriteLine("---使用代理模式");
            FightManager proxyFM = new ProxyFightManager(fm);
            proxyFM.doFight("煞氣A豆子");
            Console.WriteLine();
        }
    }
}
