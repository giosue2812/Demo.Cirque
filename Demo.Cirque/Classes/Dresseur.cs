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
        public string ExecuterTours(Singe singe,Spectateur spectateur)
        {
            string reaction = default;
            foreach(string item in singe.ToursAcrobaties)
            {
                Console.WriteLine("Le singe {0} acompli l'accrobatie {1}",singe.Nom, item);
                spectateur.Applaudir(singe, item, ETourEffectuer.Acrobatie);
            }
            Console.WriteLine("________________________");
            foreach (string item in singe.ToursMusiques)
            {
                Console.WriteLine("Le singe {0} joue de la musique avec {1}",singe.Nom,item);
                spectateur.Applaudir(singe, item, ETourEffectuer.Musique);
            }
            Console.WriteLine("________________________");
            return reaction;
        }
    }
}
