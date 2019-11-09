using System;
using System.Collections;

namespace Iterator
{
    public interface IEnumerator
    {
        object Current { get; }
        bool MoveNext();
        void Reset();
    }

    public interface SimpleListInterface
    {
        //void add(String s);
    }

    public class SimpleList : SimpleListInterface
    {
        private int id = 0;
        private String carName = String.Empty;

        public SimpleList(String carName)
        {
            this.carName = carName;
        }

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

		public override string ToString()
		{
             return (this.id + 1) + "." + this.carName;
		}
	}


    public class IteratorSimpleList : IEnumerable , IEnumerator
    {
        private int index = -1;
        private int id = -1;
        public SimpleList[] simpleList = new SimpleList[1000];

        public void add(String carName)
        {
            id++;
            simpleList[id] = new SimpleList(carName);
            simpleList[id].ID = id;
        }

        public void Reset()
        {
            this.index = 0;
        }

        public bool MoveNext()
        {
            this.index++;
            if (this.index >= this.simpleList.Length)
            {
                this.index = this.simpleList.Length - 1;
                return false;
            }
            return true;
        }

        public object Current
        {
            get { return this.simpleList[this.index]; }
        }


        public System.Collections.IEnumerator GetEnumerator()
        {
            return simpleList.GetEnumerator();
        }

    }
}
