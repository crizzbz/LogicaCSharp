using System;


namespace CondicaoifElse
{
    class Program
    {
        static void Main(string[] args)
        {

            //bool gostoDeGoiaba = true;
            //if(gostoDeGoiaba == false)
            //{
            //    Console.WriteLine("Eu compro");
            //}

            //else
            //{
            //    Console.WriteLine("Eu não compro");
            //}


            int time = 10;

            string resultado = (time < 12) ? "bom diaa" : "boatardee"; //if else ternario (?) se/if || (:) se não/ else
            Console.WriteLine(resultado);

            //if (time < 12)
            //{
            //    Console.WriteLine("bom diaa");
            //}

            //else if (time < 18)
            //{
            //    Console.WriteLine("Boa tardee");
            //}

            //else
            //{
            //    Console.WriteLine("Boa noite");
            //}

        }
    }
}
