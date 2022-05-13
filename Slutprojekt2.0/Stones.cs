using System;

namespace Slutprojekt2._0
{
    public class Stones
    {
        //skapar ny variabel för nummer för att skapa en random generator att använda tillsammans med.
        private int amount;
        //skapar en ny random.
        private Random number = new Random();
        //skapar en metod för hur många stenar det blir för att kunna anropa i program på ett smidigt sätt.
        public int GetStoneAmount()
        {
            //bestämmer att du kan ha 1-100 stenar.
            amount = number.Next(1, 101);
            //returnerar värdet.
            return amount;

        }
    }
}