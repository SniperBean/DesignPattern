using System;
namespace Adapter
{
    public class Adapter : Wizard
    {
        private Archer archer;

        public Adapter(Archer archer)
        {
            this.archer = archer;
        }

        public void fireBall()
        {
            Console.WriteLine("在弓箭上包上布 -> 淋上花生油 -> 點火");
            archer.shot();
            Console.WriteLine("火球飛出去了");
        }
    }
}
