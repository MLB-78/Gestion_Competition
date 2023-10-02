using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Compétition
{
    // var
    public class Personne
    {
        private string nomPrenom;        
        private string adresse;          
        private static int nombrePersonnes = 0; 

        // constructeur
        public Personne()
        {
            nomPrenom = "Inconnu";
            adresse = "Inconnue";
        }

        // Constructeur parametré
        public Personne(string n, string a)
        {
            nomPrenom = n;
            adresse = a;
            nombrePersonnes++; 
        }

        // pour récuple nom et prénom 
        public string GetNomPrenom()
        {
            return nomPrenom;
        }

        //  le nom et prénom 
        public void SetNomPrenom(string np)
        {
            nomPrenom = np;
        }

        // pour récup l'adresse 
        public string GetAdresse()
        {
            return adresse;
        }

        // pour recup l'adresse
        public void SetAdresse(string adr)
        {
            adresse = adr;
        }

        // to string
        public override string ToString()
        {
            return $"Nom et prénom : {nomPrenom}, Adresse : {adresse}";
        }

        // connaitre le nombre de pers
        public static int GetNombrePersonnes()
        {
            return nombrePersonnes;
        }
    }
}
