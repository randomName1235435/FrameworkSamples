using System.Collections.Generic;
using System.Linq;

namespace CSharpProject.List.Array.Linq;

public static class FastCastSample
{
    public static IEnumerable<ToCast> FastCast<ToCast>(this IEnumerable<object> collection)
    {
        return collection
            .Where(item => item.GetType() == typeof(ToCast))
            .Select(item => (ToCast)item);
    }
}