using System;

/*
    拜訪者模式 Visitor
    目的: 用不同的拜訪者使用集合(Collection)中的元素行為與元素類別切離。

    C#中Collection是非常好用的東西，可以透過泛型(Generic)裝進同一個父類。
    缺點就是物件的行為也被綁死了，為了使用類別在集合中還能保持自己的特性。
    使用拜訪者模式將物件行為封裝。

    今天中華料理大賽，分別有來自特級廚師、黑暗料理界、特級麵點師傅。
    三個陣營的廚師(Interface)參加比賽，參加者都要加入參賽者名單(Collection)。
    夾如第一場比賽題目是燒賣，每個廚師做出來的燒賣又長得不太一樣。
    這種情況用程式模擬很簡單，只要讓每個廚師分別實作燒賣這個方法，集合內的廚師只要一個呼叫就可以。
    但接下來又有第二道題目要做豆腐，又要再新增一個方法。
    假如比賽題目不段增加，我們就必須不段修改廚師集。
    這樣的程式碼下若有10到題目就要新增10個if else判。
    廚師介面也要新增這些題目，當然每個實作類別也要修改。

    為了避免這種可怕的狀況，這邊比賽題目抽出來成為拜訪者(Visitor)。
    做燒賣這動作則是給實作拜訪者的類別，我們每個陣營將每個陣營的廚師燒賣方法教給燒賣拜訪者來實現。
    接下來比賽不斷增加，我們只要一職增加實體拜訪者(Concrete Visitor)就好。
    不需要修改廚師集合的內容。
    例如今天第二道題目是做豆腐料理，那我們只要新增一個拜訪者即可。

*/

namespace Visitor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========拜訪者模式-測試========");
            ChefGroup chefGroup = new ChefGroup();
            chefGroup.join(new SuperChef("小當家"));
            chefGroup.join(new DarkChef("紹安"));
            chefGroup.join(new SuperNoodleChef("解師傅"));

            Console.WriteLine("---第一回合 : 燒賣");
            Visitor round1 = new Visitor_saoMai();
            chefGroup.topic(round1);

            Console.WriteLine("---第一回合 : 豆腐");
            Visitor round2 = new Visitor_tofu();
            chefGroup.topic(round2);
        }
    }
}
