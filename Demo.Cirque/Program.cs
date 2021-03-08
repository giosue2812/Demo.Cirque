using Demo.Cirque.Classes;
using System;

namespace Demo.Cirque
{
    class Program
    {
        static void Main(string[] args)
        {
            string tourExecuter = default;
            Spectateur Spectateur = new Spectateur();
            Dresseur Dresseur1 = new Dresseur("Paul");
            Dresseur Dresseur2 = new Dresseur("François");
            Singe Singe1 = new Singe("Chita");
            Singe Singe2 = new Singe("Tania");

            tourExecuter = Dresseur1.ExecuterTours(Singe1);
            
            Console.WriteLine("Le dresseur {0} va demander aux singe {1} d'executer le tour {2}",Dresseur1.Nom,Singe1.Nom, tourExecuter);
            Console.WriteLine( Spectateur.Applaudir(Singe1, tourExecuter));

            tourExecuter = Dresseur2.ExecuterTours(Singe2);

            Console.WriteLine("Le dresseur {0} va demander aux singe {1} d'executer le tour {2}", Dresseur2.Nom, Singe2.Nom, tourExecuter);
            Console.WriteLine(Spectateur.Applaudir(Singe2, tourExecuter));
        }
    }
}
