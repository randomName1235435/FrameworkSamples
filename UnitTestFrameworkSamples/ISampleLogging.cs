using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace UnitTestFrameworkSamples
{
    internal class SampleLogging<TFrom> : ILogger<TFrom>
    {
        //private ILogger logger =   new ConsoleLogger();
        private string from = typeof(TFrom).ToString();

        private NullLogger<TFrom> nullLogger = new NullLogger<TFrom>();
        //private NullLogger nullLogger = new NullLogger();

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception,
            Func<TState, Exception, string> formatter)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            throw new NotImplementedException();
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }
    }

    public class Interaction<TIn, TOut>
    {
        public Interaction(string operation, TIn input, TOut output)
        {
            Operation = operation;
            Input = input;
            Output = output;
        }

        public string Operation { get; set; }
        public TIn Input { get; set; }
        public TOut Output { get; set; }
    }
}