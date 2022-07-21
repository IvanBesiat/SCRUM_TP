using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum_TP
{
    public class Vente_Manager 
    {
        private double caisse = 100;
        public double Caisse { get => caisse; set => caisse = value; }

        public double CreationVente(Dictionary<Boisson, int> boissons,int quantite)
        {
            foreach (KeyValuePair<Boisson, int> entry in boissons)
            {
                caisse += ((entry.Key.PuVente * quantite) * ((entry.Key.TVA / 100) + 1));
                entry.Key.QuantiteStock -= quantite;
            }
            return caisse;
        }
        public double RetirerVente(Dictionary<Boisson, int> boissons, int quantite)
        {
            foreach (KeyValuePair<Boisson, int> entry in boissons)
            {
                caisse -=  ((entry.Key.PuVente * quantite) * ((entry.Key.TVA/100)+1))  ;
                entry.Key.QuantiteStock += quantite;
            }
            return caisse;
        }


        public int AjouterQuantite(Dictionary<Boisson, int> boissons, int quantite)
        {
            foreach (KeyValuePair<Boisson, int> entry in boissons)
            {
                quantite= entry.Key.QuantiteStock + quantite;
              
            }
            return quantite;
        }

    public int RetirerQuantite(Dictionary<Boisson, int> boissons, int quantite)
    {
        foreach (KeyValuePair<Boisson, int> entry in boissons)
        {
            quantite = entry.Key.QuantiteStock- quantite;

        }
        return quantite;
        }

    }

}
