using System;
using System.Collections.Generic;

namespace Composite
{
    //有分支的協會(Composite)
    public class Association : AbstractAssociation
    {
        private List<AbstractAssociation> branchs = new List<AbstractAssociation>();

        public Association(String name) : base(name)
        {
        }

        //增加轄區下分會或部門

        public override void add(AbstractAssociation a)
        {
            branchs.Add(a);
        }

        //移除轄區下分會或部門
        public override void remove(AbstractAssociation a)
        {
            branchs.Remove(a);
        }

        //印出組織結構圖
        public override void display(int depth)
        {
            for (int i = 0; i < depth; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine(name);
            foreach(AbstractAssociation a in branchs)
            {
                a.display(depth+2);
            }
        }

        //印出組織職責
        public override void lineOfDuty()
        {
            foreach(AbstractAssociation a in branchs)
            {
                a.lineOfDuty();
            }
        }
    }
}
