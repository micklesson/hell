using System;

namespace Projekt2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] inputarr = { "1,1,5;2,2,10;", "CIRCLE,5,3,100;CIRCLE,1,1,200;", "SQUARE,5;CIRCLE,10;" };
            
            List<X_Y_PointScore> x_Y_PointScoreslist = new List<X_Y_PointScore>();
            List<X_Y_PERIMETER> x_Y_Perimeterlist = new List<X_Y_PERIMETER>();
            List<SHAPE_SCORE> shapescorelist = new List<SHAPE_SCORE>();

            //Fråga 2. Hur använder jag methoden från main? behövdes bara ett objekt av inputbehandlaren för att använda methoden. 
            InputBehandlare input1 = new InputBehandlare();
            input1.xypointscoremethod(inputarr);
            input1.xypointshapemethod(inputarr);
            input1.xypointshapescoremethod(inputarr);

            //skapar alla shapes som ligger i listan

            //hit or miss, i guess they never miss huh?

            //utskrift 
        }
    }
}
