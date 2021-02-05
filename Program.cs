﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Entities;
using TP2.Utils;

namespace TP2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (var item in FakeDb.Instance.Users)
            {
                Console.WriteLine(item);
            }

            #region Q1
            Console.WriteLine("Question 1");
            // Afficher le nombre de personne s'appelant Dupond ou Dupont.
            var q1 = FakeDb.Instance.Users.Count(x => x.Lastname.Equals("Dupond") || x.Lastname.Equals("Dupont"));
            Console.WriteLine("Réponse question 1\n\tNombre de personnes s'appelant \"Dupond\" ou \"Dupont\" : " + q1);
            #endregion
            #region Q2
            Console.WriteLine("Question 2");
            // Afficher les personnes enregistré avec le role Automobiliste.
            var q2 = FakeDb.Instance.Users.Where(x => x.Roles.Select(y => y.Name).Any(y => y.Equals("Automobiliste")));
            Console.WriteLine("Réponse question 2\n\tPersonnes ayant le rôle \"Automobiliste\" : " + q2);
            #endregion
            #region Q3
            Console.WriteLine("Question 3");
            // Afficher les plaques d'immatriculation de toutes les voitures (une seule fois par voiture) liées à au moins un utilisateur.
            var q3 = FakeDb.Instance.Users.SelectMany(x => x.Cars).Select(x => x.Registration);
            Console.WriteLine("Réponse question 3\n\tPlaques d'immatriculations des voitures liées à au moins un utilisateur : " + q3);
            #endregion
            #region Q4
            Console.WriteLine("Question 4");
            // Afficher la ou les voiture(s) avec le plus de kilomètre
            var q4 = FakeDb.Instance.Cars.Max(x => x.Mileage);
            Console.WriteLine("Réponse question 4\n\tVoitures ayant le plus de kilomètres : " + q4);

            #endregion
            #region Q5
            Console.WriteLine("Question 5");
            // Afficher le classement des types de voiture par nombre de voiture unique présentes du plus grand au plus petit.

            #endregion
            #region Q6
            Console.WriteLine("Question 6");
            // Afficher les "Garagiste" liés à 4 voitures ou plus.

            #endregion
            #region Q7
            Console.WriteLine("Question 7");
            // Afficher les "Controlleur" et la liste des voitures aux quelles ils sont liés.

            #endregion
            Console.ReadKey();
        }
    }
}
