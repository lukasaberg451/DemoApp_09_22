using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp_09_22
{
    internal class ColorChange
    {
        public void Run()
        {
            Console.WriteLine("Elev 5 jobbar här");
            Console.WriteLine("Skriv in numret till den färg du vill raden nedan till");

            Console.WriteLine("███████████████████████████████████");

            Console.WriteLine("1. Vit");
            Console.WriteLine("2. Röd");
            Console.WriteLine("3. Blå");
            Console.WriteLine("4. Grön");
            Console.WriteLine("5. Lila");
            Console.WriteLine("6. Turkos");

            int colorNr = int.Parse(Console.ReadLine()!);

            bool hasColorBeenChanged = false;

            while (!hasColorBeenChanged)
            {
                switch(colorNr)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("███████████████████████████████████\n");
                        Console.ResetColor();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("███████████████████████████████████\n");
                        Console.ResetColor();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("███████████████████████████████████\n");
                        Console.ResetColor();

                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("███████████████████████████████████\n");
                        Console.ResetColor();
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("███████████████████████████████████\n");
                        Console.ResetColor();
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("███████████████████████████████████\n");
                        Console.ResetColor();
                        break;
                    default:
                        break;
                }
                hasColorBeenChanged = true;
            }

        }
    }
}
