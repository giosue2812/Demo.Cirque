using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Cirque.Classes
{
    /// <summary>
    /// Class who describe a "Singe"
    /// </summary>
    public class Singe
    {
        public string Nom { get; set; }
        public List<string> ToursAcrobaties { get; set; }
        public List<string> ToursMusiques { get; set; }
        /// <summary>
        /// Constructor of "Singe"
        /// </summary>
        /// <param name="nom">string name of singe</param>
        public Singe(string nom)
        {
            Nom = nom;
            AddTourMusique();
            AddToursAcrobaties();
        }
        /// <summary>
        /// Method to add "Tours" of "musique"
        /// </summary>
        /// <returns>List of "Tours Musique"</returns>
        private List<string> AddTourMusique()
        {
            ToursMusiques = new List<string>();
            ToursMusiques.Add("Jouer a la batterie");
            ToursMusiques.Add("Jouer a la guitare");
            ToursMusiques.Add("Jouer a la bass");
            return ToursMusiques;
        }
        /// <summary>
        /// Method to add a "Tours" of "Acrobaties"
        /// </summary>
        /// <returns>List of "Tours Acrobaties"</returns>
        private List<string> AddToursAcrobaties()
        {
            ToursAcrobaties = new List<string>();
            ToursAcrobaties.Add("Sauter");
            ToursAcrobaties.Add("Monter a la corde");
            ToursAcrobaties.Add("Monter a l'echelle");
            return ToursAcrobaties;
        }
    }
}
