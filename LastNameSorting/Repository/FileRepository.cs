using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastNameSorting.Repository
{
    public class FileRepository : IFileRepository
    {
        public List<string> ReadFile(string filename)
        {
            string basePath=System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filepath=basePath+"\\"+filename;
            if (!File.Exists(filepath))
                throw new FileNotFoundException();
               
            return File.ReadAllLines(filepath).ToList();
        }
        public void WriteFile(List<string> Names, string filename)
        {
            string basePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filepath = basePath + "\\" + filename;
            if(File.Exists(filepath))
                File.Delete(filepath);

            File.WriteAllLines(filepath, Names);
        }
    }
}
