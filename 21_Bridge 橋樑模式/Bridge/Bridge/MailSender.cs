using System;
namespace Bridge
{

    public abstract class MailSender
    {
        protected Mail mail;

        private MailSender() { }

        public MailSender(Mail mail)
        {
            this.mail = mail;
        }

        abstract public void send();
    }

    public class NormalMail : MailSender
    {
        public NormalMail(Mail mail):base(mail)
        {
        }

        public override void send()
        {
            Console.WriteLine(">>信件寄出後3~5天內抵達 ");
            base.mail.registerState();
        }
    }

    public class PromptMail : MailSender
    {
        public PromptMail(Mail mail) : base(mail)
        {
        }

        public override void send()
        {
            Console.WriteLine(">>信件寄出後24小時內抵達 ");
            base.mail.registerState();
        }
    }
}
