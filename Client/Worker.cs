using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    public class Worker
    {
        public void Start()
        {

            while (true)
            {
                using (TcpClient clientSocket = new TcpClient("localhost", 7))
                using (StreamReader reader = new StreamReader(clientSocket.GetStream()))
                using (StreamWriter writer = new StreamWriter(clientSocket.GetStream()))
                {
                    string str = Console.ReadLine();

                    writer.WriteLine(str + " | The number of letters: " + countLetters(str));
                    
                    writer.Flush();


                    string StringReader = reader.ReadLine();
                    Console.WriteLine(StringReader);

                    

                    reader.Close();
                    writer.Close();
                    

                }
            }
            

                

            

            
                
            




        }

        public static int countLetters(string word)
        {
            return word.Length;

        }
    }
}
