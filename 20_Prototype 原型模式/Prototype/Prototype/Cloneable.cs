using System;

namespace Prototype
{
    public class Resume : ICloneable
    {
        private String name;
        private int level;
        private String profession;
        private AdventureExoerience experience;

        public Resume(String name, String profession, int level)
        {
            this.name = name;
            this.level = level;
            this.profession = profession;
            experience = new AdventureExoerience();
        }

        private Resume(AdventureExoerience exoerience)
        {
            this.experience = (AdventureExoerience)exoerience.Clone();
        }

        public object Clone()
        {

            //return base.MemberwiseClone();
            //注意！！！ 直接使用base.MemberwiseClone不會得到新的AdventureExperience實體

            Resume clone = new Resume(experience);
            clone.name = this.name;
            clone.level = this.level;
            clone.profession = this.profession;
            return clone;

        }

        public void display()
        {
            Console.WriteLine("冒險者:" + String.Format("{0}",name)+ "-" + String.Format("{0}",profession) + "等級: " + String.Format("{0}",level));
            Console.WriteLine("冒險者經歷:" + String.Format("{0} ",experience.Date) + String.Format("{0}",experience.Location));
            Console.WriteLine("");
        }

        public void setExperience(String date, String location)
        {
            experience.Date = date;
            experience.Location = location;
        }

        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Level
        {
            get { return this.level; }
            set { this.level = value; }
        }

        public String Profession
        {
            get { return this.profession; }
            set { this.profession = value; }
        }
    }

    public class AdventureExoerience : ICloneable
    {
        private String date;
        private String location;

        public object Clone()
        {
            return base.MemberwiseClone();
        }

        public String Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public String Location
        {
            get { return this.location; }
            set { this.location = value; }
        }
    }
}
