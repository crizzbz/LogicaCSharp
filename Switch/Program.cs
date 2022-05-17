using System;


namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia = 1 ;

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Segunda-Feira");
                    break;

                case 2:
                    Console.WriteLine("terça-Feira");
                    break;

                case 3:
                    Console.WriteLine("Quarta-Feira");
                    break;

                case 4:
                    Console.WriteLine("Quinta-Feira");
                    break;

                case 5:
                    Console.WriteLine("sexta-Feira");
                    break;

                case 6:
                    Console.WriteLine("Sábado");
                    break;

                case 7:
                    Console.WriteLine("Domingo");
                    break;


                default:
                    Console.WriteLine("O Valor informado não corresponde!");

                    break;
            }

        }
    }
}
