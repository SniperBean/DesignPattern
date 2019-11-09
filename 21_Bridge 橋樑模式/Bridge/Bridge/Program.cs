using System;

/*
    橋接器模式 Bridge
    目的: 將抽象介面與實作介面切開，使兩者可以各自變化而不以想彼此。
    今天要設計一個郵件系統，依限時送達我們分成了普通信件與限時信件。
    這時又有分掛號信要請收件人簽收，在普通信件與限時信件中又各自分出了非掛號信與掛號信。
    這時就有2*2的情況，但如果系統又要加入一個雙掛號信，要對方簽收以後還要郵差回來請收信者簽名後寄回。
    架構就變成2*3，此時我們又將普通信件與限時信件再加上一個特急件，保證六小時送達。
    此時就會再新增一個維度變成3*3，這時類別的數量一不小心就變得跟山一樣高。

    為了改善這種情況，我們將寄信這個動作抽出成為一個新的實體，信件就變成了到達時間+寄信兩者的組合。
    這就是橋接器模式。
*/

namespace Bridge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========橋接器模式-測試========");
            Console.WriteLine("---非限時信件---");
            MailSender mailSender = new NormalMail(new NoRegisterMail());
            mailSender.send();
            mailSender = new NormalMail(new RegisterMail());
            mailSender.send();


            Console.WriteLine("---限時信件---");
            mailSender = new PromptMail(new NoRegisterMail());
            mailSender.send();
            mailSender = new PromptMail(new RegisterMail());
            mailSender.send();
        }
    }
}
