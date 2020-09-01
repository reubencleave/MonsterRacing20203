using System;
using System.Drawings;
using System.Reflection.Emit;

namespace MonsterRacing20203
{
   abstract class Punter
    {
        public string Puntername { get; set; }

        public string Monstername { get; set; }
        
        public Single Cash { get; set; }
        
        public Single Bet { get; set; }

        public Label LabelWinner { get; set; }

        public Color MyColor { get; set; }
    }
}