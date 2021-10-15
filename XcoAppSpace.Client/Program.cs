using System;
using XcoAppSpaces.Core;

namespace XcoAppSpace.Client
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Xco Application Space - Port Remoting Demo Client");

			using (var space = new XcoAppSpaces.Core.XcoAppSpace("tcp.port=0")) 
			{
				var port = space.Connect<string>("localhost:9001");

				port.Post("Hello, World!");

				Console.WriteLine("Message has been posted to port.");
				Console.ReadLine();
			}
		}
    }
}
