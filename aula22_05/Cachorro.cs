using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula22_05
{
    //para usar herança usa-se dois pontos :
    internal class Cachorro : Animal
    {
        private string _raca;
        //acessando o privado com get e set
        public string Raca { get => _raca; set => _raca = value; }
        //---------------------------------------------------
        public void MostrarDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Especie: "+Especie);
            Console.WriteLine("Idade: "+Idade);
            Console.WriteLine("Raça: " + _raca);
        }
        //override é usado onde está sobrescrevendo
        public override void EmitirSom() // sobrescrita do metodo de animal
        {
            //a classe derivada (cachorro) tem a mesma assinatura(nome) da classe animal
            Console.WriteLine("latindo");
        }

        public override void Movimentar() 
        {
            Console.WriteLine("Cachorro está correndo");
        }
    }
}
