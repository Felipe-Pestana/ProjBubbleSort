using System;

namespace ProjBubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lista = new string[5];

            for(int i = 0; i < 5; i++)pos\ProjBubbleSort
            {
                lista[i] = Console.ReadLine();
            }

            for(int i = 0; i < 5; i++)
                Console.Write(lista[i]+" ");

            for (int referencia = 0; referencia < 5; referencia++)
            {
                for(int comparacao = referencia+1; comparacao < 5; comparacao++)
                {
                    if (String.Compare(lista[referencia], lista[comparacao]) < 0)
                    {
                        string aux = lista[referencia];
                        lista[referencia] = lista[comparacao];
                        lista[comparacao] = aux;
                    }
                }
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
                Console.Write(lista[i] + " ");
        }
    }
}
