using System;

namespace Slutprojekt2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Först förs en try-catch metod för all kod som läser av om du skriver en siffra 
            // eller text med hjälp av int.Parse för att avgöra om spelar skrivit in rätt värde,
            // dvs ett nummer och inte bokstäver. Varför detta görs är för att skalan som anges är
            // siffror, alltså för att fortsätta bör du skriva in siffror.
            //(den är till för att kontrollera att all kod sker på rätt sätt för att minimera fel.)
            try
            {
                System.Console.WriteLine("på en skala 1-100 hur bajsig är du?");

                int yes = int.Parse(Console.ReadLine());

                Console.WriteLine("Hello World!");

                //deklarerar variabler för klasserna för att anropa metoderna. Eftersom sauna ärver av
                // bathroom har jag använt bathroom för att anropa sauna.
                Bathroom toilet = new Bathroom();
                Bathroom sauna = new Sauna();

                //skriver ut teperaturen hämtat från sauna konstruktorn för att informera spelaren om temperaturen.
                Console.WriteLine(sauna.temperature);


                toilet.FlushToilet();


                Console.ReadLine();
            }
            catch
            {
                System.Console.WriteLine("I pooped outside toilet");
                Console.ReadLine();

            }

        }
    }
}
