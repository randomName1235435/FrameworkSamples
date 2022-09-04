using System;
using System.Collections.Generic;
using System.IO;
using ProtoBuf;

namespace Protobuf
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var fileStream = File.OpenRead(@"C:\"))
            {
                var deserialized = Serializer.Deserialize<IEnumerable<SampleClass>>(fileStream);
            }

            using (var fileStream = File.OpenWrite(@"C:\"))
            {
                Serializer.Serialize<IEnumerable<SampleClass>>(fileStream, Array.Empty<SampleClass>());
            }
        }
    }

    [ProtoContract]
    public class SampleClass
    {
        [ProtoMember(1)] public int FirstSampleProperty { get; set; }

        [ProtoMember(2)] public int SecondSampleProperty { get; set; }
    }
}