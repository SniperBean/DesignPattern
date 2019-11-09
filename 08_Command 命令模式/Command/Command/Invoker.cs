using System;
using System.Collections.Generic;

namespace Command
{
    //Invoker
    public class Waitress
    {
        private int snackQty = 2; // 製作點心的原料
        private int drinkQty = 4; // 飲料剩餘的杯數
        private List<Order> orderList = new List<Order>();


        //服務生接收訂單
        public void setOrder(Order order)
        {
            if(order.Name.Equals("snackOrder"))
            {
                if(snackQty <= 0)
                {
                    Console.WriteLine("點心賣完了");
                }
                else
                {
                    Console.WriteLine("增加點心訂單");
                    snackQty--;
                    orderList.Add(order);
                }
            }

            if (order.Name.Equals("drinkOrder"))
            {
                if (drinkQty <= 0)
                {
                    Console.WriteLine("飲料賣完了");
                }
                else
                {
                    Console.WriteLine("增加飲料訂單");
                    drinkQty--;
                    orderList.Add(order);
                }
            }
        }

        //取消訂單
        public void cancelOrder(Order order)
        {
            if (order.Name.Equals("snackOrder"))
            {
                snackQty++;
                Console.WriteLine("取消一份點心");
            }

            if(order.Name.Equals("drinkOrder"))
            {
                drinkQty++;
                Console.WriteLine("取消一杯飲料");
            }
        }

        //當訂單送到廚房
        public void notifyWoker()
        {
            foreach (Order order in orderList)
            { order.sendOrder(); }
            orderList.Clear();
        }

    }


}
