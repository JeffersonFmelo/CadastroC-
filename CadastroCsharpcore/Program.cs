using System;

namespace CadastroCsharpcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Digite seu nome:");

            // codigo para guardar o nome do usuario
            string nome = Console.ReadLine();


            Console.WriteLine();

            Console.WriteLine("Seja Bem  Vindo ! {0}", nome);
            Console.WriteLine();

            Console.Write("Digite sua idade: ");


            //codigo  para guardar a idade do usuario na variavel            
            var idade = Console.ReadLine();

            //  conversão  da idade do tipo  strig para Int32 atraves  do método Convert
            int idadeCovertida = Convert.ToInt32(idade);

            Console.WriteLine();

            // Validacão da  idadedo usuario 

            if (idadeCovertida > 18)
            {
                Console.WriteLine($"Entre e veja nosso conteúdo {nome}");
                Console.WriteLine(" Deseja sair? s/n");

                string s = "s";

                //  conversão da string s  em  char
                char sim = Convert.ToChar(s);

                if ()
                {

                }



            }
            else
            {
                Console.WriteLine("Voce não  esta  autorizado a entrar");
            }

        }
    }
}
