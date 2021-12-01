using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer designer = new Designer("Pedro", 3000, "833.222.048-39");

            Diretor diretor = new Diretor("Roberta", 5000, "159.753.398-04");

            Auxiliar auxiliar = new Auxiliar("Igor", 2000, "981.198.778-53");

            GerenteDeConta gerenteDeConta = new GerenteDeConta("Camila", 4000, "326.985.628-89");

            gerenciadorBonificacao.Registrar(designer);
            gerenciadorBonificacao.Registrar(diretor);
            gerenciadorBonificacao.Registrar(auxiliar);
            gerenciadorBonificacao.Registrar(gerenteDeConta);

            Console.WriteLine($"Total de bonificações: {gerenciadorBonificacao.GetTotalBonificacao()}");
        }

        static void Main(string[] args)
        {
            CalcularBonificacao();
        }
    }
}