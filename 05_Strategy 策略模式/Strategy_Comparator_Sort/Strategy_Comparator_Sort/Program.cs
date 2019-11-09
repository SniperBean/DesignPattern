using System;
using System.Collections;
using System.Collections.Generic;

/*
    在C#提供的API中可以找到策略模式的實用應用，Collection類別提供了sort這個方法來對應一群資料進行排序。
    讓我們看看這個方法的宣告:
        Collections.sort(List list,Comparer<? super T>c)
        sort 方法接受兩個參數，第一個為要排序的List，第二個是Comparer，Comparer裡面的演算法決定如何排序清單中的資料，不同的是Comparer在這邊就是不同的策略。

        從這裡可以看到三個村莊，分別以ID排序的Comparer(SortVillageById)、以名稱排序的Comparer(SortVillageByName)、以人口排序的的Comparer(SortVillageByPopulation)傳入sort
        對清單中的村莊進行排序。
*/

namespace Strategy_Comparator_Sort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Village appleFarm = new Village(3, "apple farm", 32, 5.1);
            Village barnField = new Village(1, "barn field", 22, 1.7);
            Village capeValley = new Village(2, "cape valley", 10, 10.2);

            List<Village> villages = new List<Village>();
            villages.Add(appleFarm);
            villages.Add(barnField);
            villages.Add(capeValley);

            Console.WriteLine("沒排序過的資料");
            villages.ForEach(Console.WriteLine);

            Console.WriteLine("根據ID排序");
            villages.Sort(new SortVillageById());
            villages.ForEach(Console.WriteLine);

            Console.WriteLine("根據名字排序");
            villages.Sort(new SortVillageByName());
            villages.ForEach(Console.WriteLine);

            Console.WriteLine("根據人口排序");
            villages.Sort(new SortVillageByPopulation());
            villages.ForEach(Console.WriteLine);

            Console.WriteLine("根據面積排序");
            villages.Sort(new SortVillageByName());
            villages.ForEach(Console.WriteLine);

        }
    }
}
