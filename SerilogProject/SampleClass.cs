using Serilog;
using System;

namespace SerilogProject
{
    public class SampleClass
    {
        public void SampleConfigurationConsole()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
        }

        public void SampleConfigurationConsoleAndTextFile()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("log-.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }
    }
}