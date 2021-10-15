using System;
using XcoAppSpaces.Core;

namespace XcoAppSpace.Server
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Xco Application Space - Port Remoting Demo Server");

			using (var space = new XcoAppSpaces.Core.XcoAppSpace("tcp.port=9001")) 
			{
				space.Run<string>(msg => Console.WriteLine("Message received: " + msg));

				Console.WriteLine("Port has been published.");
				Console.ReadLine();
			}
		}
    }
}
