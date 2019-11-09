using System;
namespace Decorator
{
    public abstract class Adventurer
    {
        public abstract void attack();
    }

    public class Lancer : Adventurer
    {
        private String name;

        public Lancer(String name)
        {
            this.name = name;
        }

        public override void attack()
        {
            Console.WriteLine("長槍兵攻擊 by " + name);
        }
    }

    /*
      稱號介面
    */

    public abstract class Title : Adventurer
    {
        //被裝飾的冒險者
        protected Adventurer adventurer;

        public Title(Adventurer adventurer)
        {
            this.adventurer = adventurer;
        }

        public override void attack()
        {
            adventurer.attack();
        }
    }

    public class TitleStrong : Title
    {
        public TitleStrong(Adventurer adventurer) : base(adventurer)
        {
            
        }

        public override void attack()
        {
            Console.Write("猛力 ");
            base.attack();
        }
    }

    public class TitleAgile : Title
    {
        public TitleAgile(Adventurer adventurer) : base(adventurer)
        {
            
        }

        public override void attack()
        {
            Console.Write("快速 ");
            base.attack();
        }
    }

    public class TitleInFire : Title
    {
        public TitleInFire(Adventurer adventurer) : base(adventurer)
        {
            
        }

        public override void attack()
        {
            Console.Write("燃燒 ");
            base.attack();
        }

        public void fireball()
        {
            Console.WriteLine("丟火球");
        }
    }

}
