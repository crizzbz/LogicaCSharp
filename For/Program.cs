using System;


namespace CondicaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 8; i++)
            {
                if(i == 4)
                {
                    //break; // se o i for igual a 4, vai parar a contagem
                    continue; // a contagem vai pular o numero 4, ou seja, o continue pula o numero se o i for = 4
                }
                Console.WriteLine(i);
            }

            //string[] carros = { "Fusca", "Brasilia", "Varianti"};
            //foreach(string y in carros)
            //{
            //    Console.WriteLine(y);
            //}

        }
    }
}
