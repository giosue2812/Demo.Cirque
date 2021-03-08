using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Cirque.Classes
{
    public class Spectateur
    {
        public string Applaudir(Singe singe, string tour)
        {
            return $"Le specteteur applaudit pendant le tour du {tour} de {singe.Nom}";
        }
    }
}
