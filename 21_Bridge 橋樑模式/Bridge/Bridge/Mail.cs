using System;
namespace Bridge
{
    public abstract class Mail
    {
        abstract public void registerState();
    }

    public class NoRegisterMail : Mail
    {
        public override void registerState()
        {
            Console.WriteLine("這是平信不是掛號信，收件人不用簽收");
        }
    }

    public class RegisterMail : Mail
    {
        public override void registerState()
        {
            Console.WriteLine("這是一般掛號信，收件人必須簽收");
        }
    }
}
