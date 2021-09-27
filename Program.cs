using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: Converta uma temperatura digitada pelo usuário em °F para °C.

            Console.Write("Digite o valor da temperatura em ºF: ");
            int F = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nResposta: {F}ºF equivalem à {Math.Round(((F-32)/1.8),2)}ºC");
        }
    }
}
