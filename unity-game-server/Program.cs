using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace unity_game_server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Unity Game Server";

            Server.Start(50, 26950);

            Console.ReadKey();
        }
    }
}
