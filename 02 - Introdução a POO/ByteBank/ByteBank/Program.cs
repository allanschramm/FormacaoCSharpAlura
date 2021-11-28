using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000, "546.879.157-20");
            carlos.Nome = "Carlos";

            carlos.AumentarSalario();

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor(5000, "454.658.148-30");
            roberta.Nome = "Roberta";

            roberta.AumentarSalario();

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine($"Total de Bonificações: {gerenciador.GetTotalBonificacao()}");
        }
    }
}