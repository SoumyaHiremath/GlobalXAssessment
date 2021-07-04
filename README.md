# GlobalXAssessment
A simple program to sort a set of names in alphabetical order first by last name and then by given names.

NameSorter - Main class where the execution begins
Importer - This class is used to read a file containing list of names(unsorted)
Sorter - This class implements a method to sort the names in alphabetical order using string.Sort()
Exporter - This class is used to write the sorted list of names to a file.

Execution:
This program takes one argument which is the path to a file containing a list of names and writes the sorted list of names to file and to console.

Input file: unsorted-names-list.txt
Output file: sorted-names-list.txt

Exceptions are handled using FileException class. The error including invalid arguments, inabality to read or write to file and also incorrect file format are handled, the program 
displays the error and exists.

#GlobalXAssessmentTest
It contains basic unit test classes. 
