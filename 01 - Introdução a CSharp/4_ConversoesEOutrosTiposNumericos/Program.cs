using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4!");

            double salario;
            salario = 1200.50f;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            Console.WriteLine("A execução acabou. Tecle para continuar...");
        }
    }
}
