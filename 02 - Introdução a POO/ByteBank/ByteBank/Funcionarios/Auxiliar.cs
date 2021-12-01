using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class Auxiliar : Funcionario
    {
        public Auxiliar(string nome, double salario, string cpf) : base(nome, salario, cpf)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 0.1;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.2;
        }
    }
}
