using Fiap.Exercicio01.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Exercicio01.Models
{
    class ContaPoupanca : Conta, IContaInvestimento
    {

        private readonly decimal _rendimento;

        public ContaPoupanca(decimal rendimento)
        {
            _rendimento = rendimento;
        }

        public decimal Taxa { get; set; }

        public decimal CalculaRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }


        public override decimal Retirar(decimal valor)
        {
            
            if(Saldo - valor - Taxa < 0)
            {
                throw new ExceptionSaldoInsuficiente("Saldo insuficiente");
            }

            Saldo -= valor + Taxa;
            return Saldo; 
        }
    }
}
