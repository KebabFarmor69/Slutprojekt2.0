using System;

namespace Slutprojekt2._0
{
    public class Room
    {
        // för att bestämma storlek på rummet, eftersom det är en protected,
        // betyder det att klasserna kan ärva variabeln men utomstående klasser
        // kommer ej åt det. 
        protected int roomSize;


        //gör "om" den till en konstruktor för att smidigare kunna kalla på allt innehåll däri,
        // dvs när mer logik kommer in blir det smidigare och snyggare.
        public Room()
        {
            roomSize = 20;
        }

    }

}