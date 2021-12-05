﻿using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, Autenticavel
    {
        public FuncionarioAutenticavel(string nome, double salario, string cpf) : base(nome, salario, cpf)
        {
            
        }
    }
}
