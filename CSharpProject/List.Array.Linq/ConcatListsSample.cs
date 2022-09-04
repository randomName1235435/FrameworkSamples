using System.Collections.Generic;
using System.Linq;

namespace CSharpProject.List.Array.Linq;

internal class ConcatListsSample
{
    private void SampleMethod()
    {
        var listOne = new List<int> { 1, 2, 3 };
        var listTwo = new List<int> { 4, 5, 6 };
        IEnumerable<int> listOneAndTwo = null;

        listOneAndTwo = listOne.Concat(listTwo).ToList(); //good if campacity is know

        listOneAndTwo = listOne.Union(listTwo).ToList(); // removing duplicates

        var listOneAndTwoList = new List<int>(listOne.Count() + listTwo.Count());
        listOneAndTwoList.AddRange(listOne); //very good on average
        listOneAndTwoList.AddRange(listTwo);
        listOneAndTwo = listOneAndTwoList;

        var listOneAndTwoArray = new int[listOne.Count() + listTwo.Count()];
        listOne.CopyTo(listOneAndTwoArray, 0);
        listTwo.CopyTo(listOneAndTwoArray, listOne.Count());
        listOneAndTwo = listOneAndTwoArray.ToList();

        var OneAndTwoList = new[] { listOne, listTwo }.SelectMany(item => item);
        listOneAndTwo = OneAndTwoList.ToList();
    }
}