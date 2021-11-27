using System;

namespace _11_CalculaPoupanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Executando o projeto 11 - Calcula Poupança 2!");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine(
                    "Após " + contadorMes +
                    " meses, você terá R$" + valorInvestido);
            }
        
        Console.ReadLine();

        }
    }
}
