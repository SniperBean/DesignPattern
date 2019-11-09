using System;
namespace Visitor
{
    //指定菜餚-拜訪者
    public interface Visitor
    {
        void cook(SuperChef superChef);
        void cook(DarkChef darkChef);
        void cook(SuperNoodleChef superNoodleChef);
    }

    public class Visitor_tofu : Visitor
    {
        public void cook(SuperChef chef)
        {
            Console.WriteLine(chef.GetType().Name + " : 熊帽豆腐");
        }

        public void cook(DarkChef chef)
        {
            Console.WriteLine(chef.GetType().Name + " : 豆腐三重奏");
        }

        public void cook(SuperNoodleChef chef)
        {
            Console.WriteLine(chef.GetType().Name + " : 鐵桿臭豆腐");
        }
    }

    public class Visitor_saoMai : Visitor
    {
        public void cook(SuperChef chef)
        {
            Console.WriteLine(chef.GetType().Name + " : 宇宙大燒賣");
        }

        public void cook(DarkChef chef)
        {
            Console.WriteLine(chef.GetType().Name + " : 魔幻鴉片燒賣");
        }

        public void cook(SuperNoodleChef chef)
        {
            Console.WriteLine(chef.GetType().Name + " : 鐵桿50人份燒賣");
        }
    }
}
