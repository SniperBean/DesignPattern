using System;
namespace Command
{
    //廚房人員(Receiver)
    public interface KitchenWorker
    {
        //完成訂單
        void finishOrder();
    }

    //飲料小弟(Concrete Receiver)
    public class Barkeep : KitchenWorker
    {
        public void finishOrder()
        {
            Console.WriteLine("拿出杯子->加滿冰塊->把飲料倒進杯子->飲料完成");
        }
    }

    //點心師傅(Concrete Receiver)
    public class Chef : KitchenWorker
    {
        public void finishOrder()
        {
            Console.WriteLine("取出麵包->塗上美乃滋->丟進烤箱->撒上裝飾->點心完成");
        }
    }
}
