using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula22_05
{
    internal class Veiculo
    {
        private string _marca;
        private string _modelo;

        public Veiculo(string marca, string modelo)
        {
            _marca = marca;
            _modelo = modelo;   
        }

        public virtual void Ligar() //vai ser sobrescrito
        {
            Console.WriteLine("Ligando");
        }
        public override string ToString() // sobrescrevendo o toString
        {
            return "Marca: "+_marca+" Modelo: " +_modelo;
        }
    }
}
