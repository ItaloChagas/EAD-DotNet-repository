using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Exercicio01.Models
{
    abstract class Conta
    {
        public int Agencia{ get; set; }
        public int Numero { get; set; }
        public DateTime DataAbertura { get; set; }
        public decimal  Saldo { get; set; }

        public virtual decimal Depositar(decimal valor)
        {
            Saldo += valor;
            return Saldo;
        }

        public abstract decimal Retirar(decimal valor);


    }
}
