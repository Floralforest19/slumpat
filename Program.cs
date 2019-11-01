using System;// Viktigt med att det är versal bokstav i variabeln System, kompilatorn förstår inte annars.

namespace Uppgift_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklaration av variabler
            Random slumpat = new Random(); // skapar ett random objekt
            int speltal = slumpat.Next(1, 20); // anropar Next metoden för att skapa ett slumptal mellan 1 och 20
            //Inom paranteserna bestämmer du inom vilket spann slumpningen ska vara.
            bool spela = true; // Variabel för att kontrollera om spelet ska fortsätta köras

            while (spela)
            {
                Console.WriteLine("\n\tGissa på ett tal mellan 1 och 20: ");

                if (!Int32.TryParse(Console.ReadLine(), out int tal))//! i if() är samma sak som == false. Så om Int32.TryParse inte ger tillbaka true
                {
                    Console.WriteLine("\tDu angav ingen siffra");
                }

                else if (tal < speltal)

                {
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för litet, försök igen.");
                }

                else if (tal > speltal)
                {
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för stort, försök igen.");// Saknades ett + då kompilatorn måste plussa ihop informationen.
                }

                else if (tal == speltal)// Saknades ett =, du måste ha två st annars tror kompilatorn att du ska döpa en variabel
                {
                    Console.WriteLine("\tGrattis, du gissade rätt!");
                    spela = false;//programmet måste ligga inom måsvingar, alt tabbat annars kommer funktionen att krascha
                }
            }
        }
    }
}
