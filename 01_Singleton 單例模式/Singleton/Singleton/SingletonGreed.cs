using System;

namespace Singleton
{
    public class SingletonGreed
    {

        //一開始就建立物件，只要一直回傳這個物件就是簡單的singleton
        private static SingletonGreed instance = new SingletonGreed();


         //private constructor(建構子)，new取得新的實體
        private SingletonGreed() { 
        }

        //private constructor(建構子)，new取得新的實體
        public static SingletonGreed GetSingletonGreed()
        { return instance; }
    }
}
