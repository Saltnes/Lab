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
            string bob = "obobobobobobobbbooobobobbobobobobobooobbboobooboboboobboodfdfdob4bobbobooob";

           //hvor mange bobs vil bli talt her: bobob. Om det er 2, fix, så det blir 1.
            
            Console.WriteLine("Fant: " + Check.CheckOccurrences(bob, "bob") + " Bobs");

            int counter2 = 0;
            char[] chars = bob.ToCharArray();
            for (int i = 0; i < chars.Length-2; i++)
            {
                if (chars[i] == 'b' && chars[i + 1] == 'o' && chars[i + 2] == 'b')
                {
                    counter2++;//denne teller også halvbobber. hvordan unngå dette?
                    i = i + 2;
                }
            }
            Console.WriteLine(counter2);

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