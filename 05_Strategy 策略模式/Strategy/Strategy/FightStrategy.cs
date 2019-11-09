using System;
namespace Strategy
{
    public interface FightStrategy
    {
        void excute();
    }

    public class NormalAttack : FightStrategy
    {
        public void excute()
        {
            Console.WriteLine("使用普通攻擊");
        }
    }

    public class UseSkill : FightStrategy
    {
        public void excute()
        {
            Console.WriteLine("使用高傷害技能");
        }
    }

    public class UseItem : FightStrategy
    {
        public void excute()
        {
            Console.WriteLine("使用道具，投擲火把");
        }
    }
}
