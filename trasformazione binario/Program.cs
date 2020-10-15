using System;

namespace trasformazione_binario
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resto, valorebase;
            string numeroconvertito = "";
            Console.WriteLine("inserisci la base da convertire");
            valorebase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserire il dato da convertire");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                resto = num % valorebase;
                if (resto == 15)
                {
                    numeroconvertito += "f";
                }
                else if (resto == 14)
                {
                    numeroconvertito += "e";
                }
                else if (resto == 13)
                {
                    numeroconvertito += "d";
                }
                else if (resto == 13)
                {

                }
                else if (resto == 12)
                {
                    numeroconvertito += "c";
                }
                else if (resto == 11)
                {
                    numeroconvertito += "b";
                }
                else if (resto == 10)
                {
                    numeroconvertito += "a";
                }
                else
                {
                    numeroconvertito = Convert.ToString(resto) + numeroconvertito;
                }
                num = num / valorebase;
            }
            Console.WriteLine($"il numero convertito in base {valorebase} è : {numeroconvertito}");
            Console.ReadLine();

        }
    }
}
