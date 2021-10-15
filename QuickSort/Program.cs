using System;
namespace QuickSort
{
    class program
    {
        static void Main()
        {
            int numero;
            Console.Write("Cuantos numeros ingresara: ");
            numero = Int32.Parse(Console.ReadLine());
            datos b = new datos(numero);
        }
    }

    class datos
    {
        int h;
        int[] orden;
        public datos(int n)
        {
            h = n;
            orden = new int[h];
            for (int i = 0; i < h; i++)
            {
                Console.Write("numero: ", i + 1);
                orden[i] = Int32.Parse(Console.ReadLine());
            }
            QuickSort(orden, 0, h - 1);
            mostrar();
        }

        private void QuickSort(int[] orden, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = orden[central];
            i = primero;
            j = ultimo;
            do
            {
                while (orden[i] < pivote) i++;
                while (orden[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = orden[i];
                    orden[i] = orden[j];
                    orden[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                QuickSort(orden, primero, j);
            }
            if (i < ultimo)
            {
                QuickSort(orden, i, ultimo);
            }
        }

        private void mostrar()
        {
            Console.WriteLine("Numeros de forma ordenada:");
            for (int i = 0; i < h; i++)
            {
                Console.Write("{0} ", orden[i]);
            }
            Console.ReadLine();
        }
    }
}
