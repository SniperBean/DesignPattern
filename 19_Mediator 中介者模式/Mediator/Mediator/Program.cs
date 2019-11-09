using System;

/*
    中介者模式 Mediator
    目的: 當有多個物件之間有交互作用，使用一個中介物件來負責這些物件的交互以降低這些物件之間的耦合。

    如果今天分別有A,B,C,D彼此聊天，像是A跟B聊天，B跟D聊天，D又同時跟A,C聊。
    他們之間的關係會變得很混亂，如果可以將訊息郊遊一個中介者(Mediator)處理，
    程式架構就會比較清楚，並且可以切開ABCD之間的交互耦合。
*/

namespace Mediator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========中介者模式-測試========");

            Messager jacky = new VIPUser("Jacky");
            Messager huant = new VIPUser("Huant");
            Messager neil = new CommonUser("Neil");

            MessageMediator.joinChat(jacky);
            MessageMediator.joinChat(huant);
            MessageMediator.joinChat(neil);

            Console.WriteLine("---VIP會員直接送訊息給所有人---");
            jacky.sendToAll("安安！ 26歲 基隆男");

            Console.WriteLine("---私下密語---");
            jacky.send("走啦～去看附醜者聯盟啊！", huant);
            neil.send("收假了！掰～", jacky);

            Console.WriteLine("---非VIP會員想尬廣---");
            neil.sendToAll("幹你娘雞掰勒！不想收假啊！！！！！！！");

        }
    }
}
