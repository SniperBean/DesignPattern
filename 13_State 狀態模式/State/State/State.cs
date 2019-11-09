using System;
namespace State
{
    //隨著HP變化的狀態(State)

    public interface State
    {
        //傳入Warrior所以狀態可以取得warrior的資料
        void move(Warrior warrior);
    }

    public class NormalState : State
    {
        public void move(Warrior warrior)
        {
            if(warrior.HP > 70)
            {
                Console.WriteLine("HP" + warrior.HP + ", 一般狀態");
            }
            else
            {
                warrior.setState(new DesperateState());
                warrior.move();
            }
        }
    }

    public class DesperateState : State
    {
        public void move(Warrior warrior)
        {
            if (warrior.HP > 70)
            {
                warrior.setState(new NormalState());
            }
            else if(warrior.HP <=30)
            {
                warrior.setState(new FuryState());
                warrior.move();
            }
            else 
            {
                Console.WriteLine("HP" + warrior.HP + ", 背水一戰 傷害增加30%");
            }
        }
    }

    public class FuryState : State
    {
        public void move(Warrior warrior)
        {
            if(warrior.HP > 70)
            {
                warrior.setState(new NormalState());
                warrior.move();
            }
            else if (warrior.HP == 0)
            {
                warrior.setState(new UnableState());
                warrior.move();
            }
            else if (warrior.HP > 30)
            {
                warrior.setState(new DesperateState());
                warrior.move();
            }
            else
            {
                Console.WriteLine("HP" + warrior.HP + ", 狂怒狀態 傷害增加50% 防禦增加50%");
            }
        }
    }

    public class UnableState : State
    {
        public void move(Warrior warrior)
        {
            Console.WriteLine("HP" + warrior.HP + ", 無法戰鬥");
        }
    }
}
