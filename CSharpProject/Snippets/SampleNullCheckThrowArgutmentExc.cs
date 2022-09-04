using System;

namespace CSharpProject.Snippets;

public class SampleNullCheckThrowArgutmentExc
{
    public int Sample(int? param)
    {
        _ = param ?? throw new ArgumentNullException(nameof(param));

        return param.Value;
    }
}