using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] a1 = "abc".ToCharArray();

            char[] a2 = new char[3];
            a2[0] = 'a';
            a2[1] = 'b';
            a2[2] = 'c';

            char[] a3 = new char[] { 'a', 'b', 'c' };

            Console.WriteLine("Tamaño a1: " + a1.Length);
            Console.WriteLine("Tamaño a2: " + a2.Length);
            Console.WriteLine("Tamaño a3: " + a3.Length);

            Console.ReadKey();
        }
    }
}

