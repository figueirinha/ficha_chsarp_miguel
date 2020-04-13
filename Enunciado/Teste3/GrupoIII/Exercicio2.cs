using System;

namespace GrupoII
{
    public class Exercicio2
    {
        /// <summary>
        /// Pede um nome e imprime "Olá + nome"
        /// </summary>
        public static void OlaPessoa()
        {
            Console.WriteLine("Qual o seu nome?");
            var nome = Console.ReadLine();
            Console.WriteLine("Olá " + nome);
        }

        /// <summary>
        /// Calcula a quantidade de patas dos 3 tipos de animais
        /// </summary>
        /// <param name="vacas"></param>
        /// <param name="porcos"></param>
        /// <param name="galinhas"></param>
        /// <returns> retorna o numero de patas </returns>
        public static int QuantasPatas(int vacas, int porcos, int galinhas)
        {
            return vacas * 4 + porcos * 4 + galinhas * 2;
        }

        /// <summary>
        /// imprime se o numero inserido é par ou impar
        /// </summary>
        /// <param name="num"></param>
        #region Exercicio2d
        public static void ParOuImpar(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " é par");
            }
            else
            {
                Console.WriteLine(num + " é impar");
            }
        }
        #endregion 

        /// <summary>
        /// recebe 2 valores e faz a soma de ambos. Se os valores forem iguais
        /// a soma é tripla.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Somar(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine((a + b) * 3);
            }
            else
            {
                Console.WriteLine(a + b);
            }
        }

        /// <summary>
        /// calcula a potencia de um numero dado esse numero e o valor da potencia
        /// </summary>
        /// <param name="n"></param>
        /// <param name="p"></param>
        public static void Potencia(int n, int p)
        {
            int resultado = 1;

            for (int i = 0; i < p; i++)
            {
                resultado *= n;
            }

            Console.WriteLine(resultado);
        }
    }
}
