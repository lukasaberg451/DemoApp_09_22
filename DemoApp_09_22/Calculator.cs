using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp_09_22
{
    internal class Calculator
    {
        public void Run()
        {
            Console.WriteLine("Mata in en siffra");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Mata in en till siffra");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine(number1 * number2);
        }
    }
}
