using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a program to demonstrate the use of List set type 

            List<string> firstNames = new List<string>();

            //in order to use list data type, we need to use another namespace called "System.Collections.Generic".
            //List data type is something which will take only the data type which is initiated at the first time. Like in this case string. It will only take string data type otherwise it will yell if not provided the correct data type.
            // the new operator will initiate the firstnames variable. 
            //while instantiation the List<string>() - brackets are important to be given.

            firstNames.Add("Prateek");
            firstNames.Add("Joseph");
            firstNames.Add("Andrew");
            firstNames.Add("Philip");

            Console.WriteLine($"This program is written by {firstNames[0]}.");

            //in the above list while adding the element we use .Add method.
            //in the below line, when we change the element on a specific index - one thing needs to be remember that element can be only replaced when we have the position inisiated at the first place.

            firstNames[3] = "Kumar";
            Console.WriteLine($"Do you know {firstNames[3]}?");

            Console.ReadLine();
        }
    }
}