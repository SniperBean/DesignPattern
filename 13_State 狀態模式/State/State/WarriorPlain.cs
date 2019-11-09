using System;

/*
    WarriorPlain實作類別尚未使用狀態模式，直接用if-elase來切換狀態。
    假設move方法內的if-else有十幾種，而每項條件都要執行數十行程式，這種狀況下就可以考慮使用狀態模式。
*/

namespace State
{
    //沒用策略模式的鬥士

    public class WarriorPlain
    {
        private int hp;

        public WarriorPlain()
        {
            this.hp = 100;
        }

        public void heal(int heal)
        {
            if (hp == 0)
            {
                hp = 0;
            }
            else
            {
                hp += heal;
            }

            if(hp>100)
            {
                hp = 100;
            }
        }

        public void getDamage(int damage)
        {
            this.hp -= damage;
            if (hp < 0)
            { hp = 0; }
        }

        public void move()
        {
            if(hp==0)
            {
                Console.WriteLine("無法戰鬥");
                //...底下還有十幾行程式碼
                return;
            }


            if (hp > 70)
            {
                Console.WriteLine("一般狀態");
                //...底下還有十幾行程式碼
            }
            else if (hp < 30)
            {
                Console.WriteLine("背水一戰");
                //...底下還有十幾行程式碼
            }
            else
            {
                Console.WriteLine("狂怒狀態");
                //...底下還有十幾行程式碼
            }
        }
    }


}
