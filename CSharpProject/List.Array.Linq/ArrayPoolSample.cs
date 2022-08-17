using System.Buffers;

namespace CSharpProject.List.Array.Linq
{
    internal class ArrayPoolSample
    {
        private void Sample()
        {
            var arrayPool = ArrayPool<byte>.Shared;
            var buffer = arrayPool.Rent(1000);
            //by default array is not cleared
            using (new ActionOnDispose(() => { arrayPool.Return(buffer); }))
            {
                //do stuff with array
            }
        }
    }
}
