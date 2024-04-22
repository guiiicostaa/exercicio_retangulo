using System;
using System.Globalization;

namespace exRETANGULO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double b, h, area, peri, diagonal;



            Console.Write("Base do retangulo: ");
            b = double.Parse(Console.ReadLine(), CI);
            Console.Write("Altura do retangulo: ");
            h = double.Parse(Console.ReadLine(), CI);

            
            area = b * h;
            peri = 2 * b + 2 * h;
            diagonal = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));

            Console.WriteLine();
            Console.WriteLine("Area= " + area.ToString("F4", CI));
            Console.WriteLine("Perimetro= " + peri.ToString("F4", CI));
            Console.WriteLine("Diagonal= " + diagonal.ToString("F4", CI));

        }
    }
}
