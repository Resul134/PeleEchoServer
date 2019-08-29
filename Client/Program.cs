using System;
using System.Net.Sockets;
using System.Net;


namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            Worker worker = new Worker();
            worker.Start();
            Console.ReadLine();
        }
    }
}
