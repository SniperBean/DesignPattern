using System;
namespace Interpreter
{
    //待解譯的資料(Context)

    public class Context
    {
        private String text;

        public String Text
        {
            get { return text; }
            set { text = value; }
        }
    }
}
