using System;
using System.Collections.Generic;

namespace Observer
{
    /*
        被觀察者介面(Subject)
    */
    public abstract class Subject
    {
        protected List<Adventurer> list = new List<Adventurer>();

        //觀察者想被通知
        public void add(Adventurer observer)
        {
            list.Add(observer);
        }

        //觀察者不想被通知
        public void remove(Adventurer observer)
        {
            list.Remove(observer);
        }


        public abstract void sendQuestions(String questions);
    }

    /*
        冒險者協會(Concrete Subject)
    */

    public class Association : Subject
    {
		public override void sendQuestions(string questions)
		{
            foreach (Adventurer adventurer in list)
            { adventurer.getQuestions(questions); }
		}
	}
}
