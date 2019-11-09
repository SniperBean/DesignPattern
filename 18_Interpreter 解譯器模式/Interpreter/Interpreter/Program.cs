using System;

/*
    解譯器模式 Interpreter

    目的: 定義一個語言與其文法，使用一個解譯器來表示這個語言的敘述

    解譯器模式就是將一個有規則的文字依照規則將他的真正意思解釋就來，簡單來說就是翻譯工具。
    以下面例子解釋資料:

    ・以空白分段，每段開頭為字母A或B，之後接一串數字(ex. A122 B11 A178)
    ・如果開頭為A，請將後面的數字*2
    ・如果開頭為B，請將後面的數字/2

    因此我們需要一個Context來存放待解釋資料，然後一個Expression介面規範解譯器該有什麼功能。
    藉由不同的Expression來擴充解釋能力。
*/

namespace Interpreter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Expression expression;
            Console.WriteLine("========解譯器模式-測試========");

            Context context = new Context();
            context.Text = "A4461 B1341 A676 B1787";

            Console.WriteLine("待解譯內容: " + context.Text);
            Console.WriteLine("---解譯結果---");

            string[] sArray = context.Text.Split(' ');
            foreach(String str in sArray)
            {
                if (str[0] == 'A')
                { expression = new UpExpression(); }
                else
                { expression = new DownExpression(); }

                expression.interpreter(str);
            }
        }
    }
}
