using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastNameSorting.Repository
{
    interface INameSortRepository
    {
        void SortLastName(List<string> sortLastName);
    }
}
