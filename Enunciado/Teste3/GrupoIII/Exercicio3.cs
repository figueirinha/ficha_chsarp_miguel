using System;

namespace GrupoIII
{
    public class Exercicio3
    {
        /// <summary>
        /// apresenta uma tabela m*n que imprime o caracter introduzido
        /// </summary>
        public static void ApresentarTabela()
        {
            Console.WriteLine("Quantas linhas?");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas colunas?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o caracter?");
            var c = Console.ReadLine();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(c + " ");
                }
                Console.Write("\n");
            }
        }

        /// <summary>
        /// imprime se um valor é multiplo de 3 e/ou 7
        /// </summary>
        /// <param name="n"></param>
        public static void MultiploDeTresESete(int n)
        {
            if((n % 3 == 0) && (n % 7 == 0)) 
            {
                Console.WriteLine(n + " é multiplo de 3 e 7");
            }
            else if (n % 3 == 0)
            {
                Console.WriteLine(n + " é multiplo de 3 mas nao é de 7");
            }
            else if (n % 7 == 0)
            {
                Console.WriteLine(n + " é multiplo de 7 mas nao é de 3");
            }
            else
            {
                Console.WriteLine(n + " nao é multiplo de 3 nem de 7");
            }
        }

        /// <summary>
        /// calcula o factorial de um numero de forma iterativa
        /// </summary>
        public static void Factorial()
        {
            Console.WriteLine("Qual o número?");
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("O fatorial de " + n + " é " + factorial);
        }

        /// <summary>
        /// calcula o factorial de um numero de forma recursiva 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FactorialR(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * FactorialR(n - 1);
            }
        }
    }
}
