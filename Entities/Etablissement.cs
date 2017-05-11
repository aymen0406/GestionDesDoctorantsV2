using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesDoctorantsV2.Entities
{
    class Etablissement
    {
        public int IdEtablissement;
        public string NomEtablissement;
        public string Pays;
        public string Ville;
        public Etablissement() { }
        public Etablissement(int IdEtab,string NomEtab,string PaysEtab, string VillEtab )
        {
            IdEtablissement = IdEtab;
            NomEtablissement = NomEtab;
            Pays = PaysEtab;
            Ville = VillEtab;
        }
    }
}