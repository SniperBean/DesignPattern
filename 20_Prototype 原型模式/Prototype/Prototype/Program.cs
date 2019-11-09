using System;

/*
    原型模式 Prototype
    目的: 複製一個物件而不是重新建造一個。

    當需要建立一個新物件時發現有個很相似的物件，想直接複製原有的修改就好。
    這時候就能用原型模式。

    冒險者協會有專門的人力資源部門來管理冒險者的履歷，為了方便冒險者自己更新自己的履歷。
    協會提供方便的複製履歷功能，實作程式碼如下。
    在這邊冒險者的履歷Resume類別與冒險經歷AdventureExperience類別都已經分別實作Cloneable介面，要修感應該可以直接複製一份再來修改。

*/

namespace Prototype
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========原型模式-測試=======");
            Resume resume = new Resume("傑克", "見習道士", 1);
            resume.setExperience("2011/01/01", "仙靈島");

            //履歷表2跟1有很多相似處，因此直接複製履歷表1修改
            Resume resume2 = (Resume)resume.Clone();
            resume2.Level = 5;
            resume2.setExperience("2012/3/31", "隱龍窟");

            //履歷表3跟1有許多相似處，因此直接複製履歷表1修改
            Resume resume3 = (Resume)resume2.Clone();
            resume3.Profession = "殭屍道長";
            resume3.setExperience("2012/11/31", "赤鬼王血池");

            Console.WriteLine("第一份履歷");
            resume.display();
            Console.WriteLine("第二份履歷(複製上一份修改)");
            resume2.display();
            Console.WriteLine("第三份履歷(複製上一份修改)");
            resume3.display();
        }
    }
}
