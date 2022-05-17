using System;


namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Jéssica";
            string sobrenome = "Ferreira";
            //Console.WriteLine(string.Concat(nome, sobrenome));
            string nomeCompleto = $"{nome} {sobrenome}";
            Console.WriteLine(nomeCompleto);
            int posicao = nomeCompleto.IndexOf("F");
            //pegar o sobrenome
            string nomeFinal = nomeCompleto.Substring(posicao);
            Console.WriteLine(nomeFinal);
            Console.WriteLine(nomeFinal.ToUpper());
            Console.WriteLine(nomeFinal.ToLower());
        }
    }
}
