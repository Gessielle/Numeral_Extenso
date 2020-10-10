using System;
using Humanizer;

namespace Numeral_Extenso
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string texto;

            Console.Write("Digite um Número: ");
            numero = int.Parse(Console.ReadLine());

            texto = numero.ToWords();
            Console.Write("Seu numero em texto é: ");
            Console.WriteLine (texto);
        }
    }
}
