using System;


namespace EntradadaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é o seu nome? ");
            string nomePessoa = Console.ReadLine();

            
            Console.Write("Qual é a sua idade? ");
            int idade = Convert.ToInt32(Console.ReadLine()); // Console.ReadLine(); Só consegue ler apenas string, então faça a conversão de int para string, Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Meu nome é: " + nomePessoa + " e tenho " + idade + " anos");




        }
    }
}