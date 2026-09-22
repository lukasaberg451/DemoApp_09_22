using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp_09_22
{
    internal class FtillC
    {
        public void Run()
        {
            String svar;
            svar = "";
            bool val = true;
            bool SI = true;

            while (SI)
            {
                Console.WriteLine("Vad vill du ändra? (C) Celsius till Fahrenheit eller (F) Fahrenheit till Celsius");
                svar = Console.ReadLine();
                svar = svar.ToUpper();
                if (svar == "F")
                {
                    val = true;
                }
                else if (svar == "C")
                {
                    val = false;
                }
                if (val == true)
                {
                    Console.WriteLine("Skriv in temperatur i Fahrenheit:");
                    int fahrenheit = int.Parse(Console.ReadLine());
                    float celsius = FahrToCels(fahrenheit);

                    Console.WriteLine($"{fahrenheit} Fahrenheit är {celsius:F2} Celsius.");
                    Console.ReadKey(true);
                }
                else if (val == false)
                {
                    Console.WriteLine("Skriv in temperatur i Celsius:");
                    int Celsius = int.Parse(Console.ReadLine());
                    float Fahrenheit = CelsToFahr(Celsius);
                    Console.WriteLine($"{Celsius} celsius är {Fahrenheit:F2} Fahrenheit.");
                    Console.ReadKey(true);
                }
                Console.WriteLine("Vill du göra en annan konvertering? (J/N)");
                svar = Console.ReadLine();
                svar = svar.ToUpper();
                if (svar == "J")
                {
                    SI = true;
                }
                else if (svar == "N")
                {
                    SI = false;
                    Console.WriteLine();
                    break;
                }
            }

        }
        public static float FahrToCels(int fahr)
        {
            float celD;
            celD = (float)fahr;
            float cel = (celD - 32) * 5 / 9;
            return cel;
        }
        public static float CelsToFahr(int cels)
        {
            float fahrD;
            fahrD = (float)cels;
            float fahr = (fahrD * 9 / 5) + 32;
            return fahr;
        }
    }
}
