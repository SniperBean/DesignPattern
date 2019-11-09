using System;
namespace Command
{
    //訂單(Command)
    public abstract class Order
    {
        protected KitchenWorker receiver;
        protected String name;

        public Order(KitchenWorker receiver)
        {
            this.receiver = receiver;
        }

        public void sendOrder()
        {
            receiver.finishOrder();
        }

        public String getName()
        {
            return this.name;
        }

        public String Name
        {
            get
            { return name; }
            set
            { name = value; }
        }
    }

    //飲料訂單(Concrete Command)
    public class DrinkOrder : Order
    {
        public DrinkOrder(KitchenWorker receiver): base(receiver)
        {
            base.name = "drinkOrder";
        }
    }

    //點心訂單(Concrete Command)
    public class SnackOrder : Order
    {
        public SnackOrder(KitchenWorker receiver) : base(receiver)
        {
        base.name = "snackOrder";
        }
    }
}
