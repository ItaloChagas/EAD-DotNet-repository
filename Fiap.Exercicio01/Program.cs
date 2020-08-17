using Fiap.Exercicio01.Exceptions;
using Fiap.Exercicio01.Models;
using System;

namespace Fiap.Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            var cc = new ContaCorrente()
            {
                Agencia = 1,
                Numero = 2,
                Saldo = 200,
                DataAbertura = new DateTime(2010, 1, 1),
                Tipo = TipoConta.Comum
            };

            var cp = new ContaPoupanca(0.02m)
            {
                Agencia = 2,
                Numero = 123,
                DataAbertura = new DateTime(2020, 2, 2),
                Saldo = 340,
                Taxa = 10
            };

            try 
            {
                cc.Retirar(500);
            } 
            catch (ExceptionSaldoInsuficiente e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
