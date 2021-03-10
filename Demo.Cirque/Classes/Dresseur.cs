using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Cirque.Classes
{
    /// <summary>
    /// Class who describe a "Dresseur"
    /// </summary>
    public class Dresseur
    {
        public string Nom { get; set; }
        /// <summary>
        /// Constructor of Dresseur
        /// </summary>
        /// <param name="nom">string name of dresseur</param>
        public Dresseur(string nom)
        {
            Nom = nom;
        }
        /// <summary>
        /// Method to execute tours of "Singe". 
        /// And include a method from Spectateur.
        /// </summary>
        /// <param name="singe">Singe</param>
        /// <param name="spectateur">Spectateur</param>
        public void ExecuterTours(Singe singe,Spectateur spectateur)
        {
            foreach(string item in singe.ToursAcrobaties)
            {
                Console.WriteLine("Le singe {0} acompli l'accrobatie {1}",singe.Nom, item);
                spectateur.Applaudir(singe, item, ETypeTourEffectuer.Acrobatie);
            }
            Console.WriteLine("________________________");
            foreach (string item in singe.ToursMusiques)
            {
                Console.WriteLine("Le singe {0} joue de la musique avec {1}",singe.Nom,item);
                spectateur.Applaudir(singe, item, ETypeTourEffectuer.Musique);
            }
            Console.WriteLine("________________________");
        }
    }
}
