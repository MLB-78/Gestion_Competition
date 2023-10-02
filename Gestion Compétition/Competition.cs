using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Compétition
{
    public class Competition
    {
        // Attributs privés
        private int numComp;
        private string nomComp;
        private DateTime dateDebComp;
        private DateTime dateFinComp;
        private List<Personne> lesParticipants;

        // Constructeur
        public Competition(int n, string no, DateTime d1, DateTime d2)
        {
            numComp = n;
            nomComp = no;
            dateDebComp = d1;
            dateFinComp = d2;
            lesParticipants = new List<Personne>();
        }

        // Méthode pour récupérer le numéro de compétition
        public int GetNumComp()
        {
            return numComp;
        }

        // Méthode pour récupérer le nom de la compétition
        public string GetNomComp()
        {
            return nomComp;
        }

        // Méthode pour récupérer la date de début de la compétition
        public DateTime GetDateDebComp()
        {
            return dateDebComp;
        }

        // Méthode pour récupérer la date de fin de la compétition
        public DateTime GetDateFinComp()
        {
            return dateFinComp;
        }

        // Méthode pour ajouter un participant à la compétition
        public void AjoutParticipant(Personne unePers)
        {
            // Vérifier si la personne est déjà inscrite
            if (Existe(unePers.GetNomPrenom()) != -1)
            {
                throw new Exception("Cette personne est déjà inscrite à la compétition.");
            }

            lesParticipants.Add(unePers);
        }

        // Méthode pour afficher la liste des participants
        public string AfficheParticipants()
        {
            string result = "";
            foreach (Personne participant in lesParticipants)
            {
                result += participant.ToString() + Environment.NewLine;
            }
            return result;
        }

        // Méthode pour compter le nombre de participants
        public int CompteParticipants()
        {
            return lesParticipants.Count;
        }

        // Méthode pour vérifier si une personne existe dans la liste des participants
        public int Existe(string nomPrenom)
        {
            for (int i = 0; i < lesParticipants.Count; i++)
            {
                if (lesParticipants[i].GetNomPrenom() == nomPrenom)
                {
                    return i;
                }
            }
            return -1;
        }

        // Méthode pour obtenir une personne à partir de son indice
        public Personne GetPers(int i)
        {
            if (i >= 0 && i < lesParticipants.Count)
            {
                return lesParticipants[i];
            }
            throw new IndexOutOfRangeException("Indice hors limites.");
        }
    }
}
