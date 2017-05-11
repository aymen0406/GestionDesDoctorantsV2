using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesDoctorantsV2.Entities
{
    class EnseignantChercheur
        {
            public int IdEnseignantChercheur;
            public string Nom;
            public string Prenom;
            public string Grade;
            public string Email;
            public int Telephone;
    
        public EnseignantChercheur()
        {}
        public EnseignantChercheur(int IdEnscCherch, string NomEnscCherch, string PrenomEnscCherch,
        string Grad, string mail1,int Tel)
        {
            IdEnseignantChercheur = IdEnscCherch;
            Nom = NomEnscCherch;
            Prenom = PrenomEnscCherch;
            Grade = Grad;
            Email = mail1;
            Telephone = Tel;
        }

    }
}
