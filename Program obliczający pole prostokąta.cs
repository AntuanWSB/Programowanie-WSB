using System;

namespace Program_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\n\nProgram obliczający pole prostokąta\n");
                double a, b, wynik;
                Console.Write("\nPodaj w cm długość boku a: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("\nPodaj w cm długość boku b: ");
                b = double.Parse(Console.ReadLine());
                wynik = a * b;
                if (a > 0 & b > 0)
                {
                    Console.WriteLine("\n\nPole prostokąta wynosi: {0} cm/kw", wynik);
                }
                else
                {
                    Console.WriteLine("\n\nBłędne dane podane z klawiatury");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\nBłędne dane podane z klawiatury");
                //Console.WriteLine("\n\nBłędne dane podane z klawiatury {0}", ex.Message);
            }
            Console.Write("\n\nNaciśnij dowolny klawisz aby zakończyć program ... ");
            Console.ReadKey();
        }
    }
}
