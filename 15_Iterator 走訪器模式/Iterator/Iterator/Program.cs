using System;

/*
    走訪器模式 Iterator
*/

namespace Iterator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IteratorSimpleList list = new IteratorSimpleList();


            list.add("樂高車");
            list.add("超跑");
            list.add("露營車");
            list.add("聯結車");
            list.add("九門轎車");
            list.add("F1賽車");

            foreach (var item in list)
            {
                if(item!=null)
                    Console.WriteLine(((SimpleList)item).ToString());
            }
        }
    }
}
