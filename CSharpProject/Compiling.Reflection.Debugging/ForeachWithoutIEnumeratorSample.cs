using System.Collections;

namespace CSharpProject.Compiling.Reflection;

internal class ForeachWithoutIEnumeratorSample
{
    private void Sample()
    {
        foreach (var item in this)
        {
            // works cause foreach works by convention
            // if GetEnumerator method is available the specific interface not needed
        }
    }

    public IEnumerator GetEnumerator()
    {
        return null;
    }
}