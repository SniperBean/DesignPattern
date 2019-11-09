using System;

/*
    觀察者模式 Observer
    
    目的:處理一個物件對應多個物件之間的連動關係。
    當一個被觀察物件(Subject)改變時，其他的觀察者物件(Observer)都會收到通知並且執行對應的動作。

    冒險者協會定期會發布一些任務讓整天無所事事的冒險者有事情做。
    避免閒置人口太多，當協會發布任務通知時，每一名關注協會的冒險者就會接收到訊息並且做對應的回應。
    發布/訂閱就是觀察者模式的核心概念，協會為被觀察者的主題(Subject)，冒險者則為關切主題的觀察者(Observer)
*/

namespace Observer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========觀察者模式測試========");

            //冒險者們
            Adventurer lancer = new Lancer("Jacky");
            Adventurer lancer2 = new Lancer("Seven");
            Adventurer bard = new Bard("Lee");
            Adventurer gunman = new Gunman("LongWu");

            //冒險者協會
            Subject association = new Association();
            association.add(lancer);
            association.add(lancer2);
            association.add(bard);
            association.add(gunman);

            Console.WriteLine("---協會派來簡單任務---");
            association.sendQuestions("打一隻屎萊姆");
            Console.WriteLine();

            Console.WriteLine("---協會派來複雜任務---");
            association.sendQuestions("打倒巴哈姆特並取得巴哈姆特的心臟");
            Console.WriteLine();

            //Seven不想接到任務了
            association.remove(lancer2);
            Console.WriteLine("---協會派來複雜任務(Seven已經不在名單中)---");
            association.sendQuestions("打倒巴哈姆特並取得巴哈姆特的心臟");
        }
    }
}
