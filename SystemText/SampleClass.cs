using System;

namespace SystemText
{
    internal class SampleClass
    {
        private static void Main(string[] args)
        {
            var jsonText = "";
            System.Text.Json.JsonSerializer.Serialize(new SampleClass());
            System.Text.Json.JsonSerializer.Deserialize<SampleClass>(jsonText);
        }
    }
}