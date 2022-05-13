using System;

namespace Slutprojekt2._0
{
    public class Sauna : Bathroom
    {
        private int saunaStones;
        private Stones stenar = new Stones();
        public Sauna()
        {
            // kallar in instansen för temperatur genom get, för att bestämma temperaturen och ej 
            // göra att du kan ändra den t.ex i konsollen senare.
            temperature = 80;
            // sätter att private int blir metoden stones ^^ som i sin tur kallar in hur många stenar man har,
            // för att göra det dynamiskt med hur många stenar man kan ha samt för att stones är en egen klass, eftersom 
            // de är ett eget objekt.
            saunaStones = stenar.GetStoneAmount();

            System.Console.WriteLine("Fan, jag har typ " + saunaStones + " stenar! Helt jävla galet!");
        }
    }
}