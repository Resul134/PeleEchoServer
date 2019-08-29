using System;
using System.ComponentModel;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace PeleEchoServerTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.Start();
        }
    }
}
