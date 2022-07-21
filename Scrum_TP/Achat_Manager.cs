using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum_TP
{
    public class Achat_Manager
    {
        double prixCMD = 0;
        Dictionary<Boisson,int> boissonDict;

        public Achat_Manager(Dictionary<Boisson, int> boissons)
        {
            this.boissonDict = boissons;
        }

        public double CalculMontantCMD()
        {
            foreach(KeyValuePair<Boisson,int> entry in boissonDict)
            {
                prixCMD += entry.Key.PuAchat * entry.Value;
            }
            return prixCMD;
        }

        public string AuguementerStockBoisson()
        {
            string result = null;
            foreach (KeyValuePair<Boisson, int> entry in boissonDict)
            {
                entry.Key.QuantiteStock += entry.Value;
                result += string.Format("Le nouveau stock de {0} est de {1} unite(s).", entry.Key.Nom, entry.Key.QuantiteStock);
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
