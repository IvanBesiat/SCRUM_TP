using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum_TP
{
    public class Achat_Manager
    {
        public Achat_Manager()
        {
        }

        public double CalculMontantCMD(Dictionary<Boisson,int> boissons)
        {
            double prixCMD = 0;
            foreach(KeyValuePair<Boisson,int> entry in boissons)
            {
                prixCMD += entry.Key.PuAchat * entry.Value;
            }
            return prixCMD;
        }
    }
}
