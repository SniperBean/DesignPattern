using System;
using System.Collections.Generic;

namespace Mediator
{

    //中介者介面(Mediator)

    public interface Mediator
    {
        void send(String name, String from, Messager to);
        void sendToAll(String from, String message);
    }

    //中介者類別(Comcrete Mediator)
    public class MessageMediator : Mediator
    {
        private static List<VIPUser> vipList = new List<VIPUser>();
        private static List<CommonUser> userList = new List<CommonUser>();

        public static void joinChat(Messager messager)
        {
            if(messager.GetType().Name.Equals("VIPUser"))
            {
                vipList.Add((VIPUser)messager);
            }
            else
            {
                userList.Add((CommonUser)messager);
            }
        }

        //發信給某人
        public void send(String message, String from, Messager to)
        {
            foreach(Messager msg in vipList)
            {
                if(msg.getName().Equals(from))
                {
                    Console.WriteLine(from + " -> " + to.getName() + ": " + message); 
                }
            }

            foreach (Messager msg in userList)
            {
                if (msg.getName().Equals(from))
                {
                    Console.WriteLine(from + " -> " + to.getName() + ": " + message);
                }
            }
        }

        //發信給所有人
        public void sendToAll(String from, String message)
        {
            foreach(Messager msg in vipList)
            {
                if(!msg.getName().Equals(from))
                {
                    Console.WriteLine(from + " -> " + msg.getName() + ": " + message); 
                }
            }

            foreach (Messager msg in userList)
            {
                if (!msg.getName().Equals(from))
                {
                    Console.WriteLine(from + " -> " + msg.getName() + ": " + message);
                }
            }
        }
    }
}
