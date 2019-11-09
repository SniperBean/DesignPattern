using System;
namespace Builder
{
    public abstract class RobotBuilder
    {
        //建造機器人外型
        public abstract Form buildForm();
        //建造機器人動力
        public abstract Power buildPower();
        //建造機器人武器
        public abstract Weapon buildWeapon();
    }

    public class GundamBuilder : RobotBuilder
    {
        public override Form buildForm()
        {
            return new Form("鋼彈");
        }

        public override Power buildPower()
        {
            return new Power("核能反應爐", "Beta發電機", "氫電池");
        }

        public override Weapon buildWeapon()
        {
            return new Weapon(new String[] { "60mm 火神砲", "突襲長矛", "薩克機槍", "光束劍" });
        }
    }
}
