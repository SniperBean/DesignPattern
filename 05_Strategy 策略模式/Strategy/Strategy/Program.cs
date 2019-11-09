using System;

/*
    經過新手訓練，冒險者出了村莊面臨各種怪物，冒險者需要選擇不同的戰鬥策略(Strategy)來跟各種怪物戰鬥。
    例如一班的小怪隨便砍個幾刀就好，遇到強一點的怪就需要放技能造成大量傷害，遇到刀槍不入殭屍則可能要用火燒。

    在策略模式中，會有規範用的策略介面(Strategy)，各種實際上的戰鬥策略則是實體策略(Concrete Srategy)，使用策略的冒險者則是環境類別(Context)。
*/

namespace Strategy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Adventurer adventurer = new Adventurer();

            //遇到史萊姆用普通攻擊就可以了
            Console.WriteLine("出現史萊姆");
            adventurer.choiceStrategy(new NormalAttack());
            adventurer.attack();
            Console.WriteLine("");

            //遇到厲害的敵人需要用技能攻擊
            Console.WriteLine("出現冥王黑帝斯");
            adventurer.choiceStrategy(new UseSkill());
            adventurer.attack();
            Console.WriteLine("");

            //遇到刀槍不入的殭屍要用火燒
            Console.WriteLine("出現野生的殭屍");
            adventurer.choiceStrategy(new UseItem());
            adventurer.attack();
            Console.WriteLine("");
        }
    }
}
