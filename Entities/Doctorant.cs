using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesDoctorantsV2.Entities
{
    class Doctorant
    {
        int _IdDoctorant; 
          public string CIN_Passeport;
          public string NumInscription;
          public string NomFr;	
          public string NomAr;	
          public string PrenomFr;	
          public string PrenomAr;	
          public string NomJeuneFilleFr;	
          public string NomJeuneFilleAr;	
          public byte [] Photo;	
          public string Sexe;	
          public DateTime DateNaissance;	
          public string LieuNaissance;	
          public string Nationalite;	
          public string PaysOrigine;	
          public string Civilite;	
          public string Profession;	
          public string Employeur;	
          public string Email;	
          public int Telephone;
          public string Adresse;
          public string Ville;	
          public string Gouvernorat;	
          public int CodePostal;
          public string DernierDiplome;	
          public DateTime DateObtention;
          public string LieuObtention;	
          public string EcoleDoctorale;	
          public string Specialite;	
          public string Sujet;
          public string Statut;
          public string EtatPayementAC;
          public DateTime DateDepot;	
          public DateTime DateSoutenance;	
          public string TitreSoutenance;	
          public string EtatThese;	
          public string EtatDossierInscription;
          public string Observations;

          public int IdDoctorant
          {
              get { return _IdDoctorant; }
              set { _IdDoctorant = value; }
          }
        public  Doctorant()
        {
 
        }
        public Doctorant(int IdDoct,string CIN_Passe,string NumInsc,string NomFranc,string NomArab,	
          string PrenomFranc,string PrenomArabe,string NomJeuneFilleFranc,string NomJeuneFilleArab,byte [] Photo1,string genre,
          DateTime DateNaiss, string LieuNaiss,string National,string PaysOrig,string Civil,
          string Profess,string Emploi,string mail,int Tel,string Adr,string Vil,string Gouvern,
          int CodePost,string DernDipl,DateTime DateObt,string LieuObt,string EcoleDoct,	
          string Special,string Suj,DateTime DateDept,DateTime DateSout,string TitreSout,	
          string EtatTh,string EtatDossierInsc,string Observat)
        {
            
        
           IdDoctorant=IdDoct;		
           CIN_Passeport=CIN_Passe;
           NumInscription=NumInsc;
           NomFr=NomFranc;	
           NomAr=NomArab;	
           PrenomFr=PrenomFranc;	
           PrenomAr=PrenomArabe;	
           NomJeuneFilleFr=NomJeuneFilleFranc;	
           NomJeuneFilleAr=NomJeuneFilleArab;	
           Photo=Photo1;	
           Sexe=genre;	
           DateNaissance=DateNaiss;	
           LieuNaissance=LieuNaiss;	
           Nationalite=National;	
           PaysOrigine=PaysOrig;	
           Civilite=Civil;	
           Profession=Profess;	
           Employeur=Emploi;	
           Email=mail;	
           Telephone=Tel;
           Adresse=Adr;
           Ville=Vil;	
           Gouvernorat=Gouvern;	
           CodePostal=CodePost;
           DernierDiplome=DernDipl;	
           DateObtention=DateObt;
           LieuObtention=LieuObt;	
           EcoleDoctorale=EcoleDoct;	
           Specialite=Special;	
           Sujet=Suj;	
           DateDepot=DateDept;	
           DateSoutenance=DateSout;	
           TitreSoutenance=TitreSout;	
           EtatThese=EtatTh;	
           EtatDossierInscription=EtatDossierInsc;
           Observations=Observat;	
        }
		
    }
}
