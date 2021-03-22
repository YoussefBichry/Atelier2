using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte
{
    class Operation
    {
        private int numero;
        private DateTime date = DateTime.Now;
        private MAD montant;
        private string libelle;
        public void afficherOpert()
        {
            Console.WriteLine(date + "| n°" + numero + "|-" + montant + "MAD");
        } 
    }
}
