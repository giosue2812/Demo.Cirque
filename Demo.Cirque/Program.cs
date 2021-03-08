using Demo.Cirque.Classes;
using System;

namespace Demo.Cirque
{
    class Program
    {
        static void Main(string[] args)
        {
            Spectateur Spectateur = new Spectateur();
            Dresseur Dresseur1 = new Dresseur("Paul");
            Dresseur Dresseur2 = new Dresseur("François");
            Singe Singe1 = new Singe("Chita");
            Singe Singe2 = new Singe("Tania");
            Dresseur1.ExecuterTours(Singe1, Spectateur);
            Dresseur2.ExecuterTours(Singe2,Spectateur);
        }
    }
}
