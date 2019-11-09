using System;

/*
    備忘錄模式 Memento
    目的: 將一個物件的內部狀態儲存在另外一個備忘錄中，備忘錄可用來還原物件狀態。

    備忘錄模式其實就是備份或存檔的概念。
    下面我們用打魔王小遊戲來模擬，在戰鬥前有個複雜神秘的密技可以降低魔王的攻擊。
    不過因為太複雜了，所以使用後我們就先使用備忘錄物件(Memento)將魔王的狀態儲存。
    當戰鬥不順利的時候需要重來時我們就可以使用Memento將魔王的狀態恢復到開打之前。
*/

namespace Memento
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========備忘錄模式-測試========");

            Console.WriteLine("");
            GameRole boss = new GameRole();
            boss.display();


            Console.WriteLine("使用複雜的密技降低Boss攻擊力");
            boss.ATK = 60;

            //趕快存檔
            RoleStateCateTaker rsc = new RoleStateCateTaker();
            rsc.setSave(boss.save());
            boss.display();

            //開打
            boss.fight();
            boss.display();

            //隊伍太廢，倒了一半，快速讀取剛才的存檔
            boss.load(rsc.getSave());
            Console.WriteLine("重新讀檔！");
            boss.display();
        }
    }
}
