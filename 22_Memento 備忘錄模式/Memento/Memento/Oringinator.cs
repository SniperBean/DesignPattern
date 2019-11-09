using System;
namespace Memento
{
    //要備份的物件(Oringinator
    public class GameRole
    {
        private int hp = 100;
        private int atk = 100;
        private int def = 100;
        private String name = "巴哈姆特";

        public RoleStateMemo save()
        {
            return new RoleStateMemo(hp, atk, def);
        }

        public void fight()
        {
            hp = 30;
            Console.WriteLine(name + "剩下30%的血量，出大招把勇者們打得半死");
        }

        public void display()
        {
            Console.WriteLine(name + "的狀態");
            Console.Write("hp = " + hp);
            Console.Write(", atk = " + atk);
            Console.WriteLine(", def = " + def);
            Console.WriteLine();
        }

        public void load(RoleStateMemo memo)
        {
            this.hp = memo.HP;
            this.atk = memo.ATK;
            this.def = memo.DEF;
        }

        public int HP
        {
            get { return this.hp; }
            set { this.hp = value; }
        }

        public int ATK
        {
            get { return this.atk; }
            set { this.atk = value; }
        }

        public int DEF
        {
            get { return this.def; }
            set { this.def = value; }
        }
    }
}
