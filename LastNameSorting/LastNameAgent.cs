using LastNameSorting.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastNameSorting
{
    internal class LastNameAgent
    {
        private readonly INameSortRepository nameSortRepository;
        private readonly IFileRepository fileRepository;
        public LastNameAgent(INameSortRepository _nameSortRepository, IFileRepository _fileRepository)
        {
            this.nameSortRepository = _nameSortRepository;
            this.fileRepository = _fileRepository;
        }
        public void SortByLastName(List<string> names)
        {
            this.nameSortRepository.SortLastName(names);
        }

        public List<string> ReadFileData(string filename)
        {
           return this.fileRepository.ReadFile(filename);
        }
        public void WriteFileData(string filename, List<string> data)
        {
            this.fileRepository.WriteFile(data,filename);
        }
    }
}
