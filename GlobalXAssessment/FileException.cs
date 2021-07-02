/*
 * Class: FileException.cs
 * Created by: Soumya Hiremath
 * Year: 2021
 */
using System;

namespace GlobalXAssessment
{
    /**
    * Exception class for wrong file format and unable to read 
    */
    public class FileException : System.Exception
    {
        public FileException() : base() { }
        public FileException(string message) : base(message) { }
        public FileException(string message, System.Exception inner) : base(message, inner) { }
    }
}