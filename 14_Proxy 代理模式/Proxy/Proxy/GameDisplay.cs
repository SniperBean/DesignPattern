using System;
namespace Proxy
{
    public interface GameDisplay
    {
        void display();
    }

    public class RealGameDisplay : GameDisplay
    {
        public void display()
        {
            Console.WriteLine("顯示遊戲畫面");
        }
    }

    //代理類別
    public class ProxyGameDisplay : GameDisplay
    {
        private RealGameDisplay realGameDisplay;

        public ProxyGameDisplay(RealGameDisplay realGameDisplay)
        {
            this.realGameDisplay = realGameDisplay;
        }

        public void display()
        {
            Console.WriteLine("遊戲讀取中...請稍候");
            realGameDisplay.display();
        }
    }
}
