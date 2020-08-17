using Fiap.Exercicio01.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Exercicio01.Models
{
    sealed class ContaCorrente : Conta
    {

        public TipoConta Tipo { get; set; }

        public override decimal Retirar(decimal valor)
        {
            var saldoFinal = Saldo - valor; 
            if( saldoFinal < 0  && Tipo == TipoConta.Comum)
            {
                throw new ExceptionSaldoInsuficiente("Saldo Insuficiente");

            }

            Saldo -= valor;
            return Saldo; 
        }
    }
}
