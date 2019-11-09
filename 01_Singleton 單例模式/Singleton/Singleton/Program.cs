using System;
using System.Threading;

/*
    單例模式 Singleton
    一開始直接new 出類別的實體物件，constructor(建構子)宣告為private，這樣其他程式就無法new出新物件。
    如此一來就能保證這個類別只存在一個實體物件，這種寫法因為一開始已經建立物件，因此也稱為貪婪單例模式(Greed Singleton)。
*/

/*
    以Singleton與SingletonGreed的程式看起來沒問題，但如果有多個執行緒同時呼叫GetInstance時
    可能第一個執行緒跑到instance = new Singleton()這行時，將時間讓給第二個執行緒也只行了instance = new Singleton()
    造成兩個不同的執行緒同時new出新的物件，如此一來就無法保證這個問題只會產生一個物件。
*/

namespace Singleton
{
    
    public class SingletonLock{
        private static SingletonLock instance;

        private SingletonLock()
        {
            //跑了很多程式    
        }

        //多執行緒時保證SingletonLock一定是單一的
        public static SingletonLock GetSingletonLock()
        {
            if (instance == null)
            {
                lock(SingletonLock.instance)
                {
                    if(instance == null)
                    {
                        instance = new SingletonLock();
                    }
                }
            }
            return instance;
        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            
        }
    }
}
