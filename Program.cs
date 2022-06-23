using System;

namespace ConsoleApp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Voltar:
            Console.WriteLine("==================================================");
            Console.WriteLine("Insira o valor de entrada:");
            LOGICA_FUNCTION(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("\n\n");
            goto Voltar;
        }

        public static int[] LOGICA_FUNCTION(int ENTRADA)
        {
            int[] LISTA_DE_VALORES = new int[ENTRADA];
            int RESULTADO_ULTIMA_CONTA = ENTRADA;
            LISTA_DE_VALORES[0] = ENTRADA;
            Console.Clear();
            Console.Write(ENTRADA.ToString() + ",");
            for (int i = 1; i < ENTRADA; i++)
            {
                RESULTADO_ULTIMA_CONTA -= 2;
                LISTA_DE_VALORES[i] = LISTA_DE_VALORES[i - 1] + RESULTADO_ULTIMA_CONTA;
                Console.Write(LISTA_DE_VALORES[i].ToString() + ",");
            }
            return LISTA_DE_VALORES;
        }
    }
}