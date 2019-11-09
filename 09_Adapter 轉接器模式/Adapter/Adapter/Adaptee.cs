using System;
namespace Adapter
{
    public interface Archer
    {
        void shot();
    }


    //具體弓箭手
    public class NormalArcher : Archer
    {
        public void shot()
        {
            Console.WriteLine("射箭");
        }
    }

    public interface Wizard
    {
        void fireBall();
    }
}
