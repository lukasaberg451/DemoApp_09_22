using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp_09_22
{
    internal class AgeChecker
    {
        public string FirstName
        { get; set; }
        public int Age
        { get; set; }
        public AgeChecker(string firstName, int age)
        {
            FirstName = firstName;
            Age = age;
        }

        public void Run()
        {
            Console.WriteLine("Är du gammal nog att ta körkort för bil?");
            Console.WriteLine($"{FirstName} är {Age} år gammal.");
            Console.WriteLine($"{FirstName} är {(MayHaveDriversLicense() ? "Behörig" : "Ej Behörig")}" );

        }
        public bool MayHaveDriversLicense()
        {
            return Age >= 18;
        }
    }
}
