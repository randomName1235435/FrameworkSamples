using HashidsNet;
using System.Collections.Generic;

namespace HashidsSample
{
    class SampleClass
    {
        public int LastUsedRawId { get; private set; }
        public List<object> ServiceCollection { get; private set; }
        public object LastUsedHashId { get; private set; }

        static void SampleMethod(string[] args)
        {
        }

        private IHashids Resolve()
        {
            return null;
        }
        private void Register()
        {
            int minLengthHash = 10;
            this.ServiceCollection.Add(new Hashids("Guid or something as key (seed/salt)", minLengthHash));
        }

        private void ToIdHash(int rawId)
        {
            this.LastUsedHashId = Resolve().Encode(rawId);
        }
        private void ToIdHashMultiple(int[] rawIds)
        {
            this.LastUsedHashId = Resolve().Encode(rawIds);
        }

        private void ToId(string hashed)
        {
            var rawId = Resolve().Decode(hashed);
            if (rawId.Length == 0)
                NotFound();

            this.LastUsedRawId = rawId[0];
        }
        private void ToIdMultiple(string hashed)
        {
            var rawId = Resolve().Decode(hashed);
            if (rawId.Length == 0)
                NotFound();

            this.LastUsedRawId = rawId[rawId.Length - 1];
        }

        private void NotFound()
        {

        }
    }
}
