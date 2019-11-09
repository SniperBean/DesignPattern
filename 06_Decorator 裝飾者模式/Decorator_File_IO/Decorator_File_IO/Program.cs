using System;
using System.IO;
using System.Text;

/*
    裝飾者模式實例 File IO

    最著名的裝飾者模式應用，應該就是System.IO這套讀寫檔案的API
    這邊取出幾個System.IO內的類別

    Reader是被裝飾者介面(實際上是抽象類別)，FileReader與InputStreamReader是實作類別
*/

namespace Decorator_File_IO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("========StreamReader讀取檔案========");
                StreamReader streamReader = new StreamReader("test.txt");
                int c = streamReader.Read();
                while (c >= 0)
                {
                    Console.Write((char)c);
                    c = streamReader.Read();
                }

                Console.WriteLine("========ReverseReader讀取檔案========");
                ResverseReader resverseReader = new ResverseReader("Test.txt");
                String rLine = resverseReader.reverseLine();
                while (rLine != null)
                {
                    Console.Write(rLine);
                    rLine = resverseReader.reverseLine();
                }


            }

            catch (IOException e)
            {
                Console.WriteLine(
                    "{0}: The write operation could not " +
                    "be performed because the specified " +
                    "part of the file is locked.",
                    e.GetType().Name);
            }
        }
    }

    public class ResverseReader : StreamReader
    {
        public ResverseReader(String input) : base(input)
        {
            
        }

        public String reverseLine()
        {
            String line = base.ReadLine();
            if (line == null) return null;
                
                return reverse(line);
        }

        public String reverse(String source)
        {
            String result = "";
            for (int i = 0; i < source.Length; i++)
            {
                result = source[i] + result;
            }

            return result;
        }
    }



}
