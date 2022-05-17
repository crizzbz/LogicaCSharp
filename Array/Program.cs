using System;


namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carros = { "Fusca", "Brasilia", "Ônix", "Volvo"};
            int[] numeros = { 1, 2, 3, 4};

            carros[2] = "Passat Amarelo";
            //Console.WriteLine(carros.Length);

            for (int i = 0; i < carros.Length; i++)
            {
                Console.WriteLine(carros[i]);
            }

        }
    }
}
