using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LastNameSorting;
using LastNameSorting.Repository;
using System.Collections.Generic;
using System.IO;

namespace LastNameSorting.Test
{
    [TestClass]
    public class FileRepositoryTest
    {
        [TestMethod]
        public void FilereadTest()
        {
            FileRepository file = new FileRepository();
           var names= file.ReadFile("unsorted-names-list.txt");
            Assert.IsTrue(names.Count > 1);

        }
        [TestMethod]
        public void FileWriteTest()
        {
            FileRepository file = new FileRepository();
            List<string> Result = new List<string>
            {
                "Adonis Julius Archer",
                "Beau Tristan Bentley",
                "Hunter Uriah Mathew Clarke",
                "Leo Gardner",
                "Vaughn Lewis",
                "London Lindsey",
                "Mikayla Lopez",
                "Janet Parsons",
                "Frankie Conner Ritter",
                "Shelby Nathan Yoder",

            };
            file.WriteFile(Result,"sorted-names-list.txt");
            Assert.IsTrue(Result.Count > 1);

        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void FileNotFoundTest()
        {
           
            FileRepository file = new FileRepository();
            var res=file.ReadFile("No File exists");
            

        }
    }
}
