using System;
namespace Strategy
{
    public class Adventurer
    {
        FightStrategy fightStrategy;

        public void attack()
        {
            if(fightStrategy == null)
            {
                fightStrategy = new NormalAttack();
            }
            fightStrategy.excute();
        }

        //選擇不同的武器(策略)

        public void choiceStrategy(FightStrategy strategy)
        {
            this.fightStrategy = strategy;
        }
    }
}
