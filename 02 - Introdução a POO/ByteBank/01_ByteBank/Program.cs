using System;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";
            contaGabriela.numeroAgencia = 863;
            contaGabriela.numeroConta = 863452;
            contaGabriela.saldo = 100;

            Console.WriteLine(contaGabriela.titular);
            Console.WriteLine("AG: " + contaGabriela.numeroAgencia);
            Console.WriteLine("CC: " + contaGabriela.numeroConta);
            Console.WriteLine("Saldo: R$" + contaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
