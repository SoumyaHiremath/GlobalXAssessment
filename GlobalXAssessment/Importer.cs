/*
 * Class: Importer.cs
 * Created by: Soumya Hiremath
 * Year: 2021
 */

using System.Collections.Generic;
using System.IO;
using System;

namespace GlobalXAssessment
{
    /**
    * Reads the names in a specified file and 
    * provide a list.
    */
    public class Importer
    {
        public static List<Person> importNames(string filename)
        {
            string invalidNamesFileMessage = "Invalid names in the given file";
            // Read the file into an array of full names
            string[] readNames;
            try
            {
                readNames = File.ReadAllLines(filename);
            }
            catch (Exception e)
            {
                throw new FileException(invalidNamesFileMessage, e);
            }
            // Parse the full names 
            var people = new List<Person> { };
            for (int i = 0; i < readNames.Length; ++i)
            {
                var fullName = readNames[i];
            
                if (fullName.Trim() == "" && i == readNames.Length - 1)
                {
                    break;
                }
                // Split the string into first and last names
                int lastSpace = fullName.LastIndexOf(' ');
                if (lastSpace < 1)
                {
                    throw new FileException(invalidNamesFileMessage);
                }
                var firstNames = fullName.Substring(0, lastSpace);
                var lastName = fullName.Substring(lastSpace + 1);

                people.Add(new Person(firstNames, lastName));
            }
            return people;
        }
    }
}
   