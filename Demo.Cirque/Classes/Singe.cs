using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Cirque.Classes
{
    public class Singe
    {
        public string Nom { get; set; }
        public List<string> ToursAcrobaties { get; set; }
        public List<string> ToursMusiques { get; set; }
        public Singe(string nom)
        {
            Nom = nom;
            AddTourMusique();
            AddToursAcrobaties();
        }
        private List<string> AddTourMusique()
        {
            ToursMusiques = new List<string>();
            ToursMusiques.Add("Jouer a la batterie");
            ToursMusiques.Add("Jouer a la guitare");
            ToursMusiques.Add("Jouer a la bass");
            return ToursMusiques;
        }
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
