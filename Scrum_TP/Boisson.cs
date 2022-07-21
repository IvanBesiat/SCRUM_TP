using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum_TP
{
    public class Boisson
    {
        public Boisson(string nom, double puAchat, double puVente, double tva, int quantiteStock)
        {
            Nom = nom;
            PuAchat = puAchat;
            PuVente = puVente;
            TVA = tva;
            QuantiteStock = quantiteStock;
        }

        public string Nom { get; set; }
        public double PuAchat { get; set; }
        public double PuVente { get; set; }
        public double TVA { get; set; }
        public int QuantiteStock { get; set; }
    }
}
