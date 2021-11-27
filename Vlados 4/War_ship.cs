using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlados_4
{
    class War_ship
    {
        string name;
        int length;
        int amount_of_guns;
        int Q;

        public War_ship(string name, int length, int amount_of_guns)
        {
            this.name = name;
            this.length = length;
            this.amount_of_guns = amount_of_guns;
            this.Q = set_Q(length, amount_of_guns);
        }

        public virtual int set_Q(int length, int amount_of_guns)
        {
            return amount_of_guns / length;
        }

        public int get_Q()
        {
            return Q;
        }

    }
}


      
