using System;

namespace Treinamento2
{
    class Program
    {
        //MATRIZES 
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[,] mat = new int[n, n];
            
            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; i++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }
        }
    }
}
