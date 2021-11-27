using System;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6!");

            // caracteres
            char letra = 'a';
            Console.WriteLine(letra);

            char valor = 65;                    // Não Compila!
            Console.WriteLine(valor);

            valor = (char)(valor + 1);         // Compila!
            Console.WriteLine(valor);

            string palavra = "alura cursos online de tecnologia";
            Console.WriteLine(palavra);

            palavra = palavra + 2020;
            Console.WriteLine(palavra);


            Console.WriteLine("A execução acabou. Tecle para continuar...");
        }
    }
}
