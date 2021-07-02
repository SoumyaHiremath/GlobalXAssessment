/* This is the test class for Importer
 * Created: Soumya Hiremath
 * Year: 2021
 */

using System;
using Xunit;
using GlobalXAssessment;
using System.Collections.Generic;


namespace GlobalXAssessmentTest
{
    public class ImportTester
    {
        [Fact]
        public void BasicReadTest()
        {
            var firstNames = new List<String> {
                "Janet",
                "Vaughn",
                "Adonis Julius",
                "Shelby Nathan",
                "Marin",
                "London",
                "Beau Tristan",
                "Leo",
                "Hunter Uriah Mathew",
                "Mikayla",
                "Frankie Conner"
            };
            var lastNames = new List<String> {
                "Parsons",
                "Lewis",
                "Archer",
                "Yoder",
                "Alvarez",
                "Lindsey",
                "Bentley",
                "Gardner",
                "Clarke",
                "Lopez",
                "Ritter"
            };
            var people = new List<Person> { };
            for (int i = 0; i < firstNames.Count; ++i)
            {
                people.Add(new Person(firstNames[i], lastNames[i]));
            }
            var testNames = Importer.importNames("../../../sampleInput/given_names.txt");
            Assert.Equal(testNames, people);
     
        }

        //This method is to test empty file
        [Fact]
        public void EmptyFileTest()
        {
            var testName = new List<Person> { };
            var people = Importer.importNames("../../../sampleInput/blank.txt");
            Assert.Equal(testName, people);
        }

        //This method is to test invalid names in file
        [Fact]
        public void InvalidNameTest()
        {
            Assert.Throws<FileException>(() => Importer.importNames("../../../sampleInput/no-first.txt"));
        }
    }
}
