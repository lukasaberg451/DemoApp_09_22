namespace DemoApp_09_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapar objekten
           AgeChecker ageChecker = new AgeChecker("Kristin", 40);
            Calculator calculator = new Calculator();

            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("---Klassens verktygsläda---");
                Console.WriteLine();
                Console.WriteLine("1. Kolla åldern");
                Console.WriteLine("2. Räkna med siffror");
                Console.WriteLine();

                Console.Write("Välj, använd 0 för att avsluta: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ageChecker.Run();
                        break;

                    case "2":
                        calculator.Run();
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Felaktig inmatning");
                        break;

                }
                Console.WriteLine();
                Console.WriteLine("Välj en funktion från verktygslådan.");
                Console.ReadKey();
            }
        }
    }
}
