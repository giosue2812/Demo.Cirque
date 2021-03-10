using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Cirque.Classes
{
    /// <summary>
    /// Method who describe a Spectateur
    /// </summary>
    public class Spectateur
    {
        /// <summary>
        /// Method to "Appludir" when "Singe" make a "tours"
        /// </summary>
        /// <param name="singe">Singe</param>
        /// <param name="tour">string tous was executed</param>
        /// <param name="eTypeTourEffectuer">Enum who type of tour</param>
        public void Applaudir(Singe singe, string tour,ETypeTourEffectuer eTypeTourEffectuer)
        {
            if(eTypeTourEffectuer == ETypeTourEffectuer.Acrobatie)
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