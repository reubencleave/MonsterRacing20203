using System;
using System.Collections.Generic;
using System.Linq;
using System.Text
using System.Threading.Tasks

namespace MonsterRacing2023
{
    class Factory
    {
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
    }
}
