using System;
using System.Collections.Generic;

namespace CSharpProject.List.Array.Linq;

internal class IndexSample
{
    private void SampleMethod()
    {
        var indexFromStart = new Index(0);
        var indexFromEnd = new Index(0, true);
        var sampleList = new List<int>() { 1, 2, 3 };
        var item1 = sampleList[indexFromStart];
        var item2 = sampleList[indexFromEnd];

        var item3 = sampleList[^4]; // 4th from end

        var range = sampleList.ToArray()[2..2];
    }
}