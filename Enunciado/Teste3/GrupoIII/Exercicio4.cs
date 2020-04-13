using System;

namespace GrupoIII
{
    public class Exercicio4
    {
        /// <summary>
        /// para 2 numeros introduzidos faz a soma/subtração/multiplicação/divisão
        /// ou resto da divisão conforme o operador introduzido
        /// </summary>
        public static void Calculadora()
        {
            Console.WriteLine("Qual o primeiro número?");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o segundo número?");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o operador?");
            var op = Console.ReadLine();
            int resultado;

            //ValidarInput(a, b, op);

            if (op == "+")
            {
                resultado = a + b;
                Console.WriteLine(a + " + " + b + " = " + resultado);
            }
            else if (op == "-")
            {
                resultado = a - b;
                Console.WriteLine(a + " - " + b + " = " + resultado);
            }
            else if (op == "*")
            {
                resultado = a * b;
                Console.WriteLine(a + " * " + b + " = " + resultado);
            }
            else if (op == "/")
            {
                try
                {
                    resultado = a / b;
                    Console.WriteLine(a + " % " + b + " = " + resultado);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Ocorreu uma tentativa dedivisão por zero.");
                }

            }
            else if (op == "%")
            {
                try
                {
                    resultado = a % b;
                    Console.WriteLine(a + " % " + b + " = " + resultado);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Ocorreu uma tentativa dedivisão por zero.");
                }
            }
            else
            {
                try
                {

                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Operador não é reconhecido.");
                }
            }

            try
            {
                if (a >= 0 || a <= 100 || b >= 0 || b <= 100)
                {

                }
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Um dos valores introduzidos não se encontra entre 0 e 100");
            }

            try
            {
                if(a % 5 != 0 || b % 3 != 0)
                {

                }
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine("O primeiro número é divisivel por 5 e o segundo por 3.");
            }

        }

        private static void ValidarInput(int a, int b, string opt)
        {
            var op = opt[0];
            if(op != '+' && op != '-' && op != '*' && op != '/' && op != '%' ) throw new InvalidOperationException();
            if (op == '/'  && b == 0) throw new DivideByZeroException();
            if(a<0 || a > 100 || b<0 || b >100) throw new ArgumentOutOfRangeException();
            if(a%5==0 || b%3==0) throw new ArithmeticException();
        }

        private static void ValidarInput(int a, int b, char op)
        {
           
            if (op != '+' || op != '-' || op != '*' || op != '/' || op != '%') throw new InvalidOperationException();
            if (b == 0) throw new DivideByZeroException();
            if (a < 0 || a > 100 || b < 0 || b > 100) throw new ArgumentOutOfRangeException();
            if (a % 5 == 0 || b % 3 == 0) throw new ArithmeticException();
        }
    }
}
