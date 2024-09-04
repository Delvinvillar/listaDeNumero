using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Formatters;

namespace listaDeNumero
{
    internal class Program
    {
        private static int[] numero;
        
        static void Main(string[] args)
        {
            try
            {

                int N = 0;
                Console.WriteLine("cunato numero quiere ingresa");
                N = Convert.ToInt32(Console.ReadLine());
                numero = new int[N];

                for (int i = 0; i < numero.Length; i++)
                {
                    Console.WriteLine($"ingrese el numero: {i}");
                    numero[i] = Convert.ToInt32(Console.ReadLine());
                }
                int menorValor = MenorNumero();
                Console.WriteLine($"el numero mas menor es : {menorValor}");

                bool repetido = VerificarRepetido();
                if (repetido)
                {
                    Console.WriteLine("si hay numero repetido");
                }
                else
                {
                    Console.WriteLine("no hay numero repetido");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"hay un error: {ex.Message}");
               
            }
              

        }

        public static int  MenorNumero()
        {
            int menor = numero[0];
            for (int j = 0; j < numero.Length; j++)
            {
                if (numero[j] < menor)
                {
                 menor = numero[j];
                }
            }

            return menor;
        }
        public static bool VerificarRepetido()
        {
           
            for (int i = 0; i < numero.Length; i++)
            {
                for (int j = i + 1; j < numero.Length; j++)
                    if (numero[1] == numero[j])
                    {
                        
                        return true;
                    }
            }
            return false;
        }
    }
}
