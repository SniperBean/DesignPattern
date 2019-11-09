using System;

/*
    裝飾者模式 Decorator
    
    遊戲中，冒險者可以透過稱號加強本身的能力，如「強壯的帽顯者」攻擊力比較高，「堅毅的冒險者」生命力比較高。
    一開始我們可能需要一個冒險者介面，然後每一個稱號都是實作冒險者介面的子類別實現這樣的架構。
    不過冒險者可以取得很多稱號，如「強壯的堅毅的敏捷的冒險者」、「強撞飛翔的冒險者」等等的交叉的排列組合，如果有三種稱號就要建立3*2*1=6個子類別。
    如果有5種就多達5*4*3*2*1=120種組合，這還沒有算上冒險者可以重複的稱號的情況如「強壯的強壯的冒險者」，那就要建立的子類別就夠多了。

    為了避免上面這種很可怕的事情發生，這邊可以使用裝飾者模式來處理。
    首先抽象的冒險者介面在裝飾者模式中就是被裝飾者(Compnent)，增加能利用的稱號介面Title則是裝飾者(Decorator)；
    當然實際上使用會有實作的冒險者類別，這邊就是長槍兵(Lancer)類別，真正讓我們的小長槍兵變得強大的事實作稱號介面的實體稱號類別。
    你可以想像實體稱號類別包覆了長槍兵類別，使他有更強大的能力。

    下面三行程式碼來看：
    1. Adventurer lancer = new Lancer("Jacky");
    2. TitleStrong sJacky = new TitleStrong(lancer);
    3. TitleAgile aJacky = new TitleAgile(sJacky);

    以程式碼結構來看就會像這樣(Agile(Strong(lancer))) 敏捷的強壯的傑克。
    第一句話我們建立了一個普通的長槍兵Jacky
    第二句我們讓Jacky取得了TitleStrong的稱號
    第三句TitleAgile包覆了強壯的長槍兵
    因此現在的Jacky是敏捷強壯的長槍兵！
*/

namespace Decorator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("===========裝飾者模式測試===========");

            Adventurer lancer = new Lancer("Jacky");
            Console.WriteLine("---長槍兵Jacky---");
            lancer.attack();

            Console.WriteLine("");
            Console.WriteLine("---取得強壯稱號的Jacky---");
            TitleStrong sJacky = new TitleStrong(lancer);
            sJacky.attack();

            Console.WriteLine("");
            Console.WriteLine("---取得敏捷稱號的Jacky---");
            TitleAgile aJacky = new TitleAgile(sJacky);
            aJacky.attack();


            Console.WriteLine("");
            Console.WriteLine("---取得燃燒稱號的Jacky---");
            TitleInFire fJacky = new TitleInFire(aJacky);
            fJacky.attack();
            fJacky.fireball();

            Console.WriteLine("");
            Console.WriteLine("---Jacky決定成為一位非常強壯的槍兵---");
            TitleStrong ssJacky = new TitleStrong(fJacky);
            ssJacky.attack();
        }
    }
}
