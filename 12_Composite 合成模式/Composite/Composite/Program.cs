using System;

/*
    合成模式 Composite
    目的: 處理樹狀結構的資料

    雙狀結構在程式語言的世界中到處可見，例如資料夾與檔案，HTML的DOM結構。
    樹狀結構從一個Root開始，分支出更多節點Node，節點可能延伸更多的子節點，如果沒有節點則稱為葉Leaf。

    讓我們繼續關注冒險者的世界，經過一段時間的發展，冒險者協會已經在許多城鎮都創立了分會。
    本來的協會成為了總部，分會下面還有子分會。
    另外協會有一個客戶服務單位Service Department來接受委託與處理客訴，另外還有人力資源單位Human Resource來招募冒險者。

    冒險者協會現在的組織圖與上述的結構是相同的，總部是Root，分會是有子節點的Node，客戶服務單位與人力資源單位則為Leaf。
    在合成模式中，Component是一個抽象類別，所有的節點包含Root與Leaf都必需繼承Compoent。
    Component代表有分支的節點，通常會有add()、remove()的方法加入、移除子節點;Leaf表示沒有下一層。
*/

namespace Composite
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========合成模式測試========");

            AbstractAssociation root = new Association("冒險者總會");
            root.add(new HumanResource("總部 - 人力資源單位"));
            root.add(new ServiceDepartment("總部 - 客服單位"));

            AbstractAssociation tw = new Association("臺灣分會");
            tw.add(new HumanResource("臺灣分會 - 人力資源單位"));
            tw.add(new ServiceDepartment("臺灣分會 - 客服部門"));
            root.add(tw);

            AbstractAssociation jp = new Association("日本分會");
            jp.add(new HumanResource("日本分會 - 人力資源單位"));
            jp.add(new ServiceDepartment("日本分會 - 客服部門"));
            root.add(jp);

            AbstractAssociation tk = new Association("日本 東京辦事處");
            tk.add(new HumanResource("東京辦事處 - 人力資源單位"));
            tk.add(new ServiceDepartment("東京辦事處 - 客服部門"));
            jp.add(tk);

            //日本靜岡太偏遠 沒人會來客訴
            AbstractAssociation sz = new Association("日本 靜岡辦事處");
            sz.add(new HumanResource("靜岡辦事處 - 人力資源單位"));
            jp.add(sz);

            Console.WriteLine("結構圖:");
            root.display(1);
            Console.WriteLine("職責表");
            root.lineOfDuty();
        }
    }
}
