using System;

/*
    代理模式 - 保護模式 Protect Proxy
    寫程式時引用其他人寫好的函式庫(程式庫)來幫助我們做事是很方便的事情，不過缺點就是我們無法改這些引用來的程式碼。
    有些情況我們希望函式庫中的一個類別的某些屬性或方法在特定操作下無法被使用，以免被誤用或亂用。
    可是我們又沒辦法修改引用來的程式碼，這時候我們就可以就由保護代理來達成這件事情。

    以下簡單範例，我們有一個個人資料類別(PersonBeanClass)。
    原始設計是每個人都能增加或減少喜歡的次數，不過現在某些情況下不希望這個次數被修改。
    可是種種原因我們不能修改PersonBean的內容，這時候就可以用一個保護代理ProxyPersonBean來幫助我們達成這件事情。
*/

namespace Protect_Proxy
{
    class MainClass
    {
        //代理模式(保護模式) - 測試
        public static void Main(string[] args)
        {
            Console.WriteLine("========代理模式(保護模式)測試========");

            //沒使用代理
            Console.WriteLine("---沒使用代理---");
            Person realPerson = new PersonBean();
            realPerson.setLikeCount(10);
            Console.WriteLine("like :" + realPerson.getLikeCount());

            //使用代理
            Console.WriteLine("---使用代理---");
            Person proxy = new ProxyPersonBean(new PersonBean());
            proxy.setLikeCount(10);
            Console.WriteLine("like :" + proxy.getLikeCount());
        }
    }
}
