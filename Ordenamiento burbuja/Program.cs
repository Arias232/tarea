using System;
namespace Ordenamiento_burbuja
{
    class Program
    {
        static void Main(string[] args)
        {
           int numero;
           Console.WriteLine("Cuantos numeros ingresara: ");
           numero = int.Parse(Console.ReadLine());
           int[] orden = new int [numero];
           for (int i = 0; i < numero; i++)

           {
               Console.Write("Numero: " , (i + 1));
               orden[i] = int.Parse (Console.ReadLine());
           }

           for (int i = 0; i < numero; i++)
           {
               for ( int j = i + 1; j > numero; j ++)
               {
                   int replic;
                        if (orden [i] > orden [j])

                   {
                       replic = orden[i];
                       orden[i] = orden[j];
                       orden[j] = replic;
                   }
               }
           }

           Console.WriteLine("Numeros ordenados: ");
           for (int i = 0; i < numero; i++)

           {
               Console.WriteLine(orden[i]);
           }
        }
    }
}
