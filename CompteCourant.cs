using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte
{
    class CompteCourant :Compte
    {
        private MAD deouvert;
        public CompteCourant(Client titu, MAD solde, MAD max,MAD dect) :base(titu, solde, max)
        {
            this.deouvert = dect;
        }
    }
}
