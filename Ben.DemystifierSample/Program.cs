using System;
using System.Diagnostics;

namespace Ben.DemystifierSample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new ArgumentException("args");

            }
            catch (Exception x)
            {

                Console.WriteLine(x.StackTrace);
                Console.WriteLine(x.Demystify());
                Console.ReadLine();
            }
        }
    }
}
