using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class ConcatListsSample
    {
        private void SampleMethod()
        {
            var listOne = new List<int> { 1, 2, 3 };
            var listTwo = new List<int> { 4, 5, 6 };
            IEnumerable<int> listOneAndTwo = null;

            listOneAndTwo = Enumerable.Concat(listOne, listTwo).ToList(); //good if campacity is know

            listOneAndTwo = Enumerable.Union(listOne, listTwo).ToList(); // removing duplicates

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
}
