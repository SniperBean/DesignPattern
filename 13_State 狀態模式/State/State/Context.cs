using System;
namespace State
{
    //鬥士類別(Context)
    public class Warrior
    {
        private int hp;
        public State state;

        public Warrior()
        {
            this.hp = 100;
            state = new NormalState();
        }

        public int HP
        {
            get => this.hp;
            set => this.hp = value;
        }

        public void heal(int heal)
        {
            if (hp == 0)
            {
                hp = 0;
            }
            else
            {
                hp += heal;
            }

            if (hp > 100)
            {
                hp = 100;
            }
        }

        public void getDamage(int damage)
        {
            this.hp -= damage;
            if (hp < 0)
            { hp = 0; }
        }

        public void move()
        {
            state.move(this);
        }

        public void setState(State state)
        {
            this.state = state; 
        }
    }
}
