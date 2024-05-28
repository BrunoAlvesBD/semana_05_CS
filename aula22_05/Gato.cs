using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula22_05
{
    internal class Gato : Animal
    {


        public override void EmitirSom()
        {
            base.EmitirSom(); // som de animal
            Console.WriteLine("Gato miando de madrugada");
        }

        public override void Movimentar()
        {
            base.Movimentar(); // animal padrão
            Console.WriteLine("Gato em cima do fogão");
        }
    }
}
