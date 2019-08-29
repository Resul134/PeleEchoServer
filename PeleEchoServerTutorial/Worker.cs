using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PeleEchoServerTutorial
{
    public class Worker
    {

        public Worker() {}
       
        public void Start()
        {
            IPAddress IP = IPAddress.Loopback;
            int port = 7;
            TcpListener server = new TcpListener(IP, port);

            try
            {
                server.Start();
                Console.WriteLine("Server is succesfully started...We're listening");
                //Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.Read();
            }


            while (true)
            {
                Task.Run(() =>
                {
                    TcpClient socket = server.AcceptTcpClient();
                    DoClient(socket);

                });
                
            }

            
            



        }

        public void DoClient(TcpClient tempsocket)
        {
            using (StreamReader reader = new StreamReader(tempsocket.GetStream()))
            using (StreamWriter writer = new StreamWriter(tempsocket.GetStream()))
            {
                string str = reader.ReadLine();
                writer.WriteLine(str);
                writer.Flush();
                
            }
        }


        
    }
}
