using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Autenticavel
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public string Senha { get; set; }

        public Autenticavel(string nome, double salario, string cpf)
        {
            Nome = nome;
            Salario = salario;
            CPF = cpf;

            TotalDeFuncionarios++;
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}
 