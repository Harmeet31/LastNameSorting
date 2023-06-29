using LastNameSorting.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastNameSorting
{
    internal class Program
    {
        const string inputFilename = "unsorted-names-list.txt";
        const string outputFilename = "sorted-names-list.txt";
        static void Main(string[] args)
        {
            List<string> names = new List<string>
        {
            "Janet Parsons",
"Vaughn Lewis",
"Adonis Julius Archer",
"Shelby Nathan Yoder",
"Marin Alvarez",
"London Lindsey",
"Beau Tristan Bentley",
"Leo Gardner",
"Hunter Uriah Mathew Clarke",
"Mikayla Lopez",
"Frankie Conner Ritter"

        };
            try
            {
                LastNameAgent nameAgent = new LastNameAgent(new NameSortRepository(), new FileRepository());
                names = nameAgent.ReadFileData(inputFilename);
                nameAgent.SortByLastName(names);
                nameAgent.WriteFileData(outputFilename, names);
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //TODO:Log the exception to Event Viewer and Log file
            }
        }
    }
}
