using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlados_4
{
    class Ship_spees: War_ship
    {
        int P;
        double Qp;

        public Ship_spees(string name, int length, int amount_of_guns, int P) : base(name, length, amount_of_guns)
        {
            this.P = P;
            this.Qp = set_Q(P);
        }

        public double set_Q(int P)
        {
            int Q = base.get_Q();
            return (0.25 * Q) + (P);
        }

        public double get_Q()
        {
            return Qp;
        }
    }
}


