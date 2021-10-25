using System.Collections.Generic;
using System.IO;
using ProtoBuf;

namespace Protobuff
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var fileStream = File.OpenRead(@"C:\"))
            {
                var deserialized = Serializer.Deserialize<IEnumerable<SampleClass>>(fileStream);
            }
            using (var fileStream = File.OpenWrite(@"C:\"))
            {
                Serializer.Serialize<IEnumerable<SampleClass>>(fileStream, new SampleClass[] { new SampleClass() });
            }
        }
    }

    [ProtoContract]
    public class SampleClass
    {
        [ProtoMember(1)]
        public int FirstSampleProperty { get; set; }

        [ProtoMember(2)]
        public int SecondSampleProperty { get; set; }
    }
}
