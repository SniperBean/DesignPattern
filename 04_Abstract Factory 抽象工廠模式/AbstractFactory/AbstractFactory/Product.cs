using System;

//這裏程式碼就偷懶只做冒險者的上衣與武器

namespace AbstractFactory
{
    /* 
        上衣介面
    */
    public abstract class Clothes
    {
        protected int def;
        public int Def
        {
            get { return def; }
            set { def = value; }
        }
        public void display()
        {
            Console.WriteLine(typeof(Clothes).Name + " - " + this.GetType().Name +  " def = " + def);
        }
    }

    //盔甲(Concrete Product)鬥士上衣
    public class Armor : Clothes
    {
        
    }

    //皮甲(Concrete Product)弓箭手上衣
    public class Leather : Clothes
    {
        
    }

    /*
        武器介面
    */

    public abstract class Weapon
    {
        protected int atk;
        protected int range;

        public int Atk
        {
            get { return atk; }
            set { atk = value; }
        }

        public int Range
        {
            get { return range; }
            set { range = value; }
        }

        public void display()
        {
            Console.WriteLine(typeof(Weapon).Name + " - " + this.GetType().Name + " atk = " + atk + " range = " + range);
        }
    }

    //長劍(Concrete Product)鬥士武器
    public class LongSword : Weapon
    {

    }

    //弓(Concrete Product)弓箭手武器
    public class Bow : Weapon
    {
        
    }

}
