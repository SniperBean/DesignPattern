using System;

//樣板迷宮(Template) - 規範迷宮冒險的演算法


namespace Template
{
    public abstract class MazeTemplate
    {
        protected int diffculty;  //迷宮難度
        protected Adventurer adventurer;  //進入迷宮的冒險者
        protected Boolean isDoubleMaze = false; //hook，決定是否有隱藏迷宮

        public Adventurer adventure(Adventurer adventurer)
        {
            this.adventurer = adventurer;

            //確認冒險者等級
            if(!checkLevel(adventurer.Level))
            {
                Console.WriteLine("冒險者等級不足，請升級至 " + diffculty + "後開啟迷宮");
            }
            else
            {
                Console.WriteLine("---" + adventurer.Type + "開始進行困難度 " + diffculty + " 的迷宮");
                createMaze();
                start();

                if(isDoubleMaze)
                {
                    hiddenMaze();
                }

                showResult();
            }

            return this.adventurer;
        }

        public Boolean checkLevel(int level)
        {
            if(level < diffculty)
            {
                return false;
            }

            return true;
        }

        //產生迷宮內容(由子類別實作)
        public abstract void createMaze();

        //冒險者進入迷宮(由子類別實作)
        public abstract void start();

        void hiddenMaze()
        {
            Console.WriteLine("進入隱藏迷宮");
        }

        //顯示冒險結果
        Adventurer showResult()
        {
            this.adventurer.Level = adventurer.Level + 50 * diffculty;
            Console.WriteLine("---" + adventurer.Type + "完成難度" + diffculty + "迷宮！！！");
            return this.adventurer;
        }
    }


    public class EazyMaze : MazeTemplate
    {
        public EazyMaze()
        {
            base.diffculty = 1;
        }

        public override void createMaze()
        {
            //這邊其實是實作撰寫演算法，這邊以文字代替
            Console.WriteLine("準備100*100的迷宮");
            Console.WriteLine("安排10隻小怪物");
            Console.WriteLine("安排等級10的BOSS");
            Console.WriteLine("拔草整理場地");
            Console.WriteLine("簡易迷宮準備完成！！！");
        }

		public override void start()
		{
            Console.WriteLine("冒險者開始進行簡單迷宮的冒險");
		}
	}
        
    public class DifficultyMaze : MazeTemplate
    {
        public DifficultyMaze()
        {
            base.isDoubleMaze = true;  //困難模式有隱藏關卡
            base.diffculty = 50;  //50等以上才能進入困難迷宮
        }

        public override void createMaze()
        {
            //這邊其實是實作撰寫演算法，這邊以文字代替
            Console.WriteLine("準備1000*1000的迷宮");
            Console.WriteLine("安排打不完的小怪物");
            Console.WriteLine("安排等級50的BOSS，100隻");
            Console.WriteLine("拔草整理場地，重新油漆牆壁");
            Console.WriteLine("擺放各種陷阱，擺放假屍體");
            Console.WriteLine("困難迷宮準備完成！！！");
        }

        public override void start()
        {
            Console.WriteLine("冒險者開始進行困難迷宮的冒險");
        }
    }
}
