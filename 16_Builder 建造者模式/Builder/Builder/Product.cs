using System;
using System.Collections.Generic;
using System.Linq;

namespace Builder
{
    //機器人介面(Product)

    public abstract class IRobot
    {
        Form form;
        Power power;
        Weapon weapon;

        public void setFrom(Form form)
        {
            this.form = form;
        }

        public void setPower(Power power)
        {
            this.power = power;
        }

        public void setWeapon(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public void display()
        {
            Console.WriteLine("機器人外型: " + form.toString());
            Console.WriteLine("機器人動力: " + power.toString());
            Console.WriteLine("機器人武器: " + weapon.toString());
        }
    }

    public class Gundam : IRobot
    {
        
    }

    public class Form
    {
        private String formName;

        public Form(String forName)
        {
            this.formName = forName;
        }

        public String toString()
        {
            return this.formName;
        }
    }

    public class Weapon
    {
        List<String> list = new List<String>();

        public Weapon(String[] weaponList)
        {
            list.AddRange(weaponList.ToList());
        }

        public String toString()
        {
            String listS="";
            foreach(String i in list)
            {
                listS += i+" ";
            }
            return listS;
        }
    }

    public class Power
    {
        private String mainPower;
        private String subPower;
        private String battery;

        public Power(String mainPower, String subPower, String battery)
        {
            this.mainPower = mainPower;
            this.subPower = subPower;
            this.battery = battery;
        }

        public String toString()
        {
            return "{ 主動力: " + mainPower + ", 副動力: " + subPower + ", 電池: " + battery + "}";
        }
    }
}
