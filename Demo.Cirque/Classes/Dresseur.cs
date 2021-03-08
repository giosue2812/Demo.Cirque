using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Cirque.Classes
{
    public class Dresseur
    {
        public string Nom { get; set; }

        public Dresseur(string nom)
        {
            Nom = nom;
        }
        public string ExecuterTours(Singe singe)
        {
            Random rnd = new Random();
            string toursExecuter = default;
            int[] whichTours = { 1, 2 };
            if (rnd.Next(whichTours.Length) == 1)
            {
                toursExecuter = singe.ToursAcrobaties[rnd.Next(singe.ToursAcrobaties.Count)].ToString();
            }
            else
            {
                toursExecuter = singe.ToursMusiques[rnd.Next(singe.ToursMusiques.Count)].ToString();
            }
                
            return toursExecuter;
        }
    }
}
