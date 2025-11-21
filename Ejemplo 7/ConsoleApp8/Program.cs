using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo7
{
    class Program
    {
        static int[] Ingreso()
        {
            Console.Write("Ingrese el tamaño del array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("a[" + i + "] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }

        static void Invertir(int[] arr)
        {
            int inicio = 0;
            int fin = arr.Length - 1;

            while (inicio < fin)
            {
                int temp = arr[inicio];
                arr[inicio] = arr[fin];
                arr[fin] = temp;

                inicio++;
                fin--;
            }
        }

        static void Imprimir(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[" + arr[i] + "]");
            }
        }

        static void Main(string[] args)
        {
            int[] datos = Ingreso();

            Invertir(datos);

            Console.WriteLine("Array invertido:");
            Imprimir(datos);

            Console.ReadKey();
        }
    }
}

