using System;
using System.Collections.Generic;

namespace Pattern
{
    //Реализация Singleton Lazy
    //Реализация Singleton Eager ниже
    public class Server
    {
        private List<string> server_list = new List<string>();
        private static Lazy<Server> instance = new Lazy<Server>(() => new Server());

        private Server() { }

        public static Server Instance
        {
            get
            {
                return instance.Value;
            }
        }

        public bool AddServer(string address)
        {
            if (!address.Contains("https") && !address.Contains("http"))
            {
                return false;
            }
            else
            {
                if (server_list.Contains(address))
                {
                    return false;
                }
                else
                {
                    server_list.Add(address);
                    return true;
                }
            }
        }

        public void ShowAllHTTPS()
        {
            if (server_list.Count == 0)
            {
                Console.WriteLine("Список пуст");
                return;
            }
            foreach (string server in server_list)
            {
                if (server.StartsWith("https"))
                    Console.Write(server + " ");
                else Console.Write("Отсувствует(ют) адрес(ы) с https");
            }
            Console.WriteLine('\n');
        }

        public void ShowAllHTTP()
        {
            if (server_list.Count == 0)
            {
                Console.WriteLine("Список пуст");
                return;
            }
            foreach (string server in server_list)
            {
                if (server.StartsWith("http") && !server.StartsWith("https"))
                    Console.Write(server + " ");
                else
                {
                    Console.Write("Отсувствует(ют) адрес(ы) с http");
                }
            }
            Console.WriteLine('\n');
        }
    }
    
    public class Server1
    {
        private List<string> server_list = new List<string>();
        private static readonly Server1 instance = new Server1();

        private Server1()
        {

        }

        public static Server1 Instance
        {
            get
            {
                return instance;
            }
        }

        public bool AddServer(string address)
        {
            if (!address.Contains("https") && !address.Contains("http"))
            {
                return false;
            }
            else
            {
                if (server_list.Contains(address))
                {
                    return false;
                }
                else
                {
                    server_list.Add(address);
                    return true;
                }
            }
        }

        public void ShowAllHTTPS()
        {
            if (server_list.Count == 0)
            {
                Console.WriteLine("Список пуст");
                return;
            }
            foreach (string server in server_list)
            {
                if (server.StartsWith("https"))
                    Console.Write(server + " ");
                else Console.Write("Отсувствует(ют) адрес(ы) с https");
            }
            Console.WriteLine('\n');
        }

        public void ShowAllHTTP()
        {
            if (server_list.Count == 0)
            {
                Console.WriteLine("Список пуст");
                return;
            }
            foreach (string server in server_list)
            {
                if (server.StartsWith("http") && !server.StartsWith("https"))
                    Console.Write(server + " ");
                else
                {
                    Console.Write("Отсувствует(ют) адрес(ы) с http");
                }
            }
            Console.WriteLine('\n');
        }
    } 
}
