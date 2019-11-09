using System;
namespace Composite
{
    //冒協會抽象類別(Component)
    public abstract class AbstractAssociation
    {
        protected String name;
        
        public AbstractAssociation(String name)
        {
            this.name = name;
        }

        //增加管轄區下分會或部門
        public abstract void add(AbstractAssociation a);

        //移除管轄區下分會或部門
        public abstract void remove(AbstractAssociation a);

        //印出組織結構圖
        public abstract void display(int depth);

        //印出組織職責
        public abstract void lineOfDuty();
    }
}
