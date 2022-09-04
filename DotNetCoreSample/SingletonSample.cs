using System;

namespace DotNetCoreSample
{
    public class SingletonSample
    {
        public static Lazy<SingletonSample> lazySingletonInstance =
            new Lazy<SingletonSample>(() => new SingletonSample());

        private SingletonSample()
        {
        }

        public static SingletonSample GetInstance => lazySingletonInstance.Value;
    }
}