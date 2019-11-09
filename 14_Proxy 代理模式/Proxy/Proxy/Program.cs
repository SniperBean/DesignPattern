using System;

/*
    代理模式 Proxy
    目的: 為一個物件提供代理物件
    代理物件常見的用途如下
    ・虛擬代理(Virtual Proxy): 用比較不消耗資源的代理物件來取代實體物件，實體物件只有在真正需要時才被創造。
    ・遠端代理(Remote Proxy): 在本地端提供一個代表物件來存取遠端網址的物件。
    ・保護代理(Protect Proxy): 限制其他程式存取權限。
    ・智能代理(Smart Reference Proxy): 為被代理的物件增加一些動作。

    遊戲讀取中...請稍等
    要開啟我們冒險者遊戲其實需要花費很大一番工膚，如果在讀取的過程就跟國防布ㄧ樣完全沒有畫面，玩家會懷疑這遊戲是不是當機了還是電腦當機了。
    因此我們需要一個代理類別，讓遊戲還沒被讀取完成之前先跟玩家說，遊戲讀取中...請稍等。

    代理模式跟裝飾模式很相似，同樣是用包覆的方式為一個類別增加功能。
    代理模式一般來說一次只包附一層，而裝飾模式可以包覆很多層。
    你可以把裝飾模式當作是特化版的代理模式。
*/

namespace Proxy
{
    class MainClass
    {
        //代理模式(動態代理)-測試
        public static void Main(string[] args)
        {
            Console.WriteLine("========代理模式(動態代理)測試========");

            //未使用代理
            Console.WriteLine("---沒使用代理---");
            new RealGameDisplay().display();
            Console.WriteLine();

            //使用代理
            Console.WriteLine("---使用代理---");
            new ProxyGameDisplay(new RealGameDisplay()).display();
        }
    }
}
