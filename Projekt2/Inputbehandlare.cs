using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektarbeteSENASTE
{
    public class Inputbehandlare
    {


        //"1,1,5;2,2,10;"    "CIRCLE,5,3,100;CIRCLE,1,1,200;"    "SQUARE,5;CIRCLE,10;"

        string[] inputarr = { "1,1,5;2,2,10;", "CIRCLE,5,3,100;CIRCLE,1,1,200;", "SQUARE,5;CIRCLE,10;" };

        public void xypointscoremethod(string inputarg1)
        {
            List<X_Y_PointScore> x_Y_PointScoreslist = new List<X_Y_PointScore>();

            //Fråga 1 till handledningen. tanken med loopen nedan är att göra första X kordinat Y kordinat och pointscore
            //till ett object. 
            //kommer detta funka? Hur provar vi om detta funkar? bägge objekt ska lagras i en lista. 

            string s = inputarr[0];
            string[] sarr = s.Split(';');
            //split bör ske innan loop (handlednig)
            // för shape switch för första index beorende på filken form inputen är. CIRCLE / SQUARE

            for (int i = 0; i < sarr.Length; i++)
            {
                string[] sarr1 = sarr[i].Split(',');
                double x = Convert.ToDouble(sarr1[0]);
                double y = Convert.ToDouble(sarr1[1]);
                double pointscore = Convert.ToDouble(sarr1[2]);

                X_Y_PointScore point1 = new X_Y_PointScore(x, y, pointscore);
                x_Y_PointScoreslist.Add(point1);
            }
            //det kommer bli två objekt. kommer hamna som två objekt i listan. referera till indexpositionen i listan. 
        }







    }
}
