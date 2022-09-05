using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFindBob
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Oppgave
            //lag en metode som finner ut hvor mange bob's det er i stringen under.
            string bob = "obobobobobobobbbooobboboobobobobobobooobbboobooboboboobboodfdfdob4bobbobooob";
            
            Console.WriteLine("Fant: " + Check.CheckOccurrences(bob, "bob") + " Bobs");
        }
    }

    public static class Check
    {
        public static int CheckOccurrences(string str1, string pattern)
        {
            int count = 0;
            int a = 0;
            while ((a = str1.IndexOf(pattern, a)) != -1)
            {
                a += pattern.Length;
                count++;
            }

            return count;
        }
    }
}