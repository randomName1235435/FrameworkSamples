using System;
using System.Collections.Generic;

namespace CSharpProject.Snippets
{
    internal static class ForEachForIEnumerable
    {
        public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
        {
            foreach (T item in enumeration)
            {
                action(item);
            }
        }
    }
}
