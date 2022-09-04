using System;
using System.IO;
using System.IO.IsolatedStorage;

namespace CSharpProject.Snippets;

// file usage for silverlight, clickonce ..
internal class IsolatedStorageSample
{
    public void WriteSample()
    {
        using (var f = IsolatedStorageFile.GetMachineStoreForDomain())
        using (var s = new IsolatedStorageFileStream("sample.txt", FileMode.Create, f))
        using (var writer = new StreamWriter(s))
        {
            writer.WriteLine("sampleString");
        }
    }

    public void ReadSample()
    {
        using (var f = IsolatedStorageFile.GetMachineStoreForDomain())
        using (var s = new IsolatedStorageFileStream("sample.txt", FileMode.Open, f))
        using (var reader = new StreamReader(s))
        {
            Console.WriteLine(reader.ReadToEnd()); //sampleString 
        }
    }
}