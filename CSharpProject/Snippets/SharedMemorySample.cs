using System.IO.MemoryMappedFiles;

namespace CSharpProject.Snippets;

internal class SharedMemorySample
{
    private void SampleWrite()
    {
        // shared memory can accessed by multiple processes
        using (var memoryMappedFile = MemoryMappedFile.CreateNew("sharedMemory", 1000))
        {
            using (var viewAccessor = memoryMappedFile.CreateViewAccessor())
            {
                viewAccessor.Write(500, 1000);
            }
        }
    }

    private void SampleRead()
    {
        // shared memory can accessed by multiple processes
        using (var memoryMappedFile = MemoryMappedFile.OpenExisting("sharedMemory"))
        {
            using (var viewAccessor = memoryMappedFile.CreateViewAccessor())
            {
                var sample = viewAccessor.ReadInt32(500);
            }
        }
    }

    private void SampleFastWrite()
    {
        unsafe
        {
            using (var memoryMappedFile = MemoryMappedFile.CreateNew("sharedMemory", 1000))
            {
                using (var viewAccessor = memoryMappedFile.CreateViewAccessor())
                {
                    var bytePointer = (byte*)viewAccessor.SafeMemoryMappedViewHandle.DangerousGetHandle().ToPointer();
                    bytePointer += 500;
                    var intPointer = (int*)bytePointer;
                    *intPointer = 1000;
                }
            }
        }
    }
}