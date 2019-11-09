using System;

/*
    轉接器模式 Adapter

    目的: 將一個介面轉換成另一個介面，讓原本與客戶端不相容的介面可以正常工作。
    轉接器讓USB轉為micro USB，三孔插座轉兩孔，220V變壓後轉110V之類的，生活中到處都有轉接器。

    今天有一群冒險者們很開心的組隊出門要來解任務，走到一半他們才發現需要一個法師丟火球才能完成任務。
    如果跑回村莊重新招募一個會丟火球的法師，那之前的路途都白跑了。
    還好他們之中有一個弓箭手，只要將弓箭包上布，點火射出去，就彷彿是丟火球一般。

    這就是一套轉接器的實現，弓箭手是被轉接者(Adaptee)，法師是轉接後的介面，當然還有負責轉接工作的轉接器(Adapter)
*/

namespace Adapter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========轉接者模式測試========");
            Console.WriteLine("我們需要火球才能把樹上的蜂窩燒毀！糟糕的是我們隊伍中沒有法師");
            Console.WriteLine("幸好我們隊伍有弓箭手跟馬蓋先工具包，讓弓箭手也能發射火球");
            Wizard wizard = new Adapter(new NormalArcher());
            wizard.fireBall();

            //與06 裝飾者模式 Decorator的結合
            /*
                以下代碼可以看出，讓裝飾模式與轉接器模式在客戶端的呼叫是一樣的
                差別在裝飾者模式不會改變被裝飾的介面，轉接器模式則是這轉接的介面換成目標介面
            */

            /* ****
             * 冒險者使用不同稱號來強化 - 測試(裝飾模式)
               public class TitleSet 
               {
                    public void Test()
                    {
                        Console.Write("---取得強壯稱號的Jacky---');
                        TitleStrong sJacky = new TitleStrong(new Lancer("Jacky"));
                        sJacky.attack();
               }
               
             * 弓箭手轉接成法師丟火球 - 測試 (轉接器模式)

                public class AdapterClient
                {
                    public void test()
                    {
                        Wizard = new Adapter(new NormalArcher());
                        wizard.fireBall();
            */
        }
    }
}
