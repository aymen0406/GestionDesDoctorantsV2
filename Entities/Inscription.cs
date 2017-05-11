using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesDoctorantsV2.Entities
{
    class Inscription
    {
        public int IdInscription;
        public int IdDoctorant;
        public string AnneUniversitaire;
        public string Niveau;
        public string Commentaire;

        public Inscription(int IdInsc, int IdDoct, string AnneUniv, string Niv, string Comm)
        {
            IdInscription = IdInsc;
            IdDoctorant = IdDoct;
            AnneUniversitaire = AnneUniv;
            Niveau = Niv;
            Commentaire = Comm;
        }
    }
}
