using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo8
{
    class Program
    {
        static char[] Ingreso()
        {
            Console.Write("Digite una frase: ");
            string frase = Console.ReadLine();
            return frase.ToCharArray();
        }

        static void Invertir(char[] arr)
        {
            int inicio = 0;
            int fin = arr.Length - 1;

            while (inicio < fin)
            {
                char temp = arr[inicio];
                arr[inicio] = arr[fin];
                arr[fin] = temp;

                inicio++;
                fin--;
            }
        }

        static void Imprimir(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[" + arr[i] + "]");
            }
        }

        static void Main(string[] args)
        {
            char[] frase = Ingreso();
            Invertir(frase);

            Console.WriteLine("Frase invertida:");
            Imprimir(frase);

            Console.ReadKey();
        }
    }
}

