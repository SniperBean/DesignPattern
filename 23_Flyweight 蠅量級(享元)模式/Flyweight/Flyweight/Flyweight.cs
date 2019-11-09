using System;
using System.Collections.Generic;

namespace Flyweight
{
    //樹木(Flyweight)
    public class Tree
    {
        private String type;
        private String owner;

        public Tree(String type)
        {
            this.type = type;
            Console.WriteLine("取得一顆新的" + type);
        }

        public void setOwner(String owner)
        {
            this.owner = owner;
        }

        public void display()
        {
            Console.WriteLine(type + " , 擁有者: " + owner);
        }
    }

    //樹木管理員(Flyweight factory)
    public class TreeManager
    {
        private static Dictionary<String, Tree> treePool = new Dictionary<string, Tree>();

        public static Tree getTree(String type)
        {
            if(!treePool.ContainsKey(type))
            {
                treePool[type] = new Tree(type);
            }
            return treePool[type];
        }
    }
}
