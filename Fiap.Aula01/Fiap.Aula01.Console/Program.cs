using Fiap.Aula01.Console.Exceptions;
using Fiap.Aula01.Console.Model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Fiap.Aula01.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar a classe Carro
            Carro carro = new Carro("GTX")
            {
                Cor = "Branco",
                Modelo = "Celta"
            };

            //Utilizando o set
            carro.Nome = "FiapMovel";
            carro.Combustivel = Combustivel.Flex;

            carro.Peso = 1.200f;

            //Utilizando o get
            System.Console.WriteLine(carro.Nome);

            //Criar uma lista de carros
            IList<Carro> lista = new List<Carro>();

            //Adicionar dois carros na lista
            lista.Add(new Carro("Gol Bola", "Gol G2"));
            
            Carro ka = new Carro("Ka 1.0");
            lista.Add(ka);

            //Percorrer a lista e exibir o nome do carro
            foreach (var item in lista)
            {
                System.Console.WriteLine(item.Nome);
            }

            //Tratar a exception
            try
            {
                carro.Velocidade = 300;
                carro.Acelerar();
            }
            catch (VelocidadeException e)
            {
                System.Console.WriteLine("Velocidade inválida");
                System.Console.WriteLine(e.StackTrace);
            }
        }
    }
}
