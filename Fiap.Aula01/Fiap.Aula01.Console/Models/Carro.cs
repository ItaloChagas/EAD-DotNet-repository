using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.Console.Model
{
    class Carro : Veiculo, ICompeticao
    {
        //Propriedade
        public string Modelo { get; set; }

        public Combustivel Combustivel { get; set; }

        //Métodos
        public override void Frear()
        {
            Velocidade--;
        }

        public override void Acelerar()
        {
            Velocidade += 2;
        }

        public void Largar()
        {
            Velocidade = 0;
        }

        //Construtores
        public Carro(string nome) : base(nome)
        {
        }

        public Carro(string nome, string modelo) : base(nome)
        {
            this.Modelo = modelo;
        }
    }
}
