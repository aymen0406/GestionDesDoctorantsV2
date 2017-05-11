using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesDoctorantsV2.Entities
{
    class TypeDocument
    {
        public int IdTypeDocument;
        public string Code;
        public string LibelleFr;
        public string LibelleAr;

        public TypeDocument() { }

        public TypeDocument(int id, string code1, string nomFr, string nomAr)
        {
            IdTypeDocument = id;
            Code = code1;
            LibelleFr = nomFr;
            LibelleAr = nomAr;
        }
    }
}
