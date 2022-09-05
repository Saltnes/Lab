using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Koden under er snippets. Oppgaven er på slutten av fila.
            //Skriv koden i Main
            //lesestoff: https://www.w3schools.com/cs/cs_for_loop.asp
            //Det finnes flere typer loops. Her er de forskjellige med eksempler:

            //*************while**************************

            Console.WriteLine("while");

            /* local variable definition */
            int a = 10;

            /* while loop execution */
            while (a < 20)
            {
                Console.WriteLine("value of a: {0}", a);
                a++;
            }
            //denne går så lenge (while) er mindre enn 20. a++ betyr at a øker med 1 for hver "runde" 


            //*************for**************************

            //I en for loop bestemmer du som programmerer start, stop og hvor mye den skal øke for hver runde
            Console.WriteLine("for loop");

            /* for loop execution */
            for (int i = 10; i < 20; i++) //i øker med 1 for hver runde. 
            {
                Console.WriteLine("value of i: {0}", i);
            }

            //Du kan også bruke variabler av typen int istedenfor å skirve 10 og 20

            Console.WriteLine("for loop eks 2");

            int start = 10;
            int stopp = 20;

            for (int i = start; i < stopp; i++) //i øker med 1 for hver runde. 
            {
                Console.WriteLine("value of i: {0}", i);
            }


            //*************do while**************************

            //Dette er broren til while. Forskjellen er at betingelsen/testen dukker opp i slutten av loopen, slik at innholdet i loopen kjører en gang før testen blir gjennomført.

            Console.WriteLine("do while");

            /* local variable definition */
            int dw = 10;

            /* do loop execution */
            do
            {
                Console.WriteLine("value of dw: {0}", dw);
                dw = dw + 1; //det samme som dw++;
            } while (dw < 20);


            //*************foreach**************************

            //Denne loopen går igjennom elementer eller variabler. For hvert element.... Har du 5 elementer går den 5 ganger
            //Vi tester med å lage en array. Loopen vil gå igjennom arrayen i den rekkefølgen det er.

            Console.WriteLine("foreach");

            // creating an array 
            int[] array = new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

            // foreach loop begin 
            // it will run till the 
            // last element of the array 
            foreach (int item in array)
            {
                Console.WriteLine("value of item: " + item);
            }

            Console.WriteLine("foreach eksempel 2");

            string navn = "Ragnar"; //vi lager en variabel av typen string og gir den verdien Ragnar
            foreach (char bokstav in navn) //char står for et tegn/bokstav. Så dette betyr for hvert tegn i Ragnar
            {
                Console.WriteLine("value of item: " + bokstav);
            }

            //Sånn, da er det nok eksempler for å gjøre oppgaver.

            //Oppgave 1
            //Skriv kode som ber bruker om å taste inn sitt navn. Lagre denne i en variabel av typen string. (Fordi det er tekst). Bruk Console.ReadLine();
            //Bruk en foreach loop til å skrive ut et og et tegn i denne variabelen.

            //Oppgave 2
            //Lag en for loop som skriver ut 5 stykk av dette tegnet *


          

                Console.WriteLine("Type your name: ");
               // string name = Console.ReadLine();
                string name = "*****";
                foreach (char letter in name)
                {
                    Console.WriteLine("Letter: " + letter);
                }
        }
    }
}