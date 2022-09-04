using System;

namespace CSharpProject.Keywords;

internal class DynamicSample
{
    private void Sample()
    {
        dynamic sample = null;

        Console.WriteLine(nameof(sample.HelloWord)); // actuall works :)
    }
}