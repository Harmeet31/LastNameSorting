using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastNameSorting.Repository
{
    interface IFileRepository
    {
        List<string> ReadFile(string filename);
        void WriteFile(List<string> Names, string filename);
    }
}
