using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_StringConcatenation
{
    class StringConcatenation
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object objectHelloWorld = hello + " " + world;
            string stringHelloWorld = (string)objectHelloWorld;
            Console.WriteLine(stringHelloWorld);
        }
    }
}
