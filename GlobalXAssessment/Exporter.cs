/*
 * Class: Exporter.cs
 * Created by: Soumya Hiremath
 * Year: 2021
 */

using System.Collections.Generic;
using System.IO;
using System;

namespace GlobalXAssessment
{
    /**
    * Writes a sorted output to file and console.
    */
    public class Exporter
    {
        public static void exportNames(List<Person> people)
        {
            try
            {
                // Writes sorted names to a file in the working directory called sorted-names-list.txt
                using (System.IO.StreamWriter file = new StreamWriter("sorted-names-list.txt"))
                {
                    foreach (Person person in people)
                    {
                        file.WriteLine(person);
                        Console.WriteLine(person);
                    }
                }
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Unable to write to the file.");
            }
        }
    }
}