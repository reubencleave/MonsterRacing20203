using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonsterRacing20203
{
   abstract class Punter
    {
        public string PunterName { get; set; }

        public string Monstername { get; set; }
        public string monster { get; set; }
        public Single Cash { get; set; }
        
        public Single Bet { get; set; }

        public Label LabelWinner { get; set; }

        public Color MyColor { get; set; }
    }
}