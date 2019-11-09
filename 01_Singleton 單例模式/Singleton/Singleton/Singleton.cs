using System;

/*
    假如建立這個物件需要耗費很多資源，但運行中不一定需要它。
    我們希望只有在第一次GetInstance被呼叫的時候才花費資源來建立物件，程式碼可以修改如下。
*/

namespace Singleton
{
    public class Singleton
    {
        //一開始不先建立物件，因為很花資源。
        private static Singleton instance;

        private Singleton()
        {
            //跑很多code
            //建立物件需要花費很多資源
        }

        public static Singleton GetSingleton()
        {
            //第一次被呼叫的時候，instance為null，要建立物件
            if (instance == null)
             instance = new Singleton(); 

            //已經有物件存在，直接回傳這個物件
            return instance;
        }
    }
}
