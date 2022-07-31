using System.Runtime.Serialization;

namespace DataContractBuiltInSample
{
    public class Sample
    {
        public void Serialize()
        {
            var sample = new SampleClassToSerialize { SampleProp = 1 };
            var ds = new DataContractSerializer(typeof(SampleClassToSerialize));
            using (Stream stream = File.Create("sample.xml"))
                ds.WriteObject(stream, sample);
        }

        public void Deserialize()
        {
            SampleClassToSerialize sample;
            var ds = new DataContractSerializer(typeof(SampleClassToSerialize));

            using (Stream stream = File.OpenRead("sample.xml"))
                sample = (SampleClassToSerialize)ds.ReadObject(stream);

        }

        [DataContract]
        public class SampleClassToSerialize
        {
            [DataMember] public int SampleProp { get; set; }
        }
    }
}