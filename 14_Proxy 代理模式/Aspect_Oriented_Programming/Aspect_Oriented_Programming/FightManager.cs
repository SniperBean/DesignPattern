using System;
using System.Globalization;

//戰鬥管理類別

namespace Aspect_Oriented_Programming
{
    public class FightManager
    {
        public virtual void doFight(String userName)
        {
            //Console.WriteLine("開始時間: " + new DateTime().ToLongDateString());
            //可以直接插入上述程式碼，但這污染了本來只負責戰鬥管理的doFight方法

            Console.WriteLine(userName + " 帶領冒險者們與無辜的怪物戰鬥");
            Console.WriteLine("...以下省略戰鬥過程");
            Console.WriteLine(userName + " 帶領冒險者們洗劫了怪物的家，結束一場慘無妖道的屠殺");
        }
    }

    //戰鬥管理類別
    public class ProxyFightManager : FightManager
    {
        private FightManager source;

        public ProxyFightManager(FightManager source)
        {
            this.source = source;
        }

        public override void doFight(String userName)
        {
            
            Console.WriteLine("開始時間: " + DateTime.Now.ToLocalTime());
            //這段只是記錄時間用，與戰鬥過程沒關係。
            source.doFight(userName);
        }
    }
}
