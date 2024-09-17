using System;

namespace teste_estagio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (PertenceFibonacci(numero))
                {
                    Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
                }
                else
                {
                    Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
        }

        static bool PertenceFibonacci(int n)
        {
            if (n < 0) return false;

            int a = 0, b = 1;
            while (a <= n)
            {
                if (a == n)
                {
                    return true;
                }
                int temp = a;
                a = b;
                b = temp + b;
            }

            return false;

            //exercicio 2


            Console.Write("Digite algo: ");
            string input = Console.ReadLine();


            int contar = ContarA(input, out bool existe);


            if (existe)
            {
                Console.WriteLine($"A letra 'a' ocorre {contar} vez(es) na string.");
            }
            else
            {
                Console.WriteLine("A letra 'a' não ocorre na string.");
            }
        }

        static int ContarA(string texto, out bool existe)
        {
            existe = false;
            int contagem = 0;


            if (texto == null)
            {
                return contagem;
            }


            foreach (char c in texto)
            {

                if (c == 'a' || c == 'A')
                {
                    contagem++;
                    existe = true;
                }
            }

            return contagem;

            // exercicio 3


            int INDICE = 12;
            int SOMA = 0;
            int K = 1;


            while (K < INDICE)
            {

                K = K++;


                SOMA = SOMA + K;
            }


            Console.WriteLine(SOMA);

            //exercicio 4

            //a) e uma sequencia de numero impar
            //a) 1, 3, 5, 7, ___ o proximo numero e 9

            //b) cada um e o dobro do anterior
            //b) 2, 4, 8, 16, 32, 64, ____ o proximo numero e 128

            //c)cada um e o quadrado dos numeros 1,2,3,4,5 e 6
            //c) 0, 1, 4, 9, 16, 25, 36, ____ o proximo numero e 49

            //d)Cada número é o quadrado de um número par 2,4,6 e 8
            //d)4, 16, 36, 64, ____ o proximo numero e 100

            //e)Esta é a sequência de Fibonacci, onde cada número é a soma dos dois anteriores.
            //e) 1, 1, 2, 3, 5, 8, ____o proximo numero e 13

            //d) não sei a resposta

            //exercicio 5
            //este e bem conhecido
            /* acenda o primeiro interruptor e deixa acesso por 20 minutos, permitira que a lampada
             * aqueça, depois ligue o segundo interruptor e vá ate a sala, a lampada acessa será 
             * do segundo interruptor, depos coloque a mao nas duas lampadas apagadas a que estiver quente 
             * sera do primeiro interruptos ea fria do terceiro, assim descubrindo qual interruptor acende 
             * cada lampada*/

        }
    }
}
