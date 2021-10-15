using System;

namespace insercion
{
    class Inserciondirecta
    {
        private int[] orden;

        public void Cargar()
        {
            Console.Write("Cuantos numeros ingresara: ");
            string linea;
            linea = Console.ReadLine();
            int cant;
            cant = int.Parse(linea);
            orden = new int[cant];
            for (int f = 0; f < orden.Length; f++)
            {
                Console.Write("numero: "+(f+1)+": ");
                linea = Console.ReadLine();
                orden[f] = int.Parse(linea);
            }
        }

        public void InsercionDirecta()
        {
            int mostrar;
            int j;
            for (int i = 0; i < orden.Length; i++)
            {
                mostrar = orden[i];
                j = i - 1;
                while (j >= 0 && orden[j] > mostrar)
                {
                    orden[j + 1] = orden[j];
                    j--;
                }
                orden[j + 1] = mostrar;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("numeros de forma ordenada: ");
            for (int f = 0; f < orden.Length; f++)
            {
                Console.Write(orden[f]+"  ");
            }
        }

        static void Main(string[] args)
        {
            Inserciondirecta pv = new Inserciondirecta();
            pv.Cargar();
            pv.InsercionDirecta();
            pv.Imprimir();
        }
    }
}