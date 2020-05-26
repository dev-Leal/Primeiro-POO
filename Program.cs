using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            carro objeto = new carro ();
            objeto.cor = "Preto";
            objeto.modelo = "Mustang";
            objeto.velocidade = 200; 
            objeto.Andar ();

            Console.WriteLine( objeto.cor);
            Console.WriteLine( objeto.modelo);
            Console.WriteLine( objeto.velocidade);
            Console.WriteLine(objeto.Andar());
        }    
    }   
    
}
