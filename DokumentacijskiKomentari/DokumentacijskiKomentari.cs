﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.StrukturaPrograma
{
    class DokumentacijskiKomentari
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kvadrat(5));
            Console.WriteLine(DuljinaDvijeRiječi("dva", "2"));
        }

        /// <summary>
        ///   Izračunava kvadrat broja.
        /// </summary>
        /// <param name="broj">
        ///   Broj čiji kvadrat treba izračunati.
        /// </param>
        /// <returns>
        ///   Zadani broj na kvadrat, tipa <c>double</c>.
        /// </returns>
        static double Kvadrat(double broj)
        {
            return broj * broj;
        }

        // TODO:010 Dodati dokumentacijski komentar za donju metodu i provjeriti pojavljuje li se opis u oblačiću na mjestu poziva metode u metodi Main.
        static int DuljinaDvijeRiječi(string prva, string druga)
        {
            return (prva + druga).Length;
        }
    }
}
