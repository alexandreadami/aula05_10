using System;

namespace ConsoleCadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Mundo!");

            int a = 1;
            int b = 2;

            int resultado = a + b;

            Console.WriteLine(resultado);

            string caixaDeTexto = "Alexandre " + "Adami";
            Console.WriteLine(caixaDeTexto);

            double d = 2.1;
            float f = 2.1f;

            char S = '1';

            var livro = 1;

            livro = 2;

            FazerCafe("caramelo");
            FazerCafe("chocolate");

            
        }

        static void FazerCafe(string capsula){
            System.Console.WriteLine("Esquentar agua");
            System.Console.WriteLine("colocar po de cafe");
            System.Console.WriteLine("colocar " + capsula);
        }

    }
}
