using System;
using System.Collections.Generic;


namespace SalonUrody
{
    internal class Program
    {
        class Lokal { 
            public string Adres { get; set; }
            public string NumerTelefony { get; set; }
            public double StawkaCzynszu { get; set; }
        }

        class Wyposazenie
        {
            public string Nazwa { get; set; }
        }

        class SalonUrody
        {
            Lokal Lokal;
            List<Pracownik> ListaPracownikow = new List<Pracownik>();
            List<Wyposazenie> Wyposazenie = new List<Wyposazenie>();

            public void setLokal(Lokal lokal)
            {
                Lokal = lokal;
            }

            public void DodajPracownika(Pracownik pracownik)
            {
                ListaPracownikow.Add(pracownik);
            }

            public void DodajWyposazenie(Wyposazenie wyposazenie)
            {
                Wyposazenie.Add(wyposazenie);
            }
        }

        abstract class Pracownik { }
        class Kosmetyczka : Pracownik { }
        class Fryzjerka : Pracownik { }
        class Manicurzystka : Pracownik { }

        static void Main(string[] args)
        {
            Kosmetyczka k1 = new Kosmetyczka();
            Kosmetyczka k2 = new Kosmetyczka();
            Fryzjerka f1 = new Fryzjerka();
            Manicurzystka m1 = new Manicurzystka();

            Lokal l = new Lokal();
            l.Adres = "Dymbiec koło T19";
            l.NumerTelefony = "997";
            l.StawkaCzynszu = 123.45;

            Wyposazenie sz1 = new Wyposazenie();
            sz1.Nazwa = "Head Shampoon";
            Wyposazenie g1 = new Wyposazenie();
            g1.Nazwa = "Grzebień";

            SalonUrody salon = new SalonUrody();
            salon.setLokal(l);
            salon.DodajPracownika(k1);
            salon.DodajPracownika(k2);
            salon.DodajPracownika(f1);
            salon.DodajPracownika(m1);
            salon.DodajWyposazenie(sz1);
            salon.DodajWyposazenie(g1);
        }
    }
}
