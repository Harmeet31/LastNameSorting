using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastNameSorting.Repository
{
    public class NameSortRepository: INameSortRepository
    {
        public void SortLastName(List<string> sortLastName)
        {
            sortLastName.Sort();
            sortLastName.Sort((a, b) =>
            {
                string[] firstA = a.Split(' ');
                string lastA = firstA.Last();
                string[] firstB = b.Split(' ');
                string lastB = firstB.Last();
                string givenNamesA = string.Join(" ", firstA.Take(firstA.Length - 1));
                string givenNamesB = string.Join(" ", firstB.Take(firstB.Length - 1));
                return string.Compare(lastA + givenNamesA, lastB + givenNamesB, StringComparison.Ordinal);
            });
                    
        }
    }
}
