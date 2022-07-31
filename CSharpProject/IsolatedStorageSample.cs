using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    // file usage for silverlight, clickonce ..
    internal class IsolatedStorageSample
    {

        public void WriteSample()
        {
            using (IsolatedStorageFile f = IsolatedStorageFile.GetMachineStoreForDomain())
            using (var s = new IsolatedStorageFileStream("sample.txt", FileMode.Create, f))
            using (var writer = new StreamWriter(s))
                writer.WriteLine("sampleString");
        }
        public void ReadSample()
        {
            // Read it back:
            using (IsolatedStorageFile f = IsolatedStorageFile.GetMachineStoreForDomain())
            using (var s = new IsolatedStorageFileStream("sample.txt", FileMode.Open, f))
            using (var reader = new StreamReader(s))
                Console.WriteLine(reader.ReadToEnd()); //sampleString 
        }
    }
}
