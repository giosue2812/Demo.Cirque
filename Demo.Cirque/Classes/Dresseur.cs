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
