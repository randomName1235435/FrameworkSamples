using System;

namespace JsonUtf8
{
    class SampleClass
    {
        static void Main(string[] args)
        {
            string jsonText = "";
            Utf8Json.JsonSerializer.ToJsonString(new SampleClass());
            Utf8Json.JsonSerializer.Deserialize<SampleClass>(jsonText);
        }
    }
}
