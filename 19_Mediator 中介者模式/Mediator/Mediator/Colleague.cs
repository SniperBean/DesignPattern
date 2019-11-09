using System;
namespace Mediator
{
    public abstract class Messager
    {
        private String name;
        public static Mediator mediator = new MessageMediator();
        public Messager(String name)
        {
            this.name = name;
        }

        //發信給所有人
        public virtual void sendToAll(String message)
        {
            mediator.sendToAll(name, message);
        }

        //發信給某人
        public void send(String message, Messager to)
        {
            mediator.send(message, this.name, to);
        }

        public String getName()
        {
            return this.name;
        }
    }

    //可發送訊息的類別
    public class CommonUser : Messager
    {
        public CommonUser(String name) : base(name)
        { }

        public override void sendToAll(String message)
        {
            Console.WriteLine("非VIP用戶不能使用廣播");
        }
    }

    //可發送訊息的類別
    public class VIPUser : Messager
    {
        public VIPUser(String name) : base(name)
        { }
    }
}
