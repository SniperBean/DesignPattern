using System;

/*
    樣板模式 Template
    目的: 定義一套演算法的架構，但是細節可以延遲到子類別再決定。

    迷宮探險對冒險者來說是一個重要的活動，這邊我們就來寫一套迷宮系統，冒險者進入移工探險到完成的步驟如下:

    1.確定冒險者等級是否到達迷宮門檻。
    2.冒險者達到門檻才產生迷宮(每個迷宮都長的不一樣)
    3.冒險者進行探險(這邊先不管冒險者的過程)
    4.計算探險結果

    以上可以看出冒險者來到迷宮到離開的結算成果大致是一樣的。
    首先先有迷宮樣板MazeTemplate的一個抽象類別。
    產生迷宮的程式createMaze()在樣板中並沒有實作出來。
    由EazyMaze類別中可以看到需要時做的類別共有兩個部分，第一個是建構子中需要設定難度，再來是實作createMaze()方法來產生迷宮。

    掛鉤(hook)
    之前在裝飾者模式中，裝飾者對被裝飾的對象進行裝飾。
    讓被裝飾者動態的新增一些功能，在樣板模式中，我們可以利用掛鉤(hook)的方式增加功能。
    例如只有少數迷宮有的隱藏迷宮，因此進入隱藏迷宮hiddenMaze()預設不會被呼叫。

    這邊的實作可以看MazeTemplate中有一個isDoubleMaze參數，這個參數就是掛鉤。
    初始值為false，代表hiddenMaze()預設不被呼叫。
*/

namespace Template
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //樣板模式-測試
            Adventurer saber = new Saber();
            Adventurer justice = new Gundam();

            MazeTemplate eazyMaze = new EazyMaze();
            MazeTemplate hardMaze = new DifficultyMaze();

            Console.WriteLine("========樣板模式測試========");

            Console.WriteLine("====困難迷宮====");
            saber = hardMaze.adventure(saber);
            Console.WriteLine("====簡單迷宮練功====");
            saber = eazyMaze.adventure(saber);

            //劍士練功後可以進行困難迷宮
            Console.WriteLine("====困難迷宮====");
            saber = hardMaze.adventure(saber);
            justice = hardMaze.adventure(justice);
        }
    }
}
