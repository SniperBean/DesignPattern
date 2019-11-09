using System;
namespace Observer
{
    public abstract class Adventurer
    {
        protected String name;

        public Adventurer(String name)
        {
            this.name = name;
        }

        /*
            冒險者接受任務
        */

        public abstract void getQuestions(String questions);
    }

    //槍兵(ConcreteObserver)
    public class Lancer : Adventurer
    {
        public Lancer(String name) : base(name)
        {}

		public override void getQuestions(string questions)
		{
            Console.WriteLine(name + ":有任務就接，沒在怕der");
		}
	}

    //吟遊詩人(ConcreteObserver)
    public class Bard : Adventurer
    {
        public Bard(String name) : base(name)
        { }

        public override void getQuestions(string questions)
        {
            if (questions.Length > 10)
                Console.WriteLine(name + ":任務太難，不接");
            else
                Console.WriteLine(name + "街頭賣藝不好賺，偶爾也是要解任務。");
            
        }
    }

    //槍兵(ConcreteObserver)
    public class Gunman : Adventurer
    {
        public Gunman(String name) : base(name)
        { }

        public override void getQuestions(string questions)
        {
            if (questions.Length < 10)
                Console.WriteLine(name + ":任務太簡單，無視");
            else
                Console.WriteLine(name + "只要我手上有槍，誰都殺不屎我，出發！");
        }
    }

}
