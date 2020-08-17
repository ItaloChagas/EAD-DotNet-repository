using Fiap.Aula01.Console.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.Console.Model
{
    //Classe abstrata -> classe que não pode ser instanciada
    //e pode conter métodos abstratos
    abstract class Veiculo
    {
        //Fields (Campos)
        private string _nome;

        private float _peso;

        //Construtores
        public Veiculo(string nome)
        {
            _nome = nome;
        }

        //Métodos
        //virtual -> permite a sobrescrita do método
        public virtual void Acelerar()
        {
            if (Velocidade > 200)
            {
                throw new VelocidadeException();
            }
            Velocidade++;
        }

        public abstract void Frear();

        //Propriedades (gets/sets)
        public float Velocidade { get; set; }

        public string Cor { get; set; }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public float Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

    }
}
