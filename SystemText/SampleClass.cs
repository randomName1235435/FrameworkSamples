using System;

namespace SystemText
{
    class SampleClass
    {
        static void Main(string[] args)
        {
            string jsonText = "";
            System.Text.Json.JsonSerializer.Serialize(new SampleClass());
            System.Text.Json.JsonSerializer.Deserialize<SampleClass>(jsonText);
        }
    }
}
