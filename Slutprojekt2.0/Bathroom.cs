using System;
using System.Collections.Generic;

namespace Slutprojekt2._0
{
    public class Bathroom : Room
    {
        public int temperature { get; set; }

        public Bathroom()
        {
            roomSize = 10;
        }

        public void FlushToilet()
        {
            // anger hur du bajsat för att senare kunna lägga till mer logik
            // om man ska kunna bajsa annorlunda.
            List<string> listaFörBajs = new List<string>();
            listaFörBajs.Add("Jag har bajsat en gång.");
            Console.WriteLine(listaFörBajs[0]);

            // anger ordningen för barskorvarna/hur många du bajsar åt gången.
            // Du börjar bajsa en bajs, eftersom det är en queue kommer du bajsa mer
            // om programmet loopar.
            Queue<int> ordningFörBajskorvarna = new Queue<int>();

            ordningFörBajskorvarna.Enqueue(1);
            ordningFörBajskorvarna.Enqueue(2);
            ordningFörBajskorvarna.Enqueue(3);

            Console.WriteLine(ordningFörBajskorvarna.Peek());

            int bajskorvar = ordningFörBajskorvarna.Dequeue();

            // Hur mycket papper du använder, alltså desto mer programmet loopar,
            // ju mindre papper kommer du använda/ha kvar.
            Stack<int> antalToiletWipes = new Stack<int>();

            antalToiletWipes.Push(1);
            antalToiletWipes.Push(2);
            antalToiletWipes.Push(3);

            Console.WriteLine(antalToiletWipes.Peek());

            int toiletWipes = antalToiletWipes.Pop();

            System.Console.WriteLine("Poop out, I flush toilet ;)");


        }
    }
}