using System;
namespace Builder
{
    public class Director
    {
        private RobotBuilder builder;

        public Director(RobotBuilder builder)
        {
            this.builder = builder;
        }

        public IRobot builderRobot()
        {
            IRobot robot = new Gundam();

            //依序建造機器人
            robot.setFrom(builder.buildForm());
            robot.setPower(builder.buildPower());
            robot.setWeapon(builder.buildWeapon());
            return robot;
        }
    }
}
