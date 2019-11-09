using System;

//進入迷宮的冒險者 這邊只是測試需要，跟樣板模式無關

namespace Template
{
    public abstract class Adventurer
    {
        protected int level; //冒險者等級
        protected String type; //冒險者類型

        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }

        public String Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
    }

    //冒險者-鋼彈
    public class Gundam : Adventurer
    {
        public Gundam()
        {
            base.type = "Gundam";
            base.level = 100;
        }
    }

    //冒險者-鋼彈
    public class Saber : Adventurer
    {
        public Saber()
        {
            base.type = "Saber";
            base.level = 10;
        }
    }
}
