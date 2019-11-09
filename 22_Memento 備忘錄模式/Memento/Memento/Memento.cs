using System;
using System.Collections.Generic;
namespace Memento
{
    //備忘錄物件(Memento)
    public class RoleStateMemo
    {
        private int hp;
        private int atk;
        private int def;

        public RoleStateMemo(int hp, int atk, int def)
        {
            this.hp = hp;
            this.atk = atk;
            this.def = def;
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

    //將物件備份(MementoCareTaker)

    public class RoleStateCateTaker
    {
        public List<RoleStateMemo> saves = new List<RoleStateMemo>();

        public RoleStateMemo getSave()
        {
            return saves[0];
        }

        public void setSave(RoleStateMemo memo)
        {
            
            saves.Insert(0, memo); 
        }
    }
}
