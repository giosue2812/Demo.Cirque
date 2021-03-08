using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Cirque.Classes
{
    public class Spectateur
    {
        public void Applaudir(Singe singe, string tour,ETourEffectuer tourEffectuer)
        {
            if(tourEffectuer == ETourEffectuer.Acrobatie)
            {
                Console.WriteLine($"      Le specteteur applaudit pendant le tour du {tour} de {singe.Nom}");
            }
            else
            {
                Console.WriteLine($"      Le specteteur sifle pendant le tour du {tour} de {singe.Nom}");
            }
        }
    }
}
