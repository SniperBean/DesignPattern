using System;

/*
    責任鍊模式 Chain of Responsibility

    目的: 讓不同的物件有機會能處理同一個請求

    這個模式可以用來處理簽核流程，以下面例子來解說。
    員工提出請假申請，如果在2天以下，直屬主管經理就可以批准。
    2~5天則是給更高一階層的主管批准，超過5天則是經由總經理批准。
    另外員工可以提出加薪要求，這時候就由總經理來決定是否要加薪。

    如果提出申請這個動作封裝成一個請求(Requests)類別
    另外可以處理請求的物件則抽出來成為處理者(Handler)介面
    上面那些主管事實作處理介面的實體處理者(ConcreteHandler)

    比起if else來時做上述情況，使用責任鏈的好處是我們可以輕易調整職責鏈。
    例如現在公司要簡化流程，如請假五天以下由直屬主管批准，以上經由總經理批准。
    只要在客戶端重新設定職責鍊就好，不需要改動寫好的經理類別。
*/

namespace ChainOfResponsibility
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========責任鏈模式-測試========");

            Manager pm = new CommonManger("PM經理");
            Manager gl = new MajorManger("總監");
            Manager gm = new GeneralManger("總經理");

            pm.setSuperior(gl);
            gl.setSuperior(gm);

            ApplyRequest request = new ApplyRequest();

            request.RequestType = "請假";
            request.RequestContent = "小菜請假";
            request.RequestCount = 2;
            pm.apply(request);
            request.RequestCount = 4;
            pm.apply(request);
            request.RequestCount = 12;
            pm.apply(request);

            request.RequestType = "加薪";
            request.RequestContent = "小菜加薪";
            request.RequestCount = 2000;
            pm.apply(request);
            request.RequestCount = 999;
            pm.apply(request);
        }
    }
}
