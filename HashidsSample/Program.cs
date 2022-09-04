using HashidsNet;
using System.Collections.Generic;

namespace HashidsSample
{
    internal class SampleClass
    {
        public int LastUsedRawId { get; private set; }
        public List<object> ServiceCollection { get; private set; }
        public object LastUsedHashId { get; private set; }

        private static void SampleMethod(string[] args)
        {
        }

        private IHashids Resolve()
        {
            return null;
        }

        private void Register()
        {
            var minLengthHash = 10;
            ServiceCollection.Add(new Hashids("Guid or something as key (seed/salt)", minLengthHash));
        }

        private void ToIdHash(int rawId)
        {
            LastUsedHashId = Resolve().Encode(rawId);
        }

        private void ToIdHashMultiple(int[] rawIds)
        {
            LastUsedHashId = Resolve().Encode(rawIds);
        }

        private void ToId(string hashed)
        {
            var rawId = Resolve().Decode(hashed);
            if (rawId.Length == 0)
                NotFound();

            LastUsedRawId = rawId[0];
        }

        private void ToIdMultiple(string hashed)
        {
            var rawId = Resolve().Decode(hashed);
            if (rawId.Length == 0)
                NotFound();

            LastUsedRawId = rawId[rawId.Length - 1];
        }

        private void NotFound()
        {
        }
    }
}