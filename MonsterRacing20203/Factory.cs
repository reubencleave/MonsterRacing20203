using MonsterRacing20203;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterRacing2023
{
    class Factory
    {
        public static int PunterNumber { get; set; }
        public Punter GetPunter(int id)
        {
            switch (id)
            {
                case 0:
                    return new Charlotte();
                case 1:
                    return new George();
                case 2:
                    return new Peter();
                case 3:
                    return new Sophie();

                default: return null;
            }
        }
            public static int SetPunterNumber(string Name)
            {
                switch (Name)
                {
                    case "George":
                        PunterNumber = 0;
                        return PunterNumber;
                    case "Sophie":
                        PunterNumber = 1;
                        return PunterNumber;
                    case "Peter":
                        PunterNumber = 2;
                        return PunterNumber;
                    default:
                        PunterNumber = 0;
                        return PunterNumber;

            }
            }
        
    }
}
