using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula22_05
{
    internal class Carro : Veiculo
    {
        private int _qtdPortas;

        //chamando o construtor da classe base, o veiculo
        public Carro(string marca, string modelo, int qtdPortas) : base(marca, modelo)
        {
         
            _qtdPortas = qtdPortas;
        }
        public override void Ligar() //sobrescrevendo ligar
        {
            Console.WriteLine("Ligando carro");  
        }


        //sobrecarga de metodo ligar que recebe um parametro string
        public void Ligar(string keycode)
        {
            if(keycode == "1A2B")
            {
                Console.WriteLine("ligando");
            }
            else
            {
                Console.WriteLine("Erro, chave incorreta");  
            }
        }
    }
}
