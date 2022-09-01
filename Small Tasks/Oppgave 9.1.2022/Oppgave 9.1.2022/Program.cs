using System;

namespace Oppgave_9._1._2022
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tast inn en temperatur, et heltall"); // Tell user to input int
            int temperatur= int.Parse(Console.ReadLine()); // Set temperatur variable to user input

            if (temperatur < 0) 
            {
                Console.WriteLine("minusgrader");
            }
            else
            {
                Console.WriteLine("varmegrader");
            }

        }
    }
}