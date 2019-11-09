using System;
namespace Interpreter
{
    public abstract class Expression
    {
        public void interpreter(String str)
        {
            if(str.Length > 0)
            {
                String text = str.Substring(1, str.Length-1);
                int number = int.Parse(text);
                excute(number);
            }
        }

        public abstract void excute(int number);
    }

    //如果第一個字為A，數字*2 (Concrete Expression)
    public class UpExpression : Expression
    {
        public override void excute(int number)
        {
            Console.Write(number * 2 + " ");
        }
    }

    public class DownExpression : Expression
    {
        public override void excute(int number)
        {
            Console.Write(number / 2 + " ");
        }
    }
}
