using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            const int deluxePris = 2500;
            const int normalPris = 1700;
            const double rabat = 0.9;
            const int loyalitetsRabat = 200;
            string rejseValg;
            int antalRejsende;
            bool brugtTidligere = false;

            Console.WriteLine("Ønskes deluxe (ja) eller normal (nej)");
            rejseValg = Console.ReadLine();

            Console.WriteLine("Hvor mange er I der skal rejse (tal)?");

            string antalTekst = Console.ReadLine();
            antalRejsende = int.Parse(antalTekst);

            Console.WriteLine("Har I anvendt bureauet tidligere (Ja/nej)?");
            string brugtTidligereTekst = Console.ReadLine();
            //if (brugtTidligereTekst == "ja"  || brugtTidligereTekst== "Ja")
            if (brugtTidligereTekst.ToLower() == "ja")
            {
                
                brugtTidligere = true;


            }


            double rejsePris = 0;
            bool deluxe = (rejseValg.ToLower() == "ja");

            if (deluxe)
            {
                rejsePris = antalRejsende * deluxePris;
            }
            else
            {
                rejsePris = antalRejsende * normalPris;
            }
            if (antalRejsende > 10)
            {
                rejsePris = rejsePris * rabat;
            }
            if (brugtTidligere)
            {
                rejsePris = rejsePris - loyalitetsRabat;
            }

            Console.WriteLine($"Rejsenspris er { rejsePris}");

            // The LAST line of code should be ABOVE this line
        }
    }
}