using System;
namespace ChainOfResponsibility
{
    //提出申請(Request)

    public class ApplyRequest
    {
        //申請類別
        private String requestType;
        //申請內容
        private String requestContent;
        //申請數
        private int requestCount;

        public String RequestType
        {
            get { return requestType; }
            set { this.requestType = value; }
        }

        public String RequestContent
        {
            get { return requestContent; }
            set { this.requestContent = value; }
        }

        public int RequestCount
        {
            get { return requestCount; }
            set { this.requestCount = value; }
        }
    }
}
