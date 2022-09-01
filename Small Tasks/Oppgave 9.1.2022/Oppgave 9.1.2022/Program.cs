using System;

namespace Oppgave_9._1._2022
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tast inn en temperatur, et heltall");
            int temperatur= int.Parse(Console.ReadLine());

            if (temperatur > 0)
            {
                Console.WriteLine("varmegrader");
            }
            else
            {
                Console.WriteLine("minusgrader");
            }

        }
    }
}