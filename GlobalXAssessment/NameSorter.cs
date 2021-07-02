/*
 * Class: Program.cs
 * Created by: Soumya Hiremath
 * Year: 2021
 */

using System;

namespace GlobalXAssessment
{
    /**
    * A program that takes an argument of a path to a file
    * with list of names
    * and sorts them alphabetically, first by last name, then by any given names.
    * Outputs the sorted list to console and to a file in the working directory.
    */
    class NameSorter
    {
        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.Error.WriteLine("Invalid, Please enter one argument");
                return;
            }
            var filename = args[0];
            var unsorted = Importer.importNames(filename);
            var sorted = Sorter.sort(unsorted);
            Exporter.exportNames(sorted);
            Console.ReadKey();
        }
    }
}
