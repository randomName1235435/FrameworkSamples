using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSharpProject.Snippets;

[Obsolete("dont use me pls; use xml or json or protocol buffers")]
public sealed class SampleGenericListSerialisation<T>
{
    public SampleGenericListSerialisation(string path)
    {
        if (path == null) throw new ArgumentNullException(nameof(path));
        Path = path;
    }

    public SampleGenericListSerialisation(DirectoryInfo path)
    {
        if (path == null) throw new ArgumentNullException(nameof(path));
        Path = path.ToString();
    }

    public SampleGenericListSerialisation()
    {
        Path = "";
    }

    public string Path { get; set; }

    public IEnumerable<T> Deserialize()
    {
        return Deserialize(Path);
    }

    public void Serialize(IEnumerable<T> list)
    {
        Serialize(Path, list);
    }

    #region helper

    private static List<T> Deserialize(string path)
    {
        if (File.Exists(path))
            using (Stream fs = File.OpenRead(path))
            {
                var bf = new BinaryFormatter();
                return (List<T>)bf.Deserialize(fs);
            }

        return new List<T>();
    }

    private static void Serialize(string path, IEnumerable<T> list)
    {
        FileMode fileMode;
        if (File.Exists(path))
            fileMode = FileMode.Open;
        else
            fileMode = FileMode.Create;
        FileStream fs = null;
        try
        {
            fs = File.Open(path, fileMode);
            var bf = new BinaryFormatter();
            bf.Serialize(fs, list);
            fs.Flush();
        }
        finally
        {
            if (fs != null)
                fs.Close();
        }
    }

    #endregion
}