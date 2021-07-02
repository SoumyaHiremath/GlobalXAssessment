/* This is the test class for Sorter
 * Created: Soumya Hiremath
 * Year: 2021
 */


using System;
using Xunit;
using GlobalXAssessment;
using System.Collections.Generic;

namespace GlobalXAssessmentTest
{
    public class SortTester
    {
        [Fact]
        public void BasicSortTest()
        {
            var firstNames = new List<string> {
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
            var lastNames = new List<string> {
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
            var unsorted = NewList(firstNames, lastNames);
            var testSorted = Sorter.sort(unsorted);

            var sortedFirstNames = new List<string> {
                "Marin",
                "Adonis Julius",
                "Beau Tristan",
                "Hunter Uriah Mathew",
                "Leo",
                "Vaughn",
                "London",
                "Mikayla",
                "Janet",
                "Frankie Conner",
                "Shelby Nathan"
            };
            var sortedLastNames = new List<string> {
                "Alvarez",
                "Archer",
                "Bentley",
                "Clarke",
                "Gardner",
                "Lewis",
                "Lindsey",
                "Lopez",
                "Parsons",
                "Ritter",
                "Yoder"
            };
            var correctSorted = NewList(sortedFirstNames, sortedLastNames);
            Assert.Equal(correctSorted, testSorted);
        }

        [Fact]
        public void SameLastTester()
        {
            var unsortedFirst = new List<string> {
                "Ladwa",
                "Ritu",
                "Keun Young",
                "Shrisha",
                "Atharav",
                "Param",
                "Parth"
            };
            var unsortedLast = new List<string> {
                "Smith",
                "Nakod",
                "Kim",
                "Nakod",
                "Kim",
                "Habib",
                "Habib"
            };
            var sortedFirst = new List<string> {
                "Param",
                "Parth",
                "Atharav",
                "Keun Young",
                "Ritu",
                "Shrisha",
                "Ladwa"
            };
            var sortedLast = new List<string> {
                "Habib",
                "Habib",
                "Kim",
                "Kim",
                "Nakod",
                "Nakod",
                "Smith"
            };
            var unsorted = NewList(unsortedFirst, unsortedLast);
            var testSorted = Sorter.sort(unsorted);
            var correctSorted = NewList(sortedFirst, sortedLast);
            Assert.Equal(correctSorted, testSorted);
        }

        [Fact]
        public void SameFirstTester()
        {
            var unsortedFirst = new List<string> {
                "Ross",
                "Harsh Arjit",
                "Lisa Marie",
                "Chandler Murial",
                "Guarav",
                "Ankur Aditya",
                "Ross",
                "Guarav"
            };
            var unsortedLast = new List<string> {
                "Geller",
                "Verma",
                "Haydon",
                "Bing",
                "Patel",
                "Verma",
                "Warner",
                "Sachdev"
            };
            var sortedFirst = new List<string> {
                "Chandler Murial",
                "Ross",
                "Lisa Marie",
                "Guarav",
                "Guarav",
                "Ankur Aditya",
                "Harsh Arjit",
                "Ross"
            };
            var sortedLast = new List<string> {
                "Bing",
                "Geller",
                "Haydon",
                "Patel",
                "Sachdev",
                "Verma",
                "Verma",
                "Warner"
            };
            var unsorted = NewList(unsortedFirst, unsortedLast);
            var testSorted = Sorter.sort(unsorted);
            var correctSorted = NewList(sortedFirst, sortedLast);
            Assert.Equal(correctSorted, testSorted);
        }

        private List<Person> NewList(List<string> firstNames, List<string> lastNames)
        {
            var people = new List<Person> { };
            for (int i = 0; i < firstNames.Count; ++i)
            {
                people.Add(new Person(firstNames[i], lastNames[i]));
            }
            return people;
        }
    }
}