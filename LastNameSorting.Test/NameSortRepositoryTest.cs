using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LastNameSorting;
using LastNameSorting.Repository;
using System.Collections.Generic;

namespace LastNameSorting.Test
{
    [TestClass]
    public class NameSortRepositoryTest
    {
        [TestMethod]
        public void SortnameTest()
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
            NameSortRepository repo = new NameSortRepository();
            repo.SortLastName(names);
            List<string> Result = new List<string>
            {
                "Marin Alvarez",
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
            CollectionAssert.AreEqual(Result, names);

        }

        [TestMethod]
        public void SortnameFailTest()
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
            NameSortRepository repo = new NameSortRepository();
            repo.SortLastName(names);
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
            CollectionAssert.AreNotEqual(Result, names);

        }
    }
}
