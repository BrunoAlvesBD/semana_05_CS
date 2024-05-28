using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula22_05
{
    internal class Animal
    {
        public string Nome { get; set; } //mesmo comportamento de um atributo
        public string Especie { get; set; }
        public int Idade { get; set; }


        //----------------------------------
        //a palavra virtual permite sobrescrever o método 
        public virtual void EmitirSom()
        {
            Console.WriteLine("Som de animal");
        }

        public virtual void Movimentar()
        {
           
            Console.WriteLine("animal se movimentando");

        }
    }
}
