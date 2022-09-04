using System;

namespace JsonUtf8
{
    internal class SampleClass
    {
        private static void Main(string[] args)
        {
            var jsonText = "";
            Utf8Json.JsonSerializer.ToJsonString(new SampleClass());
            Utf8Json.JsonSerializer.Deserialize<SampleClass>(jsonText);
        }
    }
}