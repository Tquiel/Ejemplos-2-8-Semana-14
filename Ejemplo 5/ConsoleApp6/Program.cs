using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite una frase: ");
            string frase = Console.ReadLine().ToLower();

            int a = 0, e = 0, i = 0, o = 0, u = 0;

            for (int x = 0; x < frase.Length; x++)
            {
                char c = frase[x];

                if (c == 'a') a++;
                else if (c == 'e') e++;
                else if (c == 'i') i++;
                else if (c == 'o') o++;
                else if (c == 'u') u++;
            }

            Console.WriteLine("Vocal a: " + a);
            Console.WriteLine("Vocal e: " + e);
            Console.WriteLine("Vocal i: " + i);
            Console.WriteLine("Vocal o: " + o);
            Console.WriteLine("Vocal u: " + u);

            Console.ReadKey();
        }
    }
}

