/*
 * Class: Sorter.cs
 * Created by: Soumya Hiremath
 * Year: 2021
 */

using System.Collections.Generic;
using System.Linq;

namespace GlobalXAssessment
{
    /**
    * This methods sort the names and add them to the list
    */
    public class Sorter
        {
            public static List<Person> sort(List<Person> unsorted)
            {
                return unsorted.OrderBy(person => person.lastName)
                               .ThenBy(person => person.firstNames)
                               .ToList();
            }
        }
    
}