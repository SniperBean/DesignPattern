using System;

/*
    狀態模式 State
    目的:將物件的狀態封裝成類別，讓此物件隨著狀態改變時有不同的行為。

    所謂的鬥士就是生命力越低越有戰鬥力
    很多事物的行為模式都會隨著狀態而改變，例如毛毛蟲可只能在地上爬，變成蛹之後不會動，破蛹而出變成會飛的蝴蝶。
    一開始我們會用if-else或switch來實現這些狀態的而改變行為，不過根據<重構: 改善既有程式的設計>一書的說法。
    當你程式出現一堆if-else或switch這種判斷模式，你的程式碼已經走向腐敗的階段，要避免這種寫法。

    狀態模式就是會將改變的狀態封裝成類別，這樣可以減少一些判斷式。
    也可以實現不同責任交由狀態類別的分擔。
    一個狀態模式會有一個(Context)，Context的行為模式會隨著狀態(State)而改變，因此我們需要一個狀態介面(State)跟其他實體狀態類別(Concrete State)。

    鬥士是一個很有趣的冒險者，他的生命值會隨著HP的下降而提升HP>70%時毫無反應，<70%時進入背水一戰，<30%進入狂暴模式，而HP歸零也無法進入戰鬥的狀態。
    
*/

namespace State
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            warrior.setState(new NormalState());
            warrior.move();

            warrior.getDamage(30);
            warrior.move();
            warrior.getDamage(50);
            warrior.move();

            warrior.heal(120);
            warrior.move();

            warrior.getDamage(110);
            warrior.move();
        }
    }
}
