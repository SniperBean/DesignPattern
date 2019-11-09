using System;

/*
    命令模式 Command
    目的：將各種請求(命令Command)封裝成一個物件

    客戶端(Client)不直接發送請求給命令執行者(Receiver)，而是將請求都交給接收者(Invoker)
    再由接收者專交給命令執行緒，接收者可以將請求排成工作序列，也可以移除尚未執行的請求。

    冒險者解完任務來到酒吧，首先外場有可愛的女服務生(Invoker)接受冒險者(Client)填的點餐訂單(Command)
    目前酒吧販售的有飲料跟點心兩種產品，因此訂單也分成了飲料訂單(Concrete Command)跟點心訂單(Comcrete Command)兩種
    全部的訂單都是由廚房人員(Receiver)來負責處理，飲料訂單由飲料小弟(Concrete Receiver)處理，點心師傅(Concrete Receiver)則負責做點心。

    如此專業的分工的好處就是廚房人員不必直接跟冒險者接觸，不用面對客人各種神奇的需求而專注在工作上。
    點餐時服務生小妹也可以檢查目前的食材是否足夠，不夠的話就不需要麻煩廚房人員，在訂單送出前讓冒險者取消訂單。
*/

namespace Command
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========命令模式測試========");
            //開店準備
            Chef snackChef = new Chef();
            Barkeep barkeep = new Barkeep();
            Order snackOrder = new SnackOrder(snackChef);
            Order drinkOrder = new DrinkOrder(barkeep);
            Waitress cuteGirl = new Waitress();
            Console.WriteLine("====客人點餐====");

            //開始營業
            cuteGirl.setOrder(snackOrder);
            cuteGirl.setOrder(snackOrder);
            cuteGirl.setOrder(drinkOrder);
            cuteGirl.setOrder(drinkOrder);

            //飲料還沒賣完
            cuteGirl.setOrder(drinkOrder);
            Console.WriteLine("====客人取消點心測試====");
            //取消一個點心
            cuteGirl.cancelOrder(snackOrder);
            cuteGirl.setOrder(snackOrder);
            Console.WriteLine("====驗餐完成，送單至廚房");
            cuteGirl.notifyWoker();
            Console.WriteLine("");
            Console.WriteLine("====點心庫存不足測試====");
            cuteGirl.setOrder(snackOrder);
        }
    }
}
