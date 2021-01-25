using System;

namespace Metodi
{
    public class Calcoli
    {
        public static void Somma(int[] array)
        {
            int somma = 0;
            for (int i=0; i < array.Length; i++)
            {
                somma = somma + array[i];

            }
            Console.Write($"La somma è: {somma} ");
            Console.ReadLine();
        }
    }
}
