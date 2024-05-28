namespace aula22_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Animal a = new Animal();

            a.EmitirSom();
            a.Movimentar();

            Cachorro c = new Cachorro();

            c.Nome = "PITI"; //herdado
            c.Especie = "canino"; //herdado
            c.Idade = 9; //herdado
            c.Raca = "Indefinida"; //propriedade da classe cachorro
            c.MostrarDados();
            c.EmitirSom(); //herdado de animal
            c.Movimentar(); //herdado de animal

            //------------------
            Animal x; // declarando um animal que não sabe qual é!
            Console.WriteLine("1 para cachorro, 2 para Gato");

            int op = int.Parse(Console.ReadLine());
            if(op == 1) 
            {
                x = new Cachorro(); // da classe derivada
                x.EmitirSom();
            }
            else if (op == 2) 
            {
                x = new Gato();
                x.EmitirSom();
                x.Movimentar();
            }
            //x = new Animal(); da classe super

            */

            Veiculo v = new Veiculo("Honda", "Titan");
            Console.WriteLine(v.ToString());
            v.Ligar();
            Console.WriteLine();
            Carro carro = new Carro("Toyota", "Corolla", 4);
            Console.WriteLine(carro.ToString());
            carro.Ligar();
            //a sobrecarga:
            carro.Ligar("123");

       
        
        
        }
    }
}
