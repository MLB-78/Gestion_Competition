using Gestion_Compétition;
using System;
using System.Collections.Generic;

namespace Gestion_Compétition
{
    class Program
    {


        static void Main(string[] args)
        {
            //liste compet
            List<Competition> lesCompetitions = new List<Competition>();

            try
            {

                Console.WriteLine("\nListe des compétitions et participants :");
                foreach (Competition competition in lesCompetitions)
                {
                    Console.WriteLine(competition.ToString());
                }

                Console.WriteLine($"\nNombre total de personnes enregistrées : {Personne.GetNombrePersonnes()}");

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur s'est produite : {ex.Message}");
            }

            try
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Saisie de la compétition {i + 1}:");
                    Console.Write("Numéro de compétition : ");
                    int numComp = int.Parse(Console.ReadLine());
                    Console.Write("Nom de la compétition : ");
                    string nomComp = Console.ReadLine();
                    Console.Write("Date de début (format yyyy-MM-dd) : ");
                    DateTime dateDebComp = DateTime.Parse(Console.ReadLine());
                    Console.Write("Date de fin (format yyyy-MM-dd) : ");
                    DateTime dateFinComp = DateTime.Parse(Console.ReadLine());

                    if (dateDebComp > dateFinComp)
                    {
                        throw new Exception("La date de début ne peut pas être supérieure à la date de fin.");
                    }

                    Competition competition = new Competition(numComp, nomComp, dateDebComp, dateFinComp);
                    lesCompetitions.Add(competition);
                }

                List<Personne> lesParticipants = new List<Personne>();
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine($"Saisie du participant {i + 1}:");
                    Console.Write("Nom et prénom du participant : ");
                    string nomPrenom = Console.ReadLine();
                    Console.Write("Adresse du participant : ");
                    string adresse = Console.ReadLine();
                    Personne participant = new Personne(nomPrenom, adresse);
                    lesParticipants.Add(participant);
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.WriteLine($"Ajout du participant {j + 1} à la compétition {i + 1}:");
                        int indexCompetition = i;
                        int indexParticipant = j;
                        try
                        {
                            lesCompetitions[indexCompetition].AjoutParticipant(lesParticipants[indexParticipant]);
                            Console.WriteLine("Participant ajouté avec succès.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erreur : {ex.Message}");
                        }
                    }
                }

                Console.WriteLine("\nListe des compétitions et participants :");
                foreach (Competition competition in lesCompetitions)
                {
                    Console.WriteLine(competition.ToString());
                }

                Console.WriteLine($"\nNombre total de personnes enregistrées : {Personne.GetNombrePersonnes()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur s'est produite : {ex.Message}");
            }
        }
    }

}
