using System;

namespace Projekt2
{
    class Program
    {
        static void Main(string[] args)
        {

            //InputBehandlare Inputdel1("1,1,5;2,2,10;");

            string[] inputarr = { "1,1,5;2,2,10;", "CIRCLE,5,3,100;CIRCLE,1,1,200;", "SQUARE,5;CIRCLE,10;" };


            //Fråga 2. Hur använder jag methoden från main? behövdes bara ett objekt av inputbehandlaren för att använda methoden. 
            InputBehandlare input1 = new InputBehandlare();
            input1.xypointscoremethod("1,1,5;2,2,10;");

        }
    }
}
