using System;
using System.Collections.Generic;
namespace Visitor
{
    public abstract class Chef
    {
        private String name;

        public Chef(String name)
        {
            this.name = name;
        }

        public String Name
        {
            get { return this.name; }
        }

        //visitor 代表裁判指定的料理
        public abstract void accept(Visitor visitor);
    }

    //特級廚師
    public class SuperChef : Chef
    {
        public SuperChef(String name) : base(name)
        {}

        //如何實現做料理工作已經交移給visitor
        public override void accept(Visitor visitor)
        {
            visitor.cook(this);
        }
    }

    //特級廚師
    public class DarkChef : Chef
    {
        public DarkChef(String name) : base(name)
        { }

        //如何實現做料理工作已經交移給visitor
        public override void accept(Visitor visitor)
        {
            visitor.cook(this);
        }
    }

    //特級廚師
    public class SuperNoodleChef : Chef
    {
        public SuperNoodleChef(String name) : base(name)
        { }

        //如何實現做料理工作已經交移給visitor
        public override void accept(Visitor visitor)
        {
            visitor.cook(this);
        }
    }

    //參加比賽的廚師(被操作的元素集合)
    public class ChefGroup
    {
        private List<Chef> list = new List<Chef>();

        public void join(Chef chef)
        {
            list.Add(chef);
        }

        public void leave(Chef chef)
        {
            list.Remove(chef);
        }

        public void topic(Visitor visitor)
        {
            foreach(Chef chef in list)
            {
                chef.accept(visitor);
            }
        }
    }
}
