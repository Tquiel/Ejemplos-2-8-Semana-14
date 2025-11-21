using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un mensaje: ");
            string texto = Console.ReadLine();

            char[] arr = texto.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[" + arr[i] + "]");
            }

            Console.ReadKey();
        }
    }
}
