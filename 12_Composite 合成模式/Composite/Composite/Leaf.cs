using System;
namespace Composite
{
    //部門單位抽象類別 
    public abstract class Department : AbstractAssociation
    {
        public Department(String name) : base(name)
        {
        }

        //增加轄區下分會或部門

        public override void add(AbstractAssociation a)
        {
            Console.WriteLine("無法增加子節點");
        }

        //移除轄區下分會或部門
        public override void remove(AbstractAssociation a)
        {
            Console.WriteLine("Leaf無子節點可移除");
        }

        //印出組織結構圖
        public override void display(int depth)
        {
            for (int i = 0; i < depth; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine(name);
        }

        //印出組織職責 但 這邊還沒有決定部門的實際工作，這部分留給子類別。
        //public abstract void lineOfDuty();
    }

    //人力資源部 (Leaf)
    public class HumanResource : Department
    {
        public HumanResource(String name) : base(name)
        {}

        public override void lineOfDuty()
        {
            Console.WriteLine(name + ":想辦法拐騙冒險者來完成任務");
        }
    }

    //客服部門 (Leaf)
    public class ServiceDepartment : Department
    {
        public ServiceDepartment(String name) : base(name)
        { }

        public override void lineOfDuty()
        {
            Console.WriteLine(name + ":處理客訴，告訴客戶，這肯定是冒險者的錯，不是協會的錯");
        }
    }
}
