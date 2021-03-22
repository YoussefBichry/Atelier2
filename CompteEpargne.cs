using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte
{
    class CompteEpargne :Compte
    {
        private double TauxInteret;
        public CompteEpargne(Client titu,MAD solde,MAD max) : base(titu, solde, max)
        {
            double taux = double.Parse(Console.ReadLine());
            while(taux<=0 || taux > 100)
            {
                Console.WriteLine("donnez le taux");
                taux = double.Parse(Console.ReadLine());
            }
            this.TauxInteret = taux;
        }
        public void calculInteret()
        {
           solde += solde * TauxInteret / 100;
        }

    }
}
