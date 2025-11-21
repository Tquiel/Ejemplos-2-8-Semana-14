using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite un carácter: ");
            char c = char.Parse(Console.ReadLine());

            if (char.IsDigit(c))
                Console.WriteLine(c + " es un número.");
            else if (char.IsLetter(c))
                Console.WriteLine(c + " es una letra.");
            else
                Console.WriteLine(c + " es un símbolo.");

            Console.ReadKey();
        }
    }
}

