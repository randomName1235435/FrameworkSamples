using System.Runtime.CompilerServices;

namespace CSharpProject.List.Array.Linq
{
    internal class IndexerNameSample
    {
        private int[] sampleCollection = null;
        [IndexerName("SampleIndexerName")]
        //without attribute compiler generate a private field name 'Item' for accessing index
        public int this[int index]
        {
            get => sampleCollection[index];
            set => sampleCollection[index] = value;
        }
    }
}
