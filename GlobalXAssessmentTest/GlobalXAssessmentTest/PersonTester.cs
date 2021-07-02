/* This is the test class for Person
 * Created: Soumya Hiremath
 * Year: 2021
 */

using System;
using Xunit;
using GlobalXAssessment;

namespace GlobalXAssessmentTest
{
    public class PersonTester
    {
        /*
        * This method is to test ToString method of Person class
        */
        [Fact]
        public void StringTest()
        {
            var a = new Person("Harsha Kumar Shiva", "Kodlipet");
            Assert.Equal("Harsha Kumar Shiva Kodlipet", a.ToString());
        }

        /*
        * This method is to check equality in Person class
        */
        [Fact]
        public void EqualsTest()
        {
            var a = new Person("Harsha Kumar Shiva", "Kodlipet");
            var b = new Person("Harsha Kumar Shiva", "Kodlipet");
            var c = new Person("Ross", "Geller");
            Assert.Equal(a, b);
            Assert.NotEqual(a, c);
        }
    }
}