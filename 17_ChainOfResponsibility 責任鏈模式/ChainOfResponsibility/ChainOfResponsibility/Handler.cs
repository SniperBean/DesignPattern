using System;
namespace ChainOfResponsibility
{
    //觀禮者(Handler)

    public abstract class Manager
    {
        protected String name;

        //上一級管理者
        protected Manager superior;

        public Manager(String name)
        {
            this.name = name;
        }

        public void setSuperior(Manager superior)
        {
            this.superior = superior;
        }

        public abstract void apply(ApplyRequest request);
    }

    //經理(Concrete handler)
    public class CommonManger : Manager
    {
        public CommonManger(String name) : base(name) { }

        public override void apply(ApplyRequest request)
        {
            if (request.RequestType.Equals("請假") && request.RequestCount <= 2)
            {
                Console.Write(request.RequestType + ":" + request.RequestContent);
                Console.WriteLine(" " + request.RequestCount + " 天 " + name + "批准");
            }
            else
            {
                if (superior != null)
                { superior.apply(request); }
            }
        }
    }

    //總監(Concrete handler)
    public class MajorManger : Manager
    {
        public MajorManger(String name) : base(name) { }

        public override void apply(ApplyRequest request)
        {
            if (request.RequestType.Equals("請假") && request.RequestCount <= 5)
            {
                Console.Write(request.RequestType + ":" + request.RequestContent);
                Console.WriteLine(" " + request.RequestCount + " 天 " + name + "批准");
            }
            else
            {
                if (superior != null)
                { superior.apply(request); }
            }
        }
    }

    //總經理(Concrete handler)
    public class GeneralManger : Manager
    {
        public GeneralManger(String name) : base(name) { }

        public override void apply(ApplyRequest request)
        {
            if (request.RequestType.Equals("請假"))
            {
                Console.Write(request.RequestType + ":" + request.RequestContent);
                Console.WriteLine(" " + request.RequestCount + " 天 " + name + "批准");
            }
            else
            {
                if (request.RequestType.Equals("加薪") && request.RequestCount <= 1000)
                {
                    Console.Write(request.RequestType + ":" + request.RequestContent);
                    Console.WriteLine(" " + request.RequestCount + " 元 " + name + "批准");
                }
                else
                {
                    Console.Write(request.RequestType + ":" + request.RequestContent);
                    Console.WriteLine(" " + request.RequestCount + " 元 " + name + "駁回");
                }


            }
        }

    }
}
